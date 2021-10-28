using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Reflection;
using WindowsFormsComponentLibrary.HelperModels.Word;
using System.Drawing;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using WindowsFormsComponentLibrary.HelperModels.Configs;

namespace WindowsFormsComponentLibrary
{
    static class CreateWordFile
    {
        public static void CreateWordContextTables(ComponentWordContextTablesConfig config)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument
            .Create(config.WordInfo.Path, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body docBody = mainPart.Document.AppendChild(new Body());

                docBody.AppendChild(CreateParagraph(new WordParagraph
                {
                    Texts = new List<(string, WordParagraphProperties)> { (config.WordInfo.Title,
                        new WordParagraphProperties {Bold = true, Size = "24", } ) },
                    ParagraphProperties = new WordParagraphProperties
                    {
                        Size = "24",
                        JustificationValues = JustificationValues.Center
                    }
                }));

                foreach (string[,] tables in config.Tables)
                {
                    Table table = new Table();
                    TableProperties tblProp = new TableProperties(
                        new TableBorders(
                            new TopBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Single),
                                Size = 12
                            },
                            new BottomBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Single),
                                Size = 12
                            },
                            new LeftBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Single),
                                Size = 12
                            },
                            new RightBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Single),
                                Size = 12
                            },
                            new InsideHorizontalBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Single),
                                Size = 12
                            },
                            new InsideVerticalBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Single),
                                Size = 12
                            }
                        )
                    );
                    table.AppendChild(tblProp);

                    for (int i = 0; i < tables.GetLength(0); i++)
                    {
                        TableRow tableRow = new TableRow();

                        for (int j = 0; j < tables.GetLength(1); j++)
                        {
                            TableCell rowCell = new TableCell();
                            rowCell.Append(new TableCellProperties(
                            new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" }));
                            rowCell.Append(new Paragraph(new Run(new Text(tables[i, j]))));

                            tableRow.Append(rowCell);
                        }
                        table.Append(tableRow);
                    }
                    docBody.Append(table);
                    docBody.Append(new Paragraph());
                }
                wordDocument.MainDocumentPart.Document.Save();
            }
        }

        public static void CreateWordTable<T>(ComponentWordTableConfig<T> config)
        {

            using (WordprocessingDocument wordDocument = WordprocessingDocument
             .Create(config.WordInfo.Path, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body docBody = mainPart.Document.AppendChild(new Body());

                // Добавляем тайтл

                docBody.AppendChild(CreateParagraph(new WordParagraph
                {
                    Texts = new List<(string, WordParagraphProperties)> { (config.WordInfo.Title, new
                        WordParagraphProperties {Bold = true, Size = "24", } ) },
                    ParagraphProperties = new WordParagraphProperties
                    {
                        Size = "24",
                        JustificationValues = JustificationValues.Center
                    }
                }));

                // Создаём таблицу

                Table table = new Table();

                // Добавляем бордеры

                TableProperties tblProp = new TableProperties(
                    new TableBorders(
                        new TopBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 14
                        },
                        new BottomBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 14
                        },
                        new LeftBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 14
                        },
                        new RightBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 14
                        },
                        new InsideHorizontalBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 10
                        },
                        new InsideVerticalBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 12
                        }
                    )
                );

                table.AppendChild(tblProp);

                // Создаём строку-шапку

                TableRow tableRowHeader = new TableRow();
                tableRowHeader.Append(
                    new TableRowProperties(
                        new TableRowHeight() { Val = Convert.ToUInt32(config.RowsHeight[0])}
                    )
                );

                for (int i = 0; i < config.Headers.Count; i++)
                {
                    TableCell cellHeader = new TableCell();
                    cellHeader.Append(new TableCellProperties(
                        new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = config.ColumnsWidth[i].ToString() },
                        new Bold())
                    );
                    cellHeader.Append(new Paragraph(new Run(new Text(config.Headers[i]))));
                    tableRowHeader.Append(cellHeader);
                }
                table.Append(tableRowHeader);

                // Получаем поля
                var property = new List<PropertyInfo>();
                var type = typeof(T);
                for (int i = 0; i < config.PropertiesQueue.Count; i++)
                {
                    var propInfo = type.GetProperty(config.PropertiesQueue[i]);
                    if (propInfo == null)
                    {
                        throw new Exception("Not found property" + config.PropertiesQueue[i]);
                    }
                    property.Add(propInfo);
                }

                //бегаем по нашим данным, одна итерация = одна строка данных
                for (int i = 0; i < config.ListData.Count; i++)
                {
                    TableRow tableRow = new TableRow();
                    tableRow.Append(new TableRowProperties(
                    new TableRowHeight() { Val = Convert.ToUInt32(config.RowsHeight[i]) })
                    );

                    //бегаем по полям наших данных, одна итерация = одна запись в строке
                    for (int j = 0; j < property.Count; j++)
                    {
                        var text = property[j].GetValue(config.ListData[i]);
                        TableCell tableCell = new TableCell();
                        tableCell.Append(new TableCellProperties(
                            new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = config.ColumnsWidth[j].ToString()}));
                        tableCell.Append(new Paragraph(new Run(new Text(text.ToString()))));
                        tableRow.Append(tableCell);
                    }
                    table.Append(tableRow);
                }

                // Добавляем таблицу в документ
                docBody.AppendChild(table);
                wordDocument.MainDocumentPart.Document.Save();
            }
        }

        public static bool CreateDiagram<T>(ComponentWordDiagramConfig<T> config)
        {
            try
            {
                //Создаем приложение Word
                Word.Application word = new Word.Application();
                word.Visible = true;

                //Создаем документ Word
                Word.Document document = word.Documents.Add();

                //Создаем график. Тип графика - гистограмма. Значение ChartStyle от 1 до 46.
                Word.Chart chart = document.InlineShapes.AddChart2(2, Microsoft.Office.Core.XlChartType.xlColumnClustered).Chart;

                //Данные для графика
                Word.ChartData chartData = chart.ChartData;

                //Данные для графика в Excel книге
                Excel.Workbook workbook = (Excel.Workbook)chartData.Workbook;
                Excel.Worksheet dataSheet = (Excel.Worksheet)workbook.Worksheets[1];

                //Получаем номер колонки в Excel формате
                int columnNumber = config.DataList.Count + 1;
                string columnName = "";
                while (columnNumber > 0)
                {
                    int modulo = (columnNumber - 1) % 26;
                    columnName = Convert.ToChar('A' + modulo) + columnName;
                    columnNumber = (columnNumber - modulo) / 26;
                }

                Excel.Range tableRange = dataSheet.Cells.get_Range("A1", columnName + "2");
                Excel.ListObject table1 = dataSheet.ListObjects["Таблица1"];
                table1.Resize(tableRange);

                for (int dataIndex = 0; dataIndex < config.DataList.Count; dataIndex++)
                {
                    //Первая серия начинается со второй строки и нумерация в таблице идет с 1
                    //(По этому data + 2)
                    dataSheet.Cells[1, dataIndex + 2].Value =
                    config.DataList[dataIndex].GetType().GetProperty(config.PropertyY).GetValue(config.DataList[dataIndex]);

                    //Первая серия начинается со второй строки и нумерация в таблице идет с 1
                    //(По этому data + 2)
                    dataSheet.Cells[2, dataIndex + 2].Value =
                    config.DataList[dataIndex].GetType().GetProperty(config.PropertyX).GetValue(config.DataList[dataIndex]);
                }

                //Чтобы не было подписи "Коллекция 1" под диаграммой
                dataSheet.Cells[2, 1].Value = "";

                //Название диаграммы
                chart.HasTitle = true;
                chart.ChartTitle.Font.Color = System.Drawing.Color.FromArgb(255, 255, 255).ToArgb();
                chart.ChartTitle.Font.Italic = true;
                chart.ChartTitle.Font.Size = 18;
                chart.ChartTitle.Text = config.DiagramTitle;

                //Выбираем позицию для диаграммы
                chart.Legend.Position = (Word.XlLegendPosition)config.LegendLocation;

                //Вставляем название документа
                Word.Paragraph paragraph_header = document.Content.Paragraphs.Add(document.Range(document.Content.Start));
                paragraph_header.Range.Text = config.WordInfo.Title;

                //Настройка названия документа
                paragraph_header.Range.Font.Size = 24;
                paragraph_header.Range.Font.Name = "Century Gothic";
                paragraph_header.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paragraph_header.Space2();

                //Закрываем Excel
                workbook.Application.Quit();

                //Сохраняем документ и закрываем его
                document.SaveAs(config.WordInfo.Path);
                document.Close();
                word.Quit();

                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
        }

        private static Paragraph CreateParagraph(WordParagraph paragraph)
        {
            if (paragraph != null)
            {
                Paragraph docParagraph = new Paragraph();
                docParagraph.AppendChild(CreateParagraphProperties(paragraph.ParagraphProperties));
                foreach ((string, WordParagraphProperties) run in paragraph.Texts)
                {
                    Run docRun = new Run();
                    RunProperties properties = new RunProperties();
                    properties.AppendChild(new FontSize { Val = run.Item2.Size });
                    if (run.Item2.Bold)
                    {
                        properties.AppendChild(new Bold());
                    }
                    docRun.AppendChild(properties);
                    docRun.AppendChild(new Text { Text = run.Item1, Space = SpaceProcessingModeValues.Preserve });
                    docParagraph.AppendChild(docRun);
                }
                return docParagraph;
            }
            return null;
        }

        private static ParagraphProperties CreateParagraphProperties(WordParagraphProperties paragraphProperties)
        {
            if (paragraphProperties != null)
            {
                ParagraphProperties properties = new ParagraphProperties();
                properties.AppendChild(new Justification()
                {
                    Val = paragraphProperties.JustificationValues
                });
                properties.AppendChild(new SpacingBetweenLines
                {
                    LineRule = LineSpacingRuleValues.Auto
                });
                properties.AppendChild(new Indentation());
                ParagraphMarkRunProperties paragraphMarkRunProperties = new ParagraphMarkRunProperties();
                if (!string.IsNullOrEmpty(paragraphProperties.Size))
                {
                    paragraphMarkRunProperties.AppendChild(new FontSize { Val = paragraphProperties.Size });
                }
                properties.AppendChild(paragraphMarkRunProperties);
                return properties;
            }
            return null;
        }
    }
}
