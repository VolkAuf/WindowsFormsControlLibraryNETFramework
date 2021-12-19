using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageDatabaseImplement.models
{
    public class BookReader
    {
        public int Id { get; set; }

        public int ReaderId { get; set; }

        public int BookId { get; set; }


        public virtual Book Book { get; set; }

        public virtual Reader Reader { get; set; }
    }
}
