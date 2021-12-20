using System;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using BookStorageBusinessLogic.Plugins.Interfaces;
using BookStorageBusinessLogic.Plugins.HelperModels;

namespace DockPluginReport
{
    public class ReportBuilder : IReportPlugin
    {
        /// <summary>
        /// Приложения Word
        /// </summary>
        Word.Application application;

        /// <summary>
        /// Документ Word
        /// </summary>
        Word.Document document;

        public string PluginType => "Report";

        /// <summary>
        /// Создать документ
        /// </summary>
        public void CreateDocument()
        {
            application = new Word.Application();
            application.Visible = true;
            document = application.Documents.Add(Visible: true);
        }

        /// <summary>
        /// Сохранить доумент
        /// </summary>
        /// <param name="filepath"> Путь сохранения </param>
        public void SaveDocument(string filepath)
        {
            //Сохраняем документ
            document.SaveAs(filepath);
            document.Close();
            application.Quit();
        }

        /// <summary>
        /// Добавить параграф к документу
        /// </summary>
        /// <param name="config"> Модель параграфа </param>
        public void AddParagraph(ParagraphConfigModel config)
        {
            var pText = document.Paragraphs.Add();
            pText.Format.SpaceAfter = 10f;
            pText.Range.Text = config.Text;
            pText.Range.InsertParagraphAfter();
        }

        /// <summary>
        /// Добавить параграф к документу
        /// </summary>
        /// <param name="text"> Текст параграфа </param>
        /// <returns> Параграф </returns>
        public Word.Paragraph AddParagraph(String text)
        {
            var pText = document.Paragraphs.Add();
            pText.Format.SpaceAfter = 10f;
            pText.Range.Text = text;
            pText.Range.InsertParagraphAfter();

            return pText;
        }

        /// <summary>
        /// Добавить таблицу к документу
        /// </summary>
        /// <param name="config"> Модель таблицы </param>
        public void AddTable(TableConfigModel config)
        {
            var paragraph = AddParagraph("");

            Word.Table table = document.Tables.Add(paragraph.Range, config.Table.GetLength(0), config.Table.GetLength(1));
            table.Borders.Enable = 1;
            table.Borders.OutsideLineWidth = Word.WdLineWidth.wdLineWidth300pt;
            table.Range.Bold = 1;
            table.Range.Font.Name = "verdana";
            table.Range.Font.Size = 10;
            table.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            //Номера строк и клонок в Word начинаются с 1
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                // Сдвиг в колонке идет из-за шапки
                for (int column = 1; column <= table.Columns.Count; column++)
                {
                    table.Cell(row, column).Range.Text = config.Table[row - 1, column - 1];
                    table.Cell(row, column).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                }
            }

            AddParagraph("");
        }

        /// <summary>
        /// Добавить картинку к документу
        /// </summary>
        /// <param name="config"> Модель картинки </param>
        public void AddImage(ImageConfigModel config)
        {
            AddParagraph("");

            var pPicture = document.Paragraphs.Add();
            pPicture.Format.SpaceAfter = 10f;
            document.InlineShapes.AddPicture(config.Path, Range: pPicture.Range);

            AddParagraph("");
        }

        /// <summary>
        /// Добавить график к документу
        /// </summary>
        /// <param name="config"> Модель графика </param>
        public void AddChart(ChartConfigModel config)
        {
            AddParagraph("");

            var pChart = document.Paragraphs.Add();
            pChart.Format.SpaceAfter = 10f;

            //Создаем график. Тип графика - гистограмма. Значение ChartStyle от 1 до 46.
            Word.Chart chart = document.InlineShapes.AddChart2(2, Microsoft.Office.Core.XlChartType.xlColumnClustered, Range: pChart.Range).Chart;

            //Данные для графика
            Word.ChartData chartData = chart.ChartData;

            //Данные для графика в Excel книге
            Excel.Workbook workbook = (Excel.Workbook)chartData.Workbook;
            Excel.Worksheet dataSheet = (Excel.Worksheet)workbook.Worksheets[1];

            //Получаем номер колонки в Excel формате
            int columnNumber = config.ListOfData.GetLength(0) + 1;
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

            for (int data = 0; data < config.ListOfData.GetLength(0); data++)
            {
                //Первая серия начинается со второй строки и нумерация в таблице идет с 1
                //(По этому data + 2)
                dataSheet.Cells[1, data + 2].Value = config.ListOfData[data, 0];

                //Первая серия начинается со второй строки и нумерация в таблице идет с 1
                //(По этому data + 2)
                dataSheet.Cells[2, data + 2].Value = config.ListOfData[data, 1];
            }

            //Чтобы не было подписи "Коллекция 1" под диаграммой
            dataSheet.Cells[2, 1].Value = "";

            //Название диаграммы
            chart.HasTitle = true;
            chart.ChartTitle.Font.Color = Color.FromArgb(255, 255, 255).ToArgb();
            chart.ChartTitle.Font.Italic = true;
            chart.ChartTitle.Font.Size = 18;
            chart.ChartTitle.Text = config.ChartName;

            //Закрываем Excel
            workbook.Application.Quit();

            AddParagraph("");
        }
    }
}
