using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillsCodeFirstEF.Models.Classes
{
    public class Skills
    {
        [Key]
        public int ID { get; set; }
        public string Explanation { get; set; }
        public int Value { get; set; }
    }
}