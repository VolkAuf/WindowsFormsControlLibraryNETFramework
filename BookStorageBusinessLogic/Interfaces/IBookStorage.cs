using BookStorageBusinessLogic.BindingModels;
using BookStorageBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.Interfaces
{
    public interface IBookStorage
    {
        List<BookViewModel> GetFullList();
        List<BookReportViewModel> GetFullListReport();
        List<BookViewModel> GetFilteredList(BookBindingModel model);
        BookViewModel GetElement(BookBindingModel model);
        void Insert(BookBindingModel model);
        void Update(BookBindingModel model);
        void Delete(BookBindingModel model);
    }
}
