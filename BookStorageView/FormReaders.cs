using BookStorageBusinessLogic.BindingModels;
using BookStorageBusinessLogic.BusinessLogics;
using BookStorageBusinessLogic.ViewModels;
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
    public partial class FormReaders : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int BookId { get => Convert.ToInt32(listBox.SelectedValue); set => listBox.SelectedValue = value; }
        public string BookName => listBox.Text;


        private readonly BookBusinessLogic _bookLogic;
        private readonly ReaderBusinessLogic _readerLogic;

        public FormReaders()
        {
            InitializeComponent();
        }

        public FormReaders(ReaderBusinessLogic readerBusinessLogic, BookBusinessLogic bookLogic)
        {
            InitializeComponent();
            _readerLogic = readerBusinessLogic;
            _bookLogic = bookLogic;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                _readerLogic.CreateOrUpdate(new ReaderBindingModel
                {
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Patronymic = textBoxPatronymic.Text,
                    Books = new List<int> { BookId }
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadListBox()
        {

            listBox.DisplayMember = "BookName";
            listBox.ValueMember = "Id";
            listBox.DataSource = _bookLogic.Read(null);
        }

        private void FormReaders_Load(object sender, EventArgs e)
        {
            LoadListBox();

            try
            {
                ReaderViewModel view = _readerLogic.Read(new ReaderBindingModel { Id = BookId })?[0];
                if (view != null)
                {
                    listBox.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
