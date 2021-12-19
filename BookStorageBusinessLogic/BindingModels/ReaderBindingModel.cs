using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.BindingModels
{
    public class ReaderBindingModel
    {
        public int? Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Patronymic { get; set; }

        public List<int> Books { get; set; }
    }
}
