using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsComponentLibrary.HelperModels;

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
            if (string.IsNullOrEmpty(config.WordInfo.Path))
            {
                throw new ArgumentNullException();
            }
            if (string.IsNullOrEmpty(config.WordInfo.Title))
            {
                throw new ArgumentNullException();
            }

            CreateWordFile.CreateWordTable(config);
        }
    }
}
