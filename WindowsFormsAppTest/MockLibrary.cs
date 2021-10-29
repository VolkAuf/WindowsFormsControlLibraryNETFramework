using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppTest.MockClasses;

namespace WindowsFormsAppTest
{
    public class MockLibrary
    {
        public List<Books> books = new List<Books>();

        public List<string[,]> getListTables(int count, int width, int height)
        {
            List<string[,]> list = new List<string[,]>();

            for (int i = 0; i < count; i++)
            {
                list.Add(getStringTables(width, height));
            }
            return list;
        }

        private string[,] getStringTables(int width, int height)
        {

            string[,] tables = new string[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    tables[i, j] = books[i % 8].Name + " " + i + "" + j;
                }
            }
            return tables;
        }

        public List<int> getColumnsWidth(int count, int width)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < count; i++)
            {
                list.Add(width);
            }
            return list;
        }

        public List<int> getRowsHeight(int count, int height)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < count; i++)
            {
                list.Add(height);
            }
            return list;
        }

        public List<string> GetHeader(int count)
        {
            List<string> list = new List<string>();
            if (count > 0 && count < 10)
            switch ((count % 10))
            {
                case 9:
                    list.Add("ID");
                    goto case 8;
                case 8:
                    list.Add("Name");
                    goto case 7;
                case 7:
                    list.Add("Author");
                    goto case 6;
                case 6:
                    list.Add("CountInWarehouse");
                    goto case 5;
                case 5:
                    list.Add("Price");
                    goto case 4;
                case 4:
                    list.Add("CountPaper");
                    goto case 3;
                case 3:
                    list.Add("Year");
                    goto case 2;
                case 2:
                    list.Add("Rating");
                    goto case 1;
                case 1:
                    list.Add("Publisher");
                    break;
                default:
                    break;
            }
            return list;
        }
        
        public List<Books> GetBooks()
        {
            return books;
        }

        public MockLibrary()
        {
            books.Add(new Books
            {
                ID = 1,
                Name = "Book1",
                Author = "Author1",
                CountInWarehouse = 1,
                CountPaper = 10,
                Price = 100,
                Publisher = "Publisher1",
                Rating = 1,
                Year = 2001
            }
            );
            books.Add(new Books
            {
                ID = 2,
                Name = "Book2",
                Author = "Author2",
                CountInWarehouse = 2,
                CountPaper = 20,
                Price = 200,
                Publisher = "Publisher2",
                Rating = 2,
                Year = 2002
            }
            ); books.Add(new Books
            {
                ID = 3,
                Name = "Book3",
                Author = "Author3",
                CountInWarehouse = 3,
                CountPaper = 30,
                Price = 300,
                Publisher = "Publisher3",
                Rating = 3,
                Year = 2003
            }
             ); books.Add(new Books
             {
                 ID = 4,
                 Name = "Book4",
                 Author = "Author4",
                 CountInWarehouse = 4,
                 CountPaper = 40,
                 Price = 400,
                 Publisher = "Publisher4",
                 Rating = 4,
                 Year = 2004
             }
             ); books.Add(new Books
             {
                 ID = 5,
                 Name = "Book5",
                 Author = "Author5",
                 CountInWarehouse = 5,
                 CountPaper = 50,
                 Price = 500,
                 Publisher = "Publisher5",
                 Rating = 5,
                 Year = 2005
             }
             ); books.Add(new Books
             {
                 ID = 6,
                 Name = "Book6",
                 Author = "Author6",
                 CountInWarehouse = 6,
                 CountPaper = 60,
                 Price = 600,
                 Publisher = "Publisher6",
                 Rating = 4,
                 Year = 2006
             }
             ); books.Add(new Books
             {
                 ID = 7,
                 Name = "Book7",
                 Author = "Author7",
                 CountInWarehouse = 7,
                 CountPaper = 70,
                 Price = 700,
                 Publisher = "Publisher7",
                 Rating = 3,
                 Year = 2007
             }
             ); books.Add(new Books
             {
                 ID = 8,
                 Name = "Book8",
                 Author = "Author8",
                 CountInWarehouse = 8,
                 CountPaper = 80,
                 Price = 800,
                 Publisher = "Publisher8",
                 Rating = 2,
                 Year = 2008
             }
             );
        }
    }
}
