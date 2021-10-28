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
                                Title = dialog.Title
                            },
                            Tables = mock.getListTables(Convert.ToInt32(textBoxCountTables), Convert.ToInt32(textBoxWidth), Convert.ToInt32(textBoxHeight))
                        }
                    );
                }
            }
        }
    }
}
