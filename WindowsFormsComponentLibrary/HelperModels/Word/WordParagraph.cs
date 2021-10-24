﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsComponentLibrary.HelperModels.Word
{
    class WordParagraph
    {
        public List<(string, WordParagraphProperties)> Texts { get; set; }
        public WordParagraphProperties ParagraphProperties { get; set; }
    }
}
