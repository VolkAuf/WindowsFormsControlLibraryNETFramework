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
    public class ReaderStorage : IReaderStorage
    {
        public void Delete(ReaderBindingModel model)
        {
            using (var context = new LibraryDatabase())
            {
                Reader element = context.Readers.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Readers.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public ReaderViewModel GetElement(ReaderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new LibraryDatabase())
            {
                var reader = context.Readers
                .FirstOrDefault(rec => rec.LastName == model.LastName || rec.Id == model.Id);
                return reader != null ?
                    new ReaderViewModel
                    {
                        Id = reader.Id,
                        FirstName = reader.FirstName,
                        LastName = reader.LastName,
                        Patronymic = reader.Patronymic
                    } :
                    null;
            }
        }

        public List<ReaderViewModel> GetFilteredList(ReaderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new LibraryDatabase())
            {
                return context.Readers
               .Where(rec => rec.FirstName.Contains(model.FirstName))
               .ToList()
               .Select(rec => new ReaderViewModel
               {
                   Id = rec.Id,
                   FirstName = rec.FirstName,
                   LastName = rec.LastName,
                   Patronymic = rec.Patronymic
               })
               .ToList();
            }
        }

        public List<ReaderViewModel> GetFullList()
        {
            using (var context = new LibraryDatabase())
            {
                return context.Readers
                .ToList()
                .Select(rec => new ReaderViewModel
                {
                    Id = rec.Id,
                    FirstName = rec.FirstName,
                    LastName = rec.LastName,
                    Patronymic = rec.Patronymic
                })
                .ToList();
            }
        }

        public void Insert(ReaderBindingModel model)
        {
            using (var context = new LibraryDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        
                        Reader reader = new Reader
                        {
                            FirstName = model.FirstName,
                            LastName = model.LastName,
                            Patronymic = model.Patronymic
                        };
                        context.Readers.Add(reader);
                        context.SaveChanges(); 
                        
                        foreach (var book in model.Books)
                        {
                            var bookReader = new BookReader
                            {
                                BookId = book,
                                ReaderId = reader.Id
                            };
                            context.BookReaders.Add(bookReader);
                            context.SaveChanges();
                        }
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

        public void Update(ReaderBindingModel model)
        {
            using (var context = new LibraryDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Readers.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        element.FirstName = model.FirstName;
                        element.LastName = model.LastName;
                        element.Patronymic = model.Patronymic;
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

        private Reader CreateModel(ReaderBindingModel model, Reader furniture, LibraryDatabase context)
        {
            if (model.Id.HasValue)
            {
                var furnitureComponents = context.BookReaders.Where(rec => rec.ReaderId == model.Id.Value).ToList();
                // удалили те, которых нет в модели
                context.BookReaders.RemoveRange(furnitureComponents.Where(rec => !model.Books.Contains(rec.BookId)).ToList());
                context.SaveChanges();
                // обновили количество у существующих записей
                foreach (var updateComponent in furnitureComponents)
                {
                    model.Books.Remove(updateComponent.BookId);
                }
                context.SaveChanges();
            }
            // добавили новые
            foreach (var fc in model.Books)
            {
                context.BookReaders.Add(new BookReader
                {
                    ReaderId = furniture.Id,
                    BookId = fc
                });
                context.SaveChanges();
            }
            return furniture;
        }
    }
}
