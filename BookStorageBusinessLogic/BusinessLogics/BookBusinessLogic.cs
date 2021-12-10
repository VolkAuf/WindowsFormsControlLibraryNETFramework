using BookStorageBusinessLogic.BindingModels;
using BookStorageBusinessLogic.Interfaces;
using BookStorageBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.BusinessLogics
{
    public class BookBusinessLogic
    {
        private readonly IBookStorage _bookStorage;
        public BookBusinessLogic(IBookStorage bookStorage)
        {
            _bookStorage = bookStorage;
        }
        public List<BookViewModel> Read(BookBindingModel model)
        {
            if (model == null)
            {
                return _bookStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<BookViewModel> { _bookStorage.GetElement(model) };
            }
            return _bookStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(BookBindingModel model)
        {
            var element = _bookStorage.GetElement(new BookBindingModel { BookName = model.BookName });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть книга с таким названием");
            }
            if (model.Id.HasValue)
            {
                _bookStorage.Update(model);
            }
            else
            {
                _bookStorage.Insert(model);
            }
        }
        public void Delete(BookBindingModel model)
        {
            BookViewModel element = _bookStorage.GetElement(new BookBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _bookStorage.Delete(model);
        }
    }
}
