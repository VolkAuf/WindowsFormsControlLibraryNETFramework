using BookStorageBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.BindingModels
{
    public class BookBindingModel
    {
        public int? Id { get; set; }

        public string BookName { get; set; }

        public BookForm BookForm { get; set; }

        public string Annotation { get; set; }

        public List<int> BookReaders { get; set; }
    }
}
