using BookStorageBusinessLogic.BindingModels;
using BookStorageBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.Interfaces
{
    public interface IBookFormStorage
    {
        List<BookFormViewModel> GetFullList();
        List<BookFormViewModel> GetFilteredList(BookFormBindingModel model);
        BookFormViewModel GetElement(BookFormBindingModel model);
        void Insert(BookFormBindingModel model);
        void Update(BookFormBindingModel model);
        void Delete(BookFormBindingModel model);
    }
}
