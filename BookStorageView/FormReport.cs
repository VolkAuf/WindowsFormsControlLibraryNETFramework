using BookStorageBusinessLogic.BusinessLogics;
using BookStorageBusinessLogic.Plugins.HelperModels;
using BookStorageBusinessLogic.Plugins.Interfaces;
using BookStorageBusinessLogic.Plugins.Managers;
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

namespace BookStorageView
{
    public partial class FormReport : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private IReportPlugin _reporter;
        private PluginReportManager _manager;
        private readonly BookBusinessLogic _bookLogic;

        public FormReport(PluginReportManager manager, BookBusinessLogic bookBusinessLogic)
        {
            _manager = manager;
            _bookLogic = bookBusinessLogic;
            InitializeComponent();
        }

        private void FormReportPlugin_Load(object sender, EventArgs e)
        {
            if (_manager.Headers is null || _manager.Headers.Count.Equals(0)) return;
            comboBoxPlugins.Items.AddRange(_manager.Headers.ToArray());
            comboBoxPlugins.Text = comboBoxPlugins.Items[0].ToString();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            _reporter = _manager.plugins[comboBoxPlugins.Text];
            if (_reporter != null)
            {
                _reporter.CreateDocument();
            
                var books = _bookLogic.Read(null);

                string report = "";

                foreach (var book in books)
                {
                    report += book.BookName + " " + book.BookForm + ". ";
                }

                _reporter.AddParagraph(new ParagraphConfigModel { Text = report });
            
                _reporter.AddImage(new ImageConfigModel { Path = "C:\\Users\\Rafael\\Pictures\\desktopFon10.jpg" });

                string[,] array = new string[books.Count + 1, 2];
                array[0, 0] = "Название Книги";
                array[0, 1] = "Форма книги";

                for (int i = 0; i < books.Count; i++)
                {
                    array[i + 1, 0] = books[i].BookName;
                    array[i + 1, 1] = books[i].BookForm;
                }

                _reporter.AddTable(new TableConfigModel { Table = array });

                
                var book_groups = from book in books
                                  group book by book.BookName into g
                                  select new { Name = g.Key, Count = g.Count() };


                _reporter.AddChart(new ChartConfigModel { ChartName = "Книги", ListOfData = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } } });

                using (var d = new SaveFileDialog() { Filter = "docx|*.docx" })
                {
                    if (d.ShowDialog() == DialogResult.OK)
                    {
                        _reporter.SaveDocument(d.FileName);
                        MessageBox.Show("Документ Word с таблицами создан");
                    }
                }

            }
        }
    }
}
