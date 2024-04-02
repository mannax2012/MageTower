using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageTower
{
    public enum PlayerClass
    {
        Warrior,
        Mage,
        Paladin,
        Rogue,
        Priest,
        Shaman,
        Druid
    }
    public static class PlayerClassStats
    {
        public static (string Name, int Strength, int Dexterity, int Stamina, int Intellect, int Focus, int Wisdom, int SkillPoints) GetBaseStats(PlayerClass playerClass)
        {
            return playerClass switch
            {
                PlayerClass.Warrior => ("Warrior", 17, 13, 12, 10, 10, 13, 15),
                PlayerClass.Mage => ("Mage", 10, 10, 13, 17, 13, 12, 15),
                PlayerClass.Paladin => ("Paladin", 14, 13, 11, 12, 12, 12, 15),
                PlayerClass.Rogue => ("Rogue", 13, 17, 12, 10, 10, 13, 15),
                PlayerClass.Priest => ("Priest", 10, 10, 10, 10, 10, 10, 15),
                PlayerClass.Shaman => ("Shaman", 10, 10, 10, 10, 10, 10, 15),
                PlayerClass.Druid => ("Druid", 10, 10, 10, 10, 10, 10, 15),
                _ => ("NULL", 10, 10, 10, 10, 10, 10, 15),
            };
        }
    }
}
