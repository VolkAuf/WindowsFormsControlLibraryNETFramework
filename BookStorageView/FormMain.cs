using BookStorageBusinessLogic.BindingModels;
using BookStorageBusinessLogic.BusinessLogics;
using BookStorageBusinessLogic.Enums;
using BookStorageBusinessLogic.ViewModels;
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
using WindowsFormsComponentLibrary.HelperModels.Configs;
using WindowsFormsComponentLibrary.HelperModels.Word;
using static Library_NotVisualComponents.DocumentWithDiagram;

namespace BookStorageView
{
    public partial class FormMain : Form
    {
        private readonly BookBusinessLogic _bookLogic;
        private readonly ReaderBusinessLogic _readerLogic;
        private readonly ReportLogic _reportLogic;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(BookBusinessLogic bookBusinessLogic, ReaderBusinessLogic readerBusinessLogic, ReportLogic reportLogic)
        {
            InitializeComponent();
            _bookLogic = bookBusinessLogic;
            _readerLogic = readerBusinessLogic;
            _reportLogic = reportLogic;
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
                        RowHeight = "3cm"
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
            
            listSeries.Add(new DiagramSeries
            {
                Name = "ПечатнаяБезОбложки",
                Values = _reportLogic.GetCountForm(BookForm.ПечатнаяБезОбложки)
            });
            listSeries.Add(new DiagramSeries
            {
                Name = "ПечатнаяВОбложке",
                Values = _reportLogic.GetCountForm(BookForm.ПечатнаяВОбложке)
            }); 
            listSeries.Add(new DiagramSeries
            {
                Name = "Электронная",
                Values = _reportLogic.GetCountForm(BookForm.Электронная)
            });

            documentWithDiagram.CreateFile(fileName, "Диаграмма xlsx", "Книги по анотациям", listSeries, LegendPosition.Right, 
                _xSeries: new string[] { "100-120", "120-140", "140-160", "160-180", "180-200" });
        }

        private void дианграммаПоФормамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "xlsx file | *.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sfd.FileName))
                {
                    MessageBox.Show("Путь не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CreateExlDiagram(sfd.FileName);
            }
        }
    }
}
