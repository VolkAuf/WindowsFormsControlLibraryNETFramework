using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.ViewModels
{
    public class BookReportViewModel
    {
        public int Id { get; set; }

        public string BookName { get; set; }

        public string BookForm { get; set; }

        public string Annotation { get; set; }

        public Dictionary<int, string> Readers { get; set; }
    }
}
