using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationService.Model.ViewModel
{
    public class BaseEntityViewModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
