using BookStorageBusinessLogic.BindingModels;
using BookStorageBusinessLogic.Interfaces;
using BookStorageBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.BusinessLogics
{
    public class ReaderBusinessLogic
    {
        private readonly IReaderStorage _readerStorage;
        public ReaderBusinessLogic(IReaderStorage readerStorage)
        {
            _readerStorage = readerStorage;
        }
        public List<ReaderViewModel> Read(ReaderBindingModel model)
        {
            if (model == null)
            {
                return _readerStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ReaderViewModel> { _readerStorage.GetElement(model) };
            }
            return _readerStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(ReaderBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _readerStorage.Update(model);
            }
            else
            {
                _readerStorage.Insert(model);
            }
        }
        public void Delete(ReaderBindingModel model)
        {
            ReaderViewModel element = _readerStorage.GetElement(new ReaderBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _readerStorage.Delete(model);
        }
    }
}
