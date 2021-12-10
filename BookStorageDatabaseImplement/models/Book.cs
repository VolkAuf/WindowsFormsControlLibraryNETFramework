using BookStorageBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStorageDatabaseImplement.models
{
    public class Book
    {
        public int Id { get; set; }

        public string BookName { get; set; }

        public BookForm BookForm { get; set; }

        public string Annotation { get; set; }



        [ForeignKey("BookId")]
        public virtual List<BookReader> BookReaders { get; set; }
    }
}
