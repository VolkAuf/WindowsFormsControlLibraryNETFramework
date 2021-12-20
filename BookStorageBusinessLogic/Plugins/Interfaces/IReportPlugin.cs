﻿using BookStorageBusinessLogic.Plugins.HelperModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.Plugins.Interfaces
{
    public interface IReportPlugin
    {
        string PluginType { get; }
        void CreateDocument();
        void SaveDocument(string filepath);
        void AddParagraph(ParagraphConfigModel config);
        void AddImage(ImageConfigModel config);
        void AddTable(TableConfigModel config);
        void AddChart(ChartConfigModel config);
    }
}
