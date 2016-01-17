using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureArchive.Models
{
    public class Armor
    {
        [ScaffoldColumn(false)]
        public Guid ArmorGuid { get; set; }

        [ScaffoldColumn(false)]
        public Guid CharacterGuid { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Cost (GP)")]
        public int Cost { get; set; }

        [Display(Name = "Armor Class (AC)")]
        public int ArmorClass { get; set; }

        [Display(Name = "Strength Requirement")]
        public int Strength { get; set; }

        [Display(Name = "Stealth Disadvantage")]
        public bool StealthDisadvantage { get; set; }

        [Display(Name = "Weight (lbs)")]
        public int Weight { get; set; }

        [Display(Name = "Don Time")]
        public int DonTime { get; set; }

        [Display(Name = "Doff Time")]
        public int DoffTime { get; set; }
    }
}
