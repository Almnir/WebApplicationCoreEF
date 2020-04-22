using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class RecomendedListsHistory
    {
        public int Id { get; set; }
        public int RecListId { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime? DateDelete { get; set; }

        public virtual RecomendedLists RecList { get; set; }
    }
}
