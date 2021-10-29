using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppTest.MockClasses;
using WindowsFormsComponentLibrary.HelperModels.Configs;
using WindowsFormsComponentLibrary.HelperModels.Word;
using WindowsFormsComponentLibrary.Enums;

namespace WindowsFormsAppTest
{
    public partial class FormTestLab2 : Form
    {
        private MockLibrary mock = new MockLibrary();
        public FormTestLab2()
        {
            InitializeComponent();
        }

        private void buttonContextTableInvoke_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    componentWordContextTables.CreateContextTables(new ComponentWordContextTablesConfig
                        {
                            WordInfo = new WordInfo
                            {
                                Path = dialog.FileName,
                                Title = "MyPersonalTitel"
                            },
                            Tables = mock.getListTables(Convert.ToInt32(textBoxCountTables.Text), Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text))
                        }
                    );
                }
            }
        }

        private void buttonMultyTableInvoke_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Books book = new Books();
                    componentWordMultyTable.CreateTable<Books>(new ComponentWordTableConfig<Books>
                    {
                        WordInfo = new WordInfo
                        {
                            Path = dialog.FileName,
                            Title = "MyPersonalTitel"
                        },
                        ColumnsWidth = mock.getColumnsWidth(Convert.ToInt32(textBoxWIdthMultyT.Text), 2400),
                        RowsHeight = mock.getRowsHeight(Convert.ToInt32(textBoxHeightMultyT.Text)+1, 1000),
                        Headers = mock.GetHeader(Convert.ToInt32(textBoxCountCellInRow.Text)),
                        PropertiesQueue = mock.GetHeader(Convert.ToInt32(textBoxCountCellInRow.Text)),
                        ListData = mock.GetBooks()
                    }
                    ); ;
                }
            }
        }

        private void buttonDiagramInvoke_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Books book = new Books();
                    componentWordDiagram.createDiagram<Books>(new ComponentWordDiagramConfig<Books>
                    {
                        WordInfo = new WordInfo
                        {
                            Path = dialog.FileName,
                            Title = "MyPersonalTitel"
                        },
                        DiagramTitle = "MyPersonalDiagramTitel",
                        LegendLocation = LegendLocations.Corner,
                        ListData = mock.GetBooks(),
                        PropertyX = "Rating",
                        PropertyY = "Name"
                    }
                    );
                }
            }
        }
    }
}
