using BookStorageBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public string BookName { get; set; }

        public BookForm BookForm { get; set; }

        public string Annotation { get; set; }

        public Dictionary<int, string> Readers { get; set; }
    }
}
