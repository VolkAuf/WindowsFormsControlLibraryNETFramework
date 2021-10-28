using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsComponentLibrary.Enums;
using WindowsFormsComponentLibrary.HelperModels.Word;

namespace WindowsFormsComponentLibrary.HelperModels.Configs
{
    public class ComponentWordDiagramConfig<T>
    {
        public WordInfo WordInfo { get; set; }

        public string DiagramTitle { get; set; }

        public LegendLocations LegendLocation { get; set; }

        public string PropertyY { get; set; }

        public string PropertyX { get; set; }

        public List<T> DataList { get; set; } 
    }
}
