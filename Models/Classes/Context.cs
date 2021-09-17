using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace SkillsCodeFirstEF.Models.Classes
{
    public class Context :DbContext
    {
        public DbSet<Skills> Skillss { get; set; }
        public DbSet<Heads> Hedass { get; set; }
    }
}