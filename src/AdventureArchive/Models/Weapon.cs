using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureArchive.Models
{
    public class Weapon
    {
        [ScaffoldColumn(false)]
        public Guid WeaponGuid { get; set; }

        [ScaffoldColumn(false)]
        public Guid CharacterGuid { get; set; }

        [Required]
        public string Name { get; set; }

        public int Cost { get; set; }

        public string Damage { get; set; }

        [Display(Name = "Damage Type")]
        public string DamageType { get; set; }

        public int Weight { get; set; }

        public string Description { get; set; }

        public string Proficiency { get; set; }

        public List<string> Properties { get; set; }

        public bool Silvered { get; set; }

        public bool Ranged { get; set; }

        public int Range { get; set; }
    }
    
}
