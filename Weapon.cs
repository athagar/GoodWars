using System;
using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        private const int GOOD_GUY_DAMAGE = 5;
        private const int BAD_GUY_DAMAGE = 5;
        private const int PALADIN_DAMAGE = 5;
        private const int HAGRE_DAMAGE = 5;
        private const int BARD_DAMAGE = 5;
        private const int BLACKBELT_DAMAGE = 5;
        private const int ASSASSIN_DAMAGE = 5;
        private const int WIZARD_DAMAGE = 5;
        private const int RANGER_DAMAGE = 5;
        private const int LIZARDMAN_DAMAGE = 5;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = GOOD_GUY_DAMAGE;

                    break;
                case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;
                case Faction.Paladin:
                    damage = PALADIN_DAMAGE;

                    break;
                case Faction.Hagre:
                    damage = HAGRE_DAMAGE;

                    break;
                case Faction.Bard:
                    damage = BARD_DAMAGE;

                    break;
                case Faction.BlackBelt:
                    damage = BLACKBELT_DAMAGE;

                    break;
                case Faction.Assassin:
                    damage = ASSASSIN_DAMAGE;

                    break;
                case Faction.Wizard:
                    damage = WIZARD_DAMAGE;
                    break;
                case Faction.Ranger:
                    damage = RANGER_DAMAGE;
                    break;
                case Faction.LizardMan:
                    damage = LIZARDMAN_DAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}
