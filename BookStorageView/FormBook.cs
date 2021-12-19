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
    public partial class FormBook : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set => id = value; }
        private int? id;

        private readonly BookBusinessLogic _bookLogic;
        private readonly BookFormBusinessLogic _bookFormLogic;

        public FormBook()
        {
            InitializeComponent();
        }

        public FormBook(BookBusinessLogic bookBusinessLogic, BookFormBusinessLogic bookFormBusinessLogic)
        {
            InitializeComponent();
            _bookLogic = bookBusinessLogic;
            inputUserControl.minLength = 100;
            inputUserControl.maxLength = 200;
            _bookFormLogic = bookFormBusinessLogic;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _bookLogic.CreateOrUpdate(new BookBindingModel
                {
                    Id = id,
                    BookName = textBoxName.Text,
                    BookForm = userControlListBox.SelectedElement,
                    Annotation = inputUserControl.InputText,
                    BookReaders = new List<int>()

                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userControlListBox1_Load(object sender, EventArgs e)
        {
            LoadListBox();
        }

        private void LoadListBox()
        {
            userControlListBox.Clear();
            foreach (var bookForm in _bookFormLogic.Read(null))
            { 
                userControlListBox.AddElement(bookForm.BookForm);
            }
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    BookViewModel view = _bookLogic.Read(new BookBindingModel { Id = id.Value })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.BookName;
                        userControlListBox.SelectedElement = view.BookForm;
                        inputUserControl.InputText = view.Annotation;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
