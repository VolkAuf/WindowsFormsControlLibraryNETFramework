using BookStorageBusinessLogic.BindingModels;
using BookStorageBusinessLogic.Interfaces;
using BookStorageBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.BusinessLogics
{
    public class BookFormBusinessLogic
    {
        private readonly IBookFormStorage _bookFormStorage;
        public BookFormBusinessLogic(IBookFormStorage bookFormStorage)
        {
            _bookFormStorage = bookFormStorage;
        }
        public List<BookFormViewModel> Read(BookFormBindingModel model)
        {
            if (model == null)
            {
                return _bookFormStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<BookFormViewModel> { _bookFormStorage.GetElement(model) };
            }
            return _bookFormStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(BookFormBindingModel model)
        {
            var element = _bookFormStorage.GetElement(new BookFormBindingModel { BookForm = model.BookForm });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть книга с таким названием");
            }
            if (model.Id.HasValue)
            {
                _bookFormStorage.Update(model);
            }
            else
            {
                _bookFormStorage.Insert(model);
            }
        }
        public void Delete(BookFormBindingModel model)
        {
            BookFormViewModel element = _bookFormStorage.GetElement(new BookFormBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _bookFormStorage.Delete(model);
        }
    }
}
