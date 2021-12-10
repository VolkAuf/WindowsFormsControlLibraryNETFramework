using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStorageDatabaseImplement.models
{
    public class Reader
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }


        [ForeignKey("ReaderId")]
        public virtual List<BookReader> BookReaders { get; set; }
    }
}
