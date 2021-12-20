using BookStorageBusinessLogic.BindingModels;
using BookStorageBusinessLogic.BusinessLogics;
using BookStorageBusinessLogic.ViewModels;
using ClassLibraryControlsFilippov;
using Library_NotVisualComponents.HelperModels;
using NonVisualComponentsLibrary.HelperModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using WindowsFormsComponentLibrary.HelperModels.Configs;
using WindowsFormsComponentLibrary.HelperModels.Word;
using WindowsFormsControlLibrary.HelperModel;
using static Library_NotVisualComponents.DocumentWithDiagram;

namespace BookStorageView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly BookBusinessLogic _bookLogic;
        private readonly ReportLogic _reportLogic;
        private readonly BookFormBusinessLogic _bookFormtLogic;
        private List<BookViewModel> books;
        private readonly ControlOutputListBoxLayout layout = new ControlOutputListBoxLayout
        {
            EndSign = '}',
            StartSign = '{',
            Layout = "Форма - {BookForm}; Идентификатор - {Id}; Название - {BookName}; Аннотация - {Annotation}"
        };


        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(BookBusinessLogic bookBusinessLogic, ReportLogic reportLogic, BookFormBusinessLogic bookFormBusinessLogic)
        {
            InitializeComponent();
            _bookLogic = bookBusinessLogic;
            _reportLogic = reportLogic;
            _bookFormtLogic = bookFormBusinessLogic;
        }

        private void CreateWordContextTable(string fileName)
        {
            ComponentWordContextTablesConfig config = new ComponentWordContextTablesConfig
            {
                WordInfo = new WordInfo
                {
                    Path = fileName,
                    Title = "Word документ по читателям"
                },
                Tables = _reportLogic.GetStringBookTables()
            };

            componentWordContextTables.CreateContextTables(config);
        }

        private void отчотПоЧитателямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "docx file | *.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sfd.FileName))
                {
                    MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CreateWordContextTable(sfd.FileName);
            }
        }

        private void CreatePdfTable(string fileName)
        {
            tableComponent.CreateDocument<BookViewModel>(new TableParameters<BookViewModel>
            {
                DataList = _bookLogic.Read(null),
                Path = fileName,
                Title = "PDF документ по всем книгам",
                CellsFirstColumn = new List<TableCell>
                {
                    new TableCell
                    {
                        Name = "Идентификатор книги",
                        PropertyName = "Id",
                        RowHeight = "1cm"
                    },
                    new TableCell
                    {
                        Name = "Название книги",
                        PropertyName = "BookName",
                        RowHeight = "1cm"
                    },
                    new TableCell
                    {
                        Name = "Описание",
                        CountCells = 2,
                        RowHeight = "10cm"
                    }
                },
                CellsSecondColumn = new List<TableCell>
                {
                    new TableCell
                    {
                        Name = "Форма книги",
                        PropertyName = "BookForm"
                    },
                    new TableCell
                    {
                        Name = "Аннотация",
                        PropertyName = "Annotation"
                    }
                }
            });
        }

        private void отчотПоКнигамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "pdf file | *.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sfd.FileName))
                {
                    MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CreatePdfTable(sfd.FileName);
            }
        }

        private void CreateExlDiagram(string fileName)
        {
            List<DiagramSeries> listSeries = new List<DiagramSeries>();

            var bookForms = _bookFormtLogic.Read(null);
            foreach(var forms in bookForms)
            {
                listSeries.Add(new DiagramSeries
                {
                    Name = forms.BookForm,
                    Values = _reportLogic.GetCountForm(forms.BookForm)
                });
            }

            documentWithDiagram.CreateFile(fileName, "Диаграмма xlsx", "Книги по анотациям", listSeries, LegendPosition.Right, 
                _xSeries: new string[] { "100-120", "120-140", "140-160", "160-180", "180-200" });
        }

        private void дианграммаПоФормамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "xls file | *.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sfd.FileName))
                {
                    MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CreateExlDiagram(sfd.FileName);
            }
        }

        //private void LoadData()
        //{
        //    try
        //    {
        //        if(books == null)
        //        {
        //            books = new List<BookViewModel>();
        //        } 
        //        outputComponent.setSeparatingCharacters("{,}");
        //        outputComponent.LayoutLine = " Форма - {BookForm}, Идентификатор - {Id}, Название - {BookName}, Аннотация - {Annotation}";
        //        var booksList = _bookLogic.Read(null);
        //        var elements = booksList.Select(rec=> rec.Id).Except(books.Select(rec => rec.Id));
        //        foreach(var Ids in elements)
        //        {
        //            outputComponent.AddItem<BookViewModel>(booksList.FirstOrDefault(rec => rec.Id == Ids));
        //            books.Add(booksList.FirstOrDefault(rec => rec.Id == Ids));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void LoadData()
        {
            this.Controls.Remove(controlOutputlListBox);
            controlOutputlListBox = new ControlOutputlListBox
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(controlOutputlListBox);
            controlOutputlListBox.SetLayout(layout);
            try
            {
                var list = _bookLogic.Read(null);
                int placePozition = 0;
                foreach (var supplier in list)
                {
                    if (placePozition < list.Count())
                    {
                        controlOutputlListBox.Insert(supplier, placePozition, "BookForm");
                        controlOutputlListBox.Insert(supplier, placePozition, "Id");
                        controlOutputlListBox.Insert(supplier, placePozition, "BookName");
                        controlOutputlListBox.Insert(supplier, placePozition, "Annotation");
                        placePozition++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBook form = Container.Resolve<FormBook>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controlOutputlListBox.SelectedIndex >= 0)
            {
                FormBook form = Container.Resolve<FormBook>();
                form.Id = Convert.ToInt32(controlOutputlListBox.GetSelectedItem<BookViewModel>()?.Id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controlOutputlListBox.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(controlOutputlListBox.GetSelectedItem<BookViewModel>()?.Id);
                    try
                    {
                        _bookLogic.Delete(new BookBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void добавитьЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReaders form = Container.Resolve<FormReaders>();
            form.ShowDialog();
        }

        private void controlOutputlListBox_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void формаНигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBookForms form = Container.Resolve<FormBookForms>();
            form.ShowDialog();
        }

        private void плагинОтчетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReport>();
            form.ShowDialog();
        }

        private void viberPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormMessenger>();
            form.ShowDialog();
        }
    }
}
