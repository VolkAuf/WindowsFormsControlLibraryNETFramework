using BookStorageBusinessLogic.BindingModels;
using BookStorageBusinessLogic.BusinessLogics;
using BookStorageDatabaseImplement.Implements;
using BookStorageDatabaseImplement.models;
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
    public partial class FormBookForms : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly BookFormBusinessLogic _logic;

        public FormBookForms(BookFormBusinessLogic logic)
        {
            _logic = logic;
            InitializeComponent();
        }

        private void FormBookForms_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _logic.Read(null);
                if (list == null) return;
                dataGridView.DataSource = list;
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var typeName = dataGridView[e.ColumnIndex, e.RowIndex].Value as string;
            if (!string.IsNullOrEmpty(typeName))
            {
                BeginInvoke(new MethodInvoker(() =>
                {
                    try
                    {
                        var id = (int)dataGridView[0, e.RowIndex].Value;
                        _logic.CreateOrUpdate(new BookFormBindingModel { Id = id, BookForm = typeName });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadData();
                }));
            }
            else
            {
                MessageBox.Show("Введена пустая строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void dataGridViewManagers_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    {
                        int i = 0;
                        string name = "Новая форма";
                        try
                        {
                            _logic.CreateOrUpdate(new BookFormBindingModel { BookForm = name });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        LoadData();
                        break;
                    }
                case Keys.Delete:
                    {
                        if (dataGridView.SelectedRows.Count == 1)
                        {
                            if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                                try
                                {
                                    _logic.Delete(new BookFormBindingModel { Id = id });
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                LoadData();
                            }
                        }

                        break;
                    }
            }
        }
    }
}
