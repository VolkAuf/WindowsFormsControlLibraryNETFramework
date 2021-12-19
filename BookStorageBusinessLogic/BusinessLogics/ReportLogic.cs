using BookStorageBusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStorageBusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private IBookStorage _bookStorage;
        private IReaderStorage _readerStorage;
        private IBookFormStorage _bookFormStorage;

        public ReportLogic(IBookStorage bookStorage, IReaderStorage readerStorage, IBookFormStorage bookFormStorage)
        {
            _bookStorage = bookStorage;
            _readerStorage = readerStorage;
            _bookFormStorage = bookFormStorage;
        }

        public List<string[,]> GetStringBookTables()
        {
            List<string[,]> tables = new List<string[,]>();
            var listBook = _bookStorage.GetFullListReport();
            var listReader = _readerStorage.GetFullList();

            foreach(var itemBook in listBook)
            {
                string[,] row = new string[1, itemBook.Readers.Count + 1];
                row[0, 0] = itemBook.BookName;
                int i = 1;
                foreach(var itemReader in itemBook.Readers)
                {
                    row[0, i] = itemReader.Value;
                    i++;
                    if (i >= 6)
                        break;
                }
                tables.Add(row);
            }
            return tables;
        }

        public double[] GetCountForm(string bookForm)
        {
            var bookList = _bookStorage.GetFullList();
            var list = new double[5];
            int j = 0;
            for (int i = 100; i < 180; i += 20)
            {
                list[j] = bookList
                    .Where(rec => rec.Annotation.Length >= i && rec.Annotation.Length < i + 20 && rec.BookForm == bookForm.ToString())
                    .Count();
                j++;
            }
            return list;
        }
    }
}
