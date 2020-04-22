using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class Rvipersons
    {
        public Rvipersons()
        {
            Entrant = new HashSet<Entrant>();
            RvipersonIdentDocs = new HashSet<RvipersonIdentDocs>();
        }

        public int PersonId { get; set; }
        public bool IsRecordDeleted { get; set; }
        public string NormSurname { get; set; }
        public string NormName { get; set; }
        public string NormSecondName { get; set; }
        public DateTime? BirthDay { get; set; }
        public bool? Sex { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string Snils { get; set; }
        public string Inn { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime IntegralUpdateDate { get; set; }

        public virtual ICollection<Entrant> Entrant { get; set; }
        public virtual ICollection<RvipersonIdentDocs> RvipersonIdentDocs { get; set; }
    }
}
