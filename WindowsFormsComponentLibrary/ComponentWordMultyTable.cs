using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsComponentLibrary.HelperModels.Configs;

namespace WindowsFormsComponentLibrary
{
    public partial class ComponentWordMultyTable : Component
    {
        public ComponentWordMultyTable()
        {
            InitializeComponent();
        }

        public ComponentWordMultyTable(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void CreateTable<T>(ComponentWordTableConfig<T> config)
        {
            if (string.IsNullOrEmpty(config.WordInfo.Path) || string.IsNullOrEmpty(config.WordInfo.Title))
            {
                throw new Exception("Empty path or titel");
            }
            if (config.Headers == null || config.Headers.Count == 0)
            {
                throw new Exception("Not found table heder");
            }
            if (config.PropertiesQueue == null || config.PropertiesQueue.Count == 0)
            {
                throw new Exception("Not found property queue");
            }
            if (config.ColumnsWidth == null || config.ColumnsWidth.Count == 0)
            {
                throw new Exception("Not found columns width");
            }
            if (config.RowsHeight == null || config.RowsHeight.Count == 0)
            {
                throw new Exception("Not found rows height");
            }
            if (config.ListData == null || config.ListData.Count == 0)
            {
                throw new Exception("Not found list data");
            }
            if (config.PropertiesQueue.Count != config.ColumnsWidth.Count ||
                config.ColumnsWidth.Count != config.Headers.Count ||
                config.RowsHeight.Count != config.ListData.Count)
            {
                throw new Exception("Invalid all property! Data inconsistent");
            }

            CreateWordFile.CreateWordTable(config);
        }
    }
}
