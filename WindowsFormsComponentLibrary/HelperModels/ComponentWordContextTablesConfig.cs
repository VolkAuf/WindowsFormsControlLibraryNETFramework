using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsComponentLibrary.HelperModels.Word;

namespace WindowsFormsComponentLibrary.HelperModels
{
    public class ComponentWordContextTablesConfig
    {
        public WordInfo WordInfo { get; set; }

        public List<string[,]> Tables { get; set; }

        public ComponentWordContextTablesConfig() { }
    }
}
