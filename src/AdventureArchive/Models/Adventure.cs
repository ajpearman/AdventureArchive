using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureArchive.Models
{
    public class Adventure
    {
        [ScaffoldColumn(false)]
        public Guid AdventureGuid { get; set; }
        
        [ScaffoldColumn(false)]
        public List<Guid> CharacterGuids { get; set; }

        [Display(Name = "DM Name")]
        public string DmName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}
