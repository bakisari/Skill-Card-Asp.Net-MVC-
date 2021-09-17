using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillsCodeFirstEF.Models.Classes
{
    public class Heads
    {
        [Key]
        public int HeadID { get; set; }
        public string Header { get; set; }
        public string HeadExplanation { get; set; }
    }
}