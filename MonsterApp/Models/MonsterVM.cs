using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonsterApp.Models
{
    public class MonsterVM
    {
        public IEnumerable<MonsterVM> Monsters { get; set; }

        
        public string Name { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
    }

    
}