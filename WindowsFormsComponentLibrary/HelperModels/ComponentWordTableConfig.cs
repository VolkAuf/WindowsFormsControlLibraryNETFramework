using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsComponentLibrary.HelperModels.Word;

namespace WindowsFormsComponentLibrary.HelperModels
{
    public class ComponentWordTableConfig<T>
    {
        public WordInfo WordInfo { get; set; }

        public List<int> RowHeight { get; set; }

        public Dictionary<int,string> ColumnWidthAndHeader { get; set; }

        public List<T> ListData { get; set; }
    }
}
