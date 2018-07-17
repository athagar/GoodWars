using WarriorWars.Equipment;
using WarriorWars.Enum;
using System;

namespace WarriorWars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 50;
        private const int BAD_GUY_STARTING_HEALTH = 50;
        public const int PALADIN_STARTING_HEALTH = 60;
        public const int HAGRE_STARTING_HEALTH = 65;
        public const int BARD_STARTING_HEALTH = 40;
        public const int BLACKBELT_STARTING_HEALTH = 50;
        public const int ASSASSIN_STARTING_HEALTH = 50;
        public const int WIZARD_STARTING_HEALTH = 50;
        public const int RANGER_STARTING_HEALTH = 50;
        public const int LIZARDMAN_STARTING_HEALTH = 50;

        public  Faction FACTION;

        public int health;
        private int killCounter;
        public string name;
        private bool isAlive;

        private Weapon weapon;
        private Armor armor;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;

                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;

                    break;
                case Faction.Paladin:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = PALADIN_STARTING_HEALTH;

                    break;
                case Faction.Hagre:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = HAGRE_STARTING_HEALTH;

                    break;
                case Faction.Bard:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BARD_STARTING_HEALTH;

                    break;
                case Faction.BlackBelt:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BLACKBELT_STARTING_HEALTH;

                    break;
                case Faction.Assassin:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = ASSASSIN_STARTING_HEALTH;

                    break;
                case Faction.Wizard:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = WIZARD_STARTING_HEALTH;

                    break;
                case Faction.Ranger:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = RANGER_STARTING_HEALTH;

                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;
            enemy.health -= damage;

            AttackResult(enemy, damage);
        }

        public void AttackResult(Warrior enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                killCounter++;
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} is victorious!", ConsoleColor.Green);
                Console.WriteLine("Press ENTER to exit");
                Console.Read();
                
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemy.name}. {damage} damage was dealt to {enemy.name},  {enemy.name}'s health is {enemy.health}");
            }
        }
        
    }
}
