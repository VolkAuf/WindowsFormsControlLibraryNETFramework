﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public string BookName { get; set; }

        public string BookForm { get; set; }

        public string Annotation { get; set; }
    }
}
