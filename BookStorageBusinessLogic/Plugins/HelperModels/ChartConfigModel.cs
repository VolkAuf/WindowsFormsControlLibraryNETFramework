using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.Plugins.HelperModels
{
    public class ChartConfigModel
    {
        public string ChartName  { get; set; }

        public int[,] ListOfData { get; set; }
    }
}
