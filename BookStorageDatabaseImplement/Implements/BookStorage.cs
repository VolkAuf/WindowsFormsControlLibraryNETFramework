using BookStorageBusinessLogic.BindingModels;
using BookStorageBusinessLogic.Interfaces;
using BookStorageBusinessLogic.ViewModels;
using BookStorageDatabaseImplement.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStorageDatabaseImplement.Implements
{
    public class BookStorage : IBookStorage
    {
        public List<BookViewModel> GetFullList()
        {
            using (var context = new LibraryDatabase())
            {
                return context.Books
                .Include(rec => rec.BookReaders)
                .ThenInclude(rec => rec.Reader)
                .ToList()
                .Select(rec => new BookViewModel
                {
                    Id = rec.Id,
                    BookName = rec.BookName,
                    BookForm = rec.BookForm,
                    Annotation = rec.Annotation
                })
                .ToList();
            }
        }
        public List<BookViewModel> GetFilteredList(BookBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new LibraryDatabase())
            {
                return context.Books
                .Include(rec => rec.BookReaders)
                .ThenInclude(rec => rec.Reader)
                .Where(rec => rec.BookName.Contains(model.BookName))
                .ToList()
                .Select(rec => new BookViewModel
                {
                    Id = rec.Id,
                    BookName = rec.BookName,
                    BookForm = rec.BookForm,
                    Annotation = rec.Annotation
                })
                .ToList();
            }
        }
        public BookViewModel GetElement(BookBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new LibraryDatabase())
            {
                var book = context.Books
                .Include(rec => rec.BookReaders)
                .ThenInclude(rec => rec.Reader)
                .FirstOrDefault(rec => rec.BookName == model.BookName || rec.Id == model.Id);
                return book != null ?
                    new BookViewModel
                    {
                        Id = book.Id,
                        BookName = book.BookName,
                        BookForm = book.BookForm,
                        Annotation = book.Annotation
                    } :
                    null;
            }
        }
        public void Insert(BookBindingModel model)
        {
            using (var context = new LibraryDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Book book = new Book
                        {
                            BookName = model.BookName,
                            BookForm = model.BookForm,
                            Annotation = model.Annotation
                        };
                        context.Books.Add(book);
                        context.SaveChanges();
                        CreateModel(model, book, context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Update(BookBindingModel model)
        {
            using (var context = new LibraryDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Books.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        element.BookName = model.BookName;
                        element.BookForm = model.BookForm;
                        element.Annotation = model.Annotation;
                        CreateModel(model, element, context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Delete(BookBindingModel model)
        {
            using (var context = new LibraryDatabase())
            {
                Book element = context.Books.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Books.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        private Book CreateModel(BookBindingModel model, Book book, LibraryDatabase context)
        {
            foreach (var br in model.BookReaders)
            {
                context.BookReaders.Add(new BookReader
                {
                    BookId = book.Id,
                    ReaderId = br
                });
                context.SaveChanges();
            }
            return book;
        }

        public List<BookReportViewModel> GetFullListReport()
        {
            using (var context = new LibraryDatabase())
            {
                return context.Books
                .Include(rec => rec.BookReaders)
                .ThenInclude(rec => rec.Reader)
                .ToList()
                .Select(rec => new BookReportViewModel
                {
                    Id = rec.Id,
                    BookName = rec.BookName,
                    BookForm = rec.BookForm,
                    Annotation = rec.Annotation,
                    Readers = rec.BookReaders
                .ToDictionary(recBR => recBR.ReaderId, recPC => (recPC.Reader?.FirstName + " " + recPC.Reader?.LastName + " " + recPC.Reader?.Patronymic))
                })
                .ToList();
            }
        }
    }
}
