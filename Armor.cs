using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Armor
    {
        private const int GOOD_GUY_ARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;
        private const int PALADIN_ARMOR = 5;
        private const int HAGRE_ARMOR = 5;
        private const int BARD_ARMOR = 5;
        private const int BLACKBELT_ARMOR = 5;
        private const int ASSASSIN_ARMOR = 5;
        private const int WIZARD_ARMOR = 5;
        private const int RANGER_ARMOR = 5;
        private const int LIZARD_ARMOR = 5;

        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GOOD_GUY_ARMOR;

                    break;
                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR;

                    break;
                case Faction.Paladin:
                    armorPoints = PALADIN_ARMOR;

                    break;
                case Faction.Hagre:
                    armorPoints = HAGRE_ARMOR;

                    break;
                case Faction.Bard:
                    armorPoints = BARD_ARMOR;

                    break;
                case Faction.BlackBelt:
                    armorPoints = BLACKBELT_ARMOR;

                    break;
                case Faction.Assassin:
                    armorPoints = ASSASSIN_ARMOR;

                    break;
                case Faction.Wizard:
                    armorPoints = WIZARD_ARMOR;

                    break;
                case Faction.Ranger:
                    armorPoints = RANGER_ARMOR;

                    break;
                case Faction.LizardMan:
                    armorPoints = LIZARD_ARMOR;

                    break;
                default:
                    break;
            }
        }
    }
}
