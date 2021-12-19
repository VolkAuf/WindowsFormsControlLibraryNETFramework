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
    public class BookFormStorage : IBookFormStorage
    {
        public List<BookFormViewModel> GetFullList()
        {
            using (var context = new LibraryDatabase())
            {
                return context.BookForms
                .ToList()
                .Select(rec => new BookFormViewModel
                {
                    Id = rec.Id,
                    BookForm = rec.Form
                })
                .ToList();
            }
        }
        public List<BookFormViewModel> GetFilteredList(BookFormBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new LibraryDatabase())
            {
                return context.BookForms
                .Where(rec => rec.Form.Contains(model.BookForm))
                .ToList()
                .Select(rec => new BookFormViewModel
                {
                    Id = rec.Id,
                    BookForm = rec.Form
                })
                .ToList();
            }
        }
        public BookFormViewModel GetElement(BookFormBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new LibraryDatabase())
            {
                var bookForm = context.BookForms
                .FirstOrDefault(rec => rec.Form == model.BookForm || rec.Id == model.Id);
                return bookForm != null ?
                    new BookFormViewModel
                    {
                        Id = bookForm.Id,
                        BookForm = bookForm.Form
                    } :
                    null;
            }
        }
        public void Insert(BookFormBindingModel model)
        {
            using (var context = new LibraryDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        BookForm bookForm = new BookForm
                        {
                            Form = model.BookForm
                        };
                        context.BookForms.Add(bookForm);
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
        public void Update(BookFormBindingModel model)
        {
            using (var context = new LibraryDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.BookForms.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        
                        element.Form = model.BookForm;
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
        public void Delete(BookFormBindingModel model)
        {
            using (var context = new LibraryDatabase())
            {
                BookForm element = context.BookForms.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.BookForms.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
    }
}
