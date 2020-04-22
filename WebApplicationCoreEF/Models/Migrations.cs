using System;
using System.Collections.Generic;

namespace WebApplicationCoreEF.Models
{
    public partial class Migrations
    {
        public int Id { get; set; }
        public string ScriptName { get; set; }
        public DateTime ScriptDate { get; set; }
    }
}
