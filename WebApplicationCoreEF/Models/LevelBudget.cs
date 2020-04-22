using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class LevelBudget
    {
        public LevelBudget()
        {
            DistributedAdmissionVolume = new HashSet<DistributedAdmissionVolume>();
        }

        public int IdLevelBudget { get; set; }
        public string BudgetName { get; set; }

        public virtual ICollection<DistributedAdmissionVolume> DistributedAdmissionVolume { get; set; }
    }
}
