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
    public partial class ComponentWordContextTables : Component
    {
        public ComponentWordContextTables()
        {
            InitializeComponent();
        }

        public ComponentWordContextTables(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateContextTables(ComponentWordContextTablesConfig config)
        {
            if (string.IsNullOrEmpty(config.WordInfo.Path) || string.IsNullOrEmpty(config.WordInfo.Title))
            {
                throw new Exception("Not found path or titel");
            }
            if (config.Tables == null)
            {
                throw new Exception("Not found data");
            }

            CreateWordFile.CreateWordContextTables(config);
        }
    }
}
