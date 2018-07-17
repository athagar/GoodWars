using System;
using System.Threading;
using WarriorWars.Enum;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rng = new Random();

        static void Main()
        {
            Console.SetWindowSize(100, 50);

            Console.WriteLine("Select a class to fight the mighty Monktino! ");
            Console.WriteLine("1. Weavlock - 50HP, chance to attack again");
            Console.WriteLine("2. Pouladin - 60HP, boosted health pool");
            Console.WriteLine("3. Hagre - 65HP, highest starting health but is absentminded");
            Console.WriteLine("4. Bardston - 40HP chance to steal health from the enemy");
            Console.WriteLine("5. KarateCzap - 50HP, chance to paralyze enemy for one turn");
            Console.WriteLine("6. Carlsassin - 50HP, slight chance to instantly kill the enemy");
            Console.WriteLine("7. Wiserd - 45HP, chance to do blast damage");
            Console.WriteLine("8. Jaynger - 50HP, chance to escape battle at low health");
            Console.WriteLine("9. Lizard Man - 50HP, chance to regenerate health");

            int charClassChoice = int.Parse(Console.ReadLine());
            //Faction faction;

            Warrior goodGuy = new Warrior("GG", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Monktino", Faction.BadGuy);

            if (charClassChoice == 1)
            {
                goodGuy.name = "Weavlock";
                goodGuy.FACTION = Faction.GoodGuy;
            }
            else if (charClassChoice == 2)
            {
                goodGuy.name = "Pouladin";
                goodGuy.FACTION = Faction.Paladin;
                goodGuy.health = 60;
            }
            else if (charClassChoice == 3)
            {
                goodGuy.name = "Hagre";
                goodGuy.FACTION = Faction.Hagre;
            }
            else if (charClassChoice == 4)
            {
                goodGuy.name = "Bardston";
                goodGuy.FACTION = Faction.Bard;
                goodGuy.health = 40;
            }
            else if (charClassChoice == 5)
            {
                goodGuy.name = "KarateCzap";
                goodGuy.FACTION = Faction.BlackBelt;
            }
            else if (charClassChoice == 6)
            {
                goodGuy.name = "Carlsassin";
                goodGuy.FACTION = Faction.Assassin;
            }
            else if (charClassChoice == 7)
            {
                goodGuy.name = "Wiserd";
                goodGuy.FACTION = Faction.Wizard;
            }
            else if (charClassChoice == 8)
            {
                goodGuy.name = "Jaynger";
                goodGuy.FACTION = Faction.Ranger;
            }
            else if (charClassChoice == 9)
            {
                goodGuy.name = "Lizard Man";
                goodGuy.FACTION = Faction.LizardMan;
            }



            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);

                    if (goodGuy.FACTION == Faction.GoodGuy)
                    {
                        if (rng.Next(0, 100) > 85)
                        {
                            Console.WriteLine("Critical hit!  Attack again!");
                            goodGuy.Attack(badGuy);
                        }
                    }
                    else if (goodGuy.FACTION == Faction.Hagre)
                    {
                        if (rng.Next(0, 100) > 90)
                        {
                            Console.WriteLine($"Hagre forgets what he's doing and gives {badGuy.name} time recover 1 HP!");
                            badGuy.health += 1;
                        }
                    }
                    else if (goodGuy.FACTION == Faction.Bard)
                    {
                        if (rng.Next(0, 100) > 85)
                        {
                            Console.WriteLine($"Bardston convinces {badGuy.name} to give him 1 HP!");
                            badGuy.health -= 1;
                            goodGuy.health += 1;
                        }
                    }
                    else if (goodGuy.FACTION == Faction.BlackBelt)
                    {
                        if (rng.Next(0, 100) > 85)
                        {
                            Console.WriteLine("Paralyzing strike!  Attack again!");
                            goodGuy.Attack(badGuy);
                        }
                    }
                    else if (goodGuy.FACTION == Faction.Assassin)
                    {                 
                        if (rng.Next(0, 100) > 98)
                        {
                            Tools.ColorfulWriteLine("KILL SHOT", ConsoleColor.DarkRed);
                            badGuy.health = 0; 
                            goodGuy.AttackResult(badGuy, 0);

                        }
                    }
                    else if (goodGuy.FACTION == Faction.Wizard)
                    {
                        if (rng.Next(0, 100) > 85)
                        {
                            Console.WriteLine($"Wiserd blasts {badGuy.name} for 2 HP!");
                            badGuy.health -= 2;
                            
                        }
                    }
                    else if ((goodGuy.FACTION == Faction.Ranger) && (goodGuy.health < 5))
                    {
                        if (rng.Next(0, 100) > 75)
                        {
                            Tools.ColorfulWriteLine("JAYNGER NARROWLY ESCAPES DEATH AND LIVES TO FIGHT ANOTHER DAY!", ConsoleColor.Blue);
                            Console.Read();
                            Environment.Exit(0);
                        }
                    }
                    else if (goodGuy.FACTION == Faction.LizardMan)
                    {
                        if (rng.Next(0, 100) > 85)
                        {
                            Console.WriteLine($"{goodGuy.name} heals for 1 point!");
                            goodGuy.health += 1;

                        }
                    }
                }
                else
                {
                    badGuy.Attack(goodGuy);

                    if (badGuy.FACTION == Faction.BadGuy)
                    {
                        if (rng.Next(0, 100) > 85)
                        {
                            Console.WriteLine($"{badGuy.name} heals for 1 point!");
                            badGuy.health += 1;
                        }
                    }
                }

                Thread.Sleep(100);
            }

        }
    }
}
