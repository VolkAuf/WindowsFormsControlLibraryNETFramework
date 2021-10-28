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
    public partial class ComponentWordDiagram : Component
    {
        public ComponentWordDiagram()
        {
            InitializeComponent();
        }

        public ComponentWordDiagram(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void createDiagram<T>(ComponentWordDiagramConfig<T> config)
        {
            if( config.DataList == null)
            {
                throw new Exception("Not found data list");
            }
            CreateWordFile.CreateDiagram<T>(config);
        }
    }
}
