using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonsterApp.Models
{
    public class MonsterList
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int MonsterId { get; set; }
        public List<Monster> Monsters { get; set; }
    }

    
}