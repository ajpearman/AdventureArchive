using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;


namespace AdventureArchive.Models
{
    public class Character
    {
        [ScaffoldColumn(false)]
        public Guid CharacterGuid { get; set; }

        [Required]
        [Display(Name = "Character Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Class")]
        public Class Class { get; set; }

        [Display(Name = "Level")]
        public int Level { get; set; }

        [Required]
        [Display(Name = "Race")]
        public string Race { get; set; }

        [Required]
        [Display(Name = "Alignment")]
        public string Alignment { get; set; }

        [Display(Name = "Ideals")]
        public string Ideals { get; set; }

        [Display(Name = "Bonds")]
        public string Bonds { get; set; }

        [Display(Name = "Flaws")]
        public string Flaws { get; set; }

        [Display(Name = "Background")]
        public string Background { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Experience Points")]
        public int Exp { get; set; }

        [Display(Name = "Proficiency Bonus")]
        public int ProBonus { get; set; }

        [Display(Name = "Inspiration")]
        public int Ins { get; set; }

        [Display(Name = "Strength")]
        public int Str { get; set; }

        public bool StrSaving { get; set; }

        [Display(Name = "Dexterity")]
        public int Dex { get; set; }

        public bool DexSaving { get; set; }

        [Display(Name = "Constitution")]
        public int Con { get; set; }

        public bool ConSaving { get; set; }

        [Display(Name = "Intelligence")]
        public int Int { get; set; }

        public bool IntSaving { get; set; }

        [Display(Name = "Wisdom")]
        public int Wis { get; set; }

        public bool WisSaving { get; set; }

        [Display(Name = "Charisma")]
        public int Cha { get; set; }
        
        public bool ChaSaving { get; set; }

        [Display(Name = "Perception")]
        public int Per { get; set; }

        [Display(Name = "Armor Class")]
        public int ArmorClass { get; set; }

        [Display(Name = "Initiative")]
        public int Ini { get; set; }

        [Display(Name = "Speed")]
        public int Spd { get; set; }

        [Display(Name = "Hit Points")]
        public int HitPoints { get; set; }

        [Display(Name = "Hit Dice")]
        public string HitDice { get; set; }

        [Display(Name = "Death Saves (Successes)")]
        public int DeathSavesSuccess { get; set; }

        [Display(Name = "Death Saves (Failures)")]
        public int DeathSavesFailures { get; set; }

        [Display(Name = "Spellcasting Ability")]
        public int SpellAbility { get; set; }

        [Display(Name = "Spell Save DC")]
        public int SpellSaveDc { get; set; }

        [Display(Name = "Spell Attack Bonus")]
        public int SpellAttackBonus { get; set; }
        
        [Display(Name = "Platinum")]
        public int Platinum { get; set; }

        [Display(Name = "Gold")]
        public int Gold { get; set; }

        [Display(Name = "Electrum")]
        public int Electrum { get; set; }

        [Display(Name = "Silver")]
        public int Silver { get; set; }

        [Display(Name = "Copper")]
        public int Copper { get; set; }

        [Display(Name = "Feats")]
        public List<string> FeatsList  { get; set; }

        [Display(Name = "Items")]
        public virtual ICollection<Item> Items { get; set; }

        [Display(Name = "Armor")]
        public virtual ICollection<Armor> Armor { get; set; }

        [Display(Name = "Weapons")]
        public virtual ICollection<Weapon> Weapons { get; set; }

        [Display(Name = "Lifestyle Expense")]
        public string LifestyleExpense { get; set; }
    }
}