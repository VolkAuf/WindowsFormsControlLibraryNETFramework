﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsComponentLibrary.HelperModels;

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
            if (string.IsNullOrEmpty(config.WordInfo.Path))
            {
                throw new ArgumentNullException();
            }
            if (string.IsNullOrEmpty(config.WordInfo.Title))
            {
                throw new ArgumentNullException();
            }

            CreateWordFile.CreateWordContextTables(config);
        }
    }
}
