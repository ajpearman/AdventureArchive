using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureArchive.Models
{
    public class Classes
    {
        public string HitPointHitDice { get; set; }
        public int FirstLevelHitPoints { get; set; }
        public List<int> ProfBonusIncreaseLevels { get; set; }
        public int ProfBonus { get; set; }
        public List<string> FeatureList { get; set; }
        public List<string> ArmorProfsList { get; set; }
        public List<string> WeaponProfsList { get; set; }
        public List<string> ToolProfsList { get; set; }
        public List<string> SavingThrowsList { get; set; }
        public List<string> SkillsList { get; set; }
        public int SkillsToChoose { get; set; }
        public List<string> EquipmentOptionsList { get; set; }
    }

    public class Barbarian : Classes
    {
        public Barbarian()
        {
            HitPointHitDice = "d12";
            FirstLevelHitPoints = 12;
            ProfBonus = 2;
            ProfBonusIncreaseLevels = new List<int>() { 5, 9, 13, 17 };
            FeatureList = new List<string>() { "Rage", "Unarmored Defense", "Reckless Attack", "Danger Sense", "Primal Path", "Extra Attack", "Fast Movement", "Feral Instinct", "Brutal Critical", "Relentless Rage", "Persistent Rage", "Indomitable Might", "Primal Champion"};
            PathList = new List<string>() {"Path of the Berserker", "Path of the Totem Warrior"};
            ArmorProfsList = new List<string>() { "Light", "Medium", "Shields" };
            WeaponProfsList = new List<string>() { "Simple", "Martial" };
            ToolProfsList = new List<string>();
            SavingThrowsList = new List<string>() { "Strength", "Constitution" };
            SkillsList = new List<string>() { "Animal Handling", "Athletics", "Intimidation", "Nature", "Perception", "Survival" };
            EquipmentOptionsList = new List<string>() { Equipment1, Equipment2, Equipment3 };
            SkillsToChoose = 2;
            RageCount = 2;
            RageDamage = 2;
        }

        public int RageCount { get; set; }
        public int RageDamage { get; set; }
        public List<string>  PathList { get; set; }
        private const string Equipment1 = "A greataxe or any martial melee weapon.";
        private const string Equipment2 = "Two handaxes or any simple weapon.";
        private const string Equipment3 = "An explorer's pack and four javelins.";
    }

    public class Cleric : Classes
    {
        public Cleric()
        {
            
        }
    }
}
