using BookStorageBusinessLogic.BindingModels;
using System.Collections.Generic;

namespace BookStorageView
{
    internal class readerBindingModel : BookBindingModel
    {
        public int? Id { get; set; }
        public object BookName { get; set; }
        public object BookForm { get; set; }
        public object Annotation { get; set; }
        public List<int> BookReaders { get; set; }
    }
}