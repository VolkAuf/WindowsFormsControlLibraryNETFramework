using BookStorageBusinessLogic.BindingModels;
using BookStorageBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.Interfaces
{
    public interface IReaderStorage
    {
        List<ReaderViewModel> GetFullList();
        List<ReaderViewModel> GetFilteredList(ReaderBindingModel model);
        ReaderViewModel GetElement(ReaderBindingModel model);
        void Insert(ReaderBindingModel model);
        void Update(ReaderBindingModel model);
        void Delete(ReaderBindingModel model);
    }
}
