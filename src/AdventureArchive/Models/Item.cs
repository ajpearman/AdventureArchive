using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureArchive.Models
{
    public class Item
    {
        [ScaffoldColumn(false)]
        public Guid ItemGuid { get; set; }

        [ScaffoldColumn(false)]
        public Guid CharacterGuid { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Cost { get; set; }

        public int Weight { get; set; }

        public bool IsContainer { get; set; }

        public string Capacity { get; set; }
    }
}
