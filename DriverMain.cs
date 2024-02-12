using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Text;

namespace RPGFunger
{
    public class Stats
    {
        public Stats()
        {
            Name = "";
            Descrip = "";
            Hp = 0;
            MaxHP = 0;
            Dmg = 0;
            Spd = 0;
            Exp = 0;
            Lvl = 0;
        }

        public string Name;
        public string Descrip;
        public int Hp;
        public int MaxHP;
        public int Dmg;
        public int Spd;
        public int Exp;
        public int Lvl;

        public string GetName()
        {
            return Name;
        }

        public string GetDescrip()
        {
            return Descrip;
        }

        public int GetHp()
        {
            return Hp;
        }

        public int GetDmg()
        {
            return Dmg;
        }

        public int GetSpd()
        {
            return Spd;
        }

        public int GetExp()
        {
            return Exp;
        }

        public int GetLvl()
        {
            return Lvl;
        }
        public void GainExp(int exp)
        {
            Exp += exp;
        }
        public void IncreaseLevel()
        {
            Lvl += 1;
        }
        public void LevelUp()
        {
            Thread.Sleep(500);
            Console.WriteLine("\n>>>>>>>-Congratulations! You have leveled up!-<<<<<<<");
            Thread.Sleep(500);
            Lvl += 1;
            MaxHP += 40 + (Lvl * 2);  
            Dmg += 15 + (Lvl * 2);     
            Spd += 5;     
            Hp = MaxHP;
            Exp -= 100;
            Exp = Math.Max(Exp, 0);
        }
    }

    public class ClassChar
    {
        public static Stats CreateWarrior()
        {
            Stats classPlayer = new Stats
            {
                Name = "Warrior",
                Descrip = "The Warrior, As someone born with a soul of the endless, the warrior is a free-spirited and creative person, who is not easily bound by responsibilities. Due to his upbringing, the warrior is a ruthless, opportunistic man who is more than willing to use cheap tricks to survive and gain the upper hand.",
                Hp = 220,
                MaxHP = 200,
                Dmg = 40,
                Spd = 50,
                Lvl = 1,
                Exp = 0
            };
            return classPlayer;
        }

        public static Stats CreateArcher()
        {
            Stats classPlayer = new Stats
            {
                Name = "Archer",
                Descrip = "The Archer, born with a Domination soul, an essence that compelled her to assert control over those in her midst. This innate quality rendered her a natural leader, yet it also made her reluctant to engage in self-reflection. In her youth, it was decided that D'arce would become a holy archer, a decision that set her on the path of squireship and rigorous training. Intensive drills and frequent sparring sessions sculpted into a skilled and tenacious warrior.",
                Hp = 140,
                MaxHP = 140,
                Dmg = 55,
                Spd = 65,
                Lvl = 1,
                Exp = 0
            };
            return classPlayer;
        }

        public static Stats CreateMage()
        {
            Stats classPlayer = new Stats
            {
                Name = "Mage",
                Descrip = "The Dark Mage, originated either within the hallowed precincts of a temple or, alternately, the murky depths of a well—an ambiguity that complicates his biography. Forsaking his initial locus, he embarks on an intellectual odyssey through the esoteric terrains of alchemy, magic, and ancient deities, thereby elevating his stature as a luminary within those arcane circles.",
                Hp = 150,
                MaxHP = 150,
                Dmg = 60,
                Spd = 50,
                Lvl = 1,
                Exp = 0
            };
            return classPlayer;
        }

        public static Stats CreateAssassin()
        {
            Stats classPlayer = new Stats
            {
                Name = "Assassin",
                Descrip = "The Assassin, behold the enigmatic figure known colloquially as the Assassin, yet within the diegetic realm, christened shadow. This ethereal wanderer is a scion of the elusive Kingdom of Oldegård, wherein he acquired the martial disciplines of combat during his formative circumambulations around the night.",
                Hp = 110,
                MaxHP = 110,
                Dmg = 80,
                Spd = 70,
                Lvl = 1,
                Exp = 0
            };
            return classPlayer;
        }
    }

    public class Enemies
    {
        public static Stats CreateGhoulEnemy()
        {
            Stats enemy = new Stats
            {
                Name = "Ghoul",
                Descrip = "An undead. Weak",
                Hp = 150,
                Dmg = 30,
                Spd = 45,
                Lvl = 1,
                Exp = 35
            };
            return enemy;
        }

        public static Stats CreateOrcEnemy()
        {
            Stats enemy = new Stats
            {
                Name = "Orc",
                Descrip = "A giant formidable enemy born with a tanky body",
                Hp = 300,
                Dmg = 40,
                Spd = 60,
                Lvl = 2,
                Exp = 55
            };
            return enemy;
        }

        public static Stats CreateNightLurchEnemy()
        {
            Stats enemy = new Stats
            {
                Name = "Night Lurch",
                Descrip = "A four-legged being with claws and frog-like legs. Has high speed and can inflict bleeding",
                Hp = 760,
                Dmg = 120,
                Spd = 150,
                Lvl = 10,
                Exp = 200
            };
            return enemy;
        }

        public static Stats CreateDarkPriestEnemy()
        {
            Stats enemy = new Stats
            {
                Name = "Dark Priest",
                Descrip = "A priest that follows the being of chaos and fear, mostly does magic damage, weak but deals heavy damage",
                Hp = 550,
                Dmg = 90,
                Spd = 95,
                Lvl = 6,
                Exp = 90
            };
            return enemy;
        }

        public static Stats CreateCrawMaulerEnemy()
        {
            Stats enemy = new Stats
            {
                Name = "Crow Mauler",
                Descrip = "An enemy that wears the head of a Crow. Human-sized but is a mutant able to kill to do massive damage",
                Hp = 1800,
                Dmg = 200,
                Spd = 225,
                Lvl = 18,
                Exp = 350
            };
            return enemy;
        }

        public static Stats CreateBeing()
        {
            Stats enemy = new Stats
            {
                Name = "Gro-goroth",
                Descrip = "#############################",
                Hp = 9999999,
                Dmg = 9999999,
                Spd = 9999999,
                Lvl = 999,
                Exp = 99999999
            };
            return enemy;
        }
    
        public static bool BatlleLogic(Stats playerClass, Stats enemyClass)
        {
            Thread.Sleep(500);
            Console.WriteLine($"\n==========\nYou have encountered an enemy {enemyClass.GetName()}");
            bool life = true;
            
            while (playerClass.GetHp() > 0 && enemyClass.GetHp() > 0)
            {
                if (enemyClass.GetSpd() > playerClass.GetSpd())
                {
                    FirstMoveEnemy(playerClass, enemyClass);
                }
                else
                {
                    FirstMovePlayer(playerClass, enemyClass);
                }

                if (playerClass.GetHp() <= 0)
                {
                    Console.WriteLine("You Died.");
                    life = false;
                    return life;
                    if (life == false)
                    {
                        Driver.ReTry();
                    }
                }

                if (playerClass.GetHp() > 0 && enemyClass.GetHp() <= 0)
                {
                    Thread.Sleep(1500);
                    Console.Clear();
                    Console.WriteLine($"You defeated the {enemyClass.GetName()}!");
                    int expGained = enemyClass.GetExp();
                    playerClass.GainExp(expGained);
                    Console.WriteLine($"You gained {expGained} experience points!");
                    while (playerClass.GetExp() >= 100)
                    {
                        Console.Clear();
                        playerClass.LevelUp();

                    }
                }
            }        
            return life;
        }



        private static void FirstMoveEnemy(Stats player, Stats enemy)
        {
            Console.WriteLine("Enemy attacks first!");
            while (player.GetHp() > 0 && enemy.GetHp() > 0)
            {
                if (player.GetHp() <= 0)
                {
                    return;
                }
                if (enemy.GetHp() <= 0)
                {
                    return;
                }
                else
                {
                    EnemyTurn(player, enemy);
                    PlayerTurn(player, enemy);
                }
            }
        }

        private static void FirstMovePlayer(Stats player, Stats enemy)
        {
            Console.WriteLine("You attack first!");
            while (player.GetHp() > 0 && enemy.GetHp() > 0)
            {
                if (player.GetHp() <= 0)
                {
                    return;
                }
                if (enemy.GetHp() <= 0)
                {
                    return;
                }
                else
                {
                    PlayerTurn(player, enemy);
                    EnemyTurn(player, enemy);
                }
            }
        }
        private static void EnemyTurn(Stats player, Stats enemy)
        {
            if (player.GetHp() <= 0)
            {
                return;
            }
            if (enemy.GetHp() <= 0)
            {
                return;
            }
            else
            {
            Driver.Loading();
            int damage = CalculateDamage(enemy.GetDmg());
            player.Hp -= damage;
            Console.WriteLine($"==========\n{enemy.GetName()} attacked! You received |{damage}| damage.\n==========");
            DisplayHealth(player, enemy);
            }
            
        }

        private static void PlayerTurn(Stats player, Stats enemy)
        {
            if (player.GetHp() < 0)
            {
                return;
            }
            
            if (enemy.GetHp() <= 0)
            {
                return;
            }
            else
            {
            Driver.Loading();
            int damage = CalculateDamage(player.GetDmg());
            enemy.Hp -= damage;
            Console.WriteLine($"==========\nYou attacked {enemy.GetName()}! Inflicted |{damage}| damage.\n==========");
            DisplayHealth(player, enemy);
            }
        }



        private static int CalculateDamage(int damage)
        {
            return damage;
        }

        private static void DisplayHealth(Stats player, Stats enemy)
        {
            Console.WriteLine($"Your HP: |{player.GetHp()}| | {enemy.GetName()}'s HP: |{enemy.GetHp()}|");
        }
    }

    public class Driver
    {
        private static Stats playerClass;
        private static Stats enemyClass;
        public static void Main()
        {
            // Player name input
            Console.WriteLine("Enter your name: ");
            string namePlayer = Console.ReadLine();
            Console.WriteLine("Welcome, " + namePlayer + "!\n");
            Thread.Sleep(500);

            // Game Story and Class choosing
            Console.WriteLine("Welcome to the world of Funger. A world where due to the mistakes of a couple of adventurers, birthed a being of chaos and fear" +
                              "\nYou are an inhabitant of the world and must now face the creations of this said being. I must now go as I am one of the adventurers who is at fault for the mistake");
            Console.WriteLine("-------------------------------------------------------------------");
            Thread.Sleep(500);
            Console.WriteLine("Good luck in the quest given. Godspeed!");

            // Class choosing... Hanggang dto lng labling tinamad ako
            classChoosing:
            Console.WriteLine(
                "\nChoose your class:" +
                "\nWarrior\nArcher\nMage\nAssassin");
            string classChoice = Console.ReadLine();
            switch (classChoice)
            {
                case "Warrior":
                    playerClass = ClassChar.CreateWarrior();
                    break;
                case "Archer":
                    playerClass = ClassChar.CreateArcher();
                    break;
                case "Mage":
                    playerClass = ClassChar.CreateMage();
                    break;
                case "Assassin":
                    playerClass = ClassChar.CreateAssassin();
                    break;
                default:
                    Console.WriteLine("Invalid class choice. Choose again.");
                    goto classChoosing;
            }

            DisplayClassDetails(playerClass);

            Thread.Sleep(500);
            Console.WriteLine($"{classChoice}: You are at the castle of where the being resides.");
            Movement();
            ReTry();
        }

        private static void Movement()
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Where will you go?");
            Console.WriteLine("============================\nMines\nPrison\nLibrary\nDungeon\nTemple\nHidden Room\n============================");
            string placeChoice = Console.ReadLine();
            if (placeChoice == "Mines" || placeChoice == "Dungeon")
            {
                Console.WriteLine($"\n>>>You went to the {placeChoice}<<<");
                MinesorDungeon();
                Thread.Sleep(1000);
                Console.Clear();
            }
            if (placeChoice == "Prison")
            {         
                Console.WriteLine($"\n>>>You went to the {placeChoice}<<<");       
                Prison();
                Thread.Sleep(1000);
                Console.Clear();
            }
            if (placeChoice == "Library")
            {       
                Console.WriteLine($"\n>>>You went to the {placeChoice}<<<");         
                Library();
                Thread.Sleep(1000);
                Console.Clear();
            }
            if (placeChoice == "Temple")
            {       
                Console.WriteLine($"\n>>>You went to the {placeChoice}<<<");         
                Temple();
                Thread.Sleep(1000);
                Console.Clear();
            }
            if (placeChoice == "Hidden Room")
            {         
                Console.WriteLine($"\n>>>You went to the {placeChoice}<<<");      
                HiddenRoom();
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {              
                Console.WriteLine ("Invalid action");
                Movement();
            }
        }

        public static void DisplayClassDetails(Stats character)
        {
            Console.WriteLine($"\n{character.GetName()} Details:" +
                              $"\nDescription: {character.GetDescrip()}" +
                              $"\nHP: {character.GetHp()}" +
                              $"\nDMG: {character.GetDmg()}" +
                              $"\nSPD: {character.GetSpd()}" +
                              $"\nLVL: {character.GetLvl()}" +
                              $"\nEXP: {character.GetExp()}");
        }

        public static void DisplayEnemyClassDetails(Stats enemy)
        {
            Console.WriteLine($"\n{enemy.GetName()} Details:" +
                              $"\nDescription: {enemy.GetDescrip()}" +
                              $"\nHP: {enemy.GetHp()}" +
                              $"\nDMG: {enemy.GetDmg()}" +
                              $"\nSPD: {enemy.GetSpd()}" +
                              $"\nLVL: {enemy.GetLvl()}" +
                              $"\nEXP: {enemy.GetExp()}");
        }

        public static void MinesorDungeon()
        {
            bool life = true;
            while (life)
            {
                Menu();
                int exploreChoice = Convert.ToInt32(Console.ReadLine());

                if (exploreChoice == 1)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("///You encountered enemies. Pick which to fight:///\n[1] Ghoul\n[2] Orc");
                    int enemyChoice = Convert.ToInt32(Console.ReadLine());

                    Stats enemy = (enemyChoice == 1) ? Enemies.CreateGhoulEnemy() : Enemies.CreateOrcEnemy();
                    EnemyArt(enemy);
                    if (playerClass.GetLvl() < enemy.GetLvl())
                    {
                        Driver.DisplayEnemyClassDetails(enemy);
                        Thread.Sleep(500);
                        Console.WriteLine("!!!WARNING ENEMY DIFFICULTY TOO HIGH FOR YOUR LEVEL!!!\nDo you wish to proceed?\n[Y] or [N]");
                        string proceed = Console.ReadLine();
                        if (proceed == "Y")
                        {
                            life = Enemies.BatlleLogic(playerClass, enemy);
                            if (!life)
                            {
                                ReTry();
                            }
                        }
                    }
                    else
                    {
                        Driver.DisplayEnemyClassDetails(enemy);
                        life = Enemies.BatlleLogic(playerClass, enemy);
                        if (!life)
                        {
                            ReTry();
                        }
                    }
                }
                else if (exploreChoice == 2)
                {
                    HpHeal(playerClass);
                }
                else if (exploreChoice == 3)
                {
                    DisplayClassDetails(playerClass);
                }
                else if (exploreChoice == 4)
                {
                    Movement();
                }
                else
                {
                    Console.WriteLine("Invalid action");
                    MinesorDungeon();
                }
            }
        }


        public static void Prison()
        {
            bool life = true;
            while(life)
            {
                Menu();
                int exploreChoice = Convert.ToInt32(Console.ReadLine());
                if (exploreChoice == 1)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("///While exploring the prison you encountered the Night Lurch.///");
                    
                    Stats enemy = Enemies.CreateNightLurchEnemy();
                    EnemyArt(enemy);
                    if (playerClass.GetLvl() < enemy.GetLvl())
                    {
                        Driver.DisplayEnemyClassDetails(enemy);
                        Thread.Sleep(500);
                        Console.WriteLine("!!!WARNING ENEMY DIFFICULTY TO HIGH FOR YOU LEVEL!!!\nDo you wish to proceed?\n[Y] or [N]");
                        string proceed = Console.ReadLine();
                        if (proceed == "Y")
                        {
                            life = Enemies.BatlleLogic(playerClass, enemy);
                            if (life == false)
                            {
                                ReTry();
                            }
                        }
                    } 
                    else
                    {
                        Driver.DisplayEnemyClassDetails(enemy);
                        life = Enemies.BatlleLogic(playerClass, enemy);
                        if (life == false)
                        {
                            ReTry();
                        }
                    }
                    
                }
                else if (exploreChoice == 2)
                {
                    HpHeal(playerClass);
                }
                else if (exploreChoice == 3)
                {
                    DisplayClassDetails(playerClass);
                }
                else if (exploreChoice == 4)
                {
                    Movement();
                }
                else
                {
                    Console.WriteLine ("Invalid action");
                    Prison();
                }
            }
        }

        public static void Library()
        {
            bool life = true;
            while(life)
            {
                Menu();
                int exploreChoice = Convert.ToInt32(Console.ReadLine());
                if (exploreChoice == 1)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("///While exploring the prison you encountered a Dark Priest.///");
                    
                    Stats enemy = Enemies.CreateDarkPriestEnemy();
                    EnemyArt(enemy);
                    if (playerClass.GetLvl() < enemy.GetLvl())
                    {
                        Driver.DisplayEnemyClassDetails(enemy);
                        Thread.Sleep(500);
                        Console.WriteLine("!!!WARNING ENEMY DIFFICULTY TO HIGH FOR YOU LEVEL!!!\nDo you wish to proceed?\n[Y] or [N]");
                        string proceed = Console.ReadLine();
                        if (proceed == "Y")
                        {
                            life = Enemies.BatlleLogic(playerClass, enemy);
                            if (life == false)
                        {
                            ReTry();
                        }
                        }
                    } 
                    else
                    {
                        Driver.DisplayEnemyClassDetails(enemy);
                        life = Enemies.BatlleLogic(playerClass, enemy);
                        if (life == false)
                        {
                            ReTry();
                        }
                    }
                    
                }
                else if (exploreChoice == 2)
                {
                    HpHeal(playerClass);
                }
                else if (exploreChoice == 3)
                {
                    DisplayClassDetails(playerClass);
                }
                else if (exploreChoice == 4)
                {
                    Movement();
                }
                else
                {
                    Console.WriteLine ("Invalid action");
                    Library();
                }
            }
        }

        public static void Temple()
        {
            bool life = true;
            while(life)
            {
                Menu();
                int exploreChoice = Convert.ToInt32(Console.ReadLine());
                if (exploreChoice == 1)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("///While exploring the prison you encountered the Crow Mauler.///");
                    
                    Stats enemy = Enemies.CreateCrawMaulerEnemy();
                    EnemyArt(enemy);
                    if (playerClass.GetLvl() < enemy.GetLvl())
                    {
                        Driver.DisplayEnemyClassDetails(enemy);
                        Thread.Sleep(500);
                        Console.WriteLine("!!!WARNING ENEMY DIFFICULTY TO HIGH FOR YOU LEVEL!!!\nDo you wish to proceed?\n[Y] or [N]");
                        string proceed = Console.ReadLine();
                        if (proceed == "Y")
                        {
                            life = Enemies.BatlleLogic(playerClass, enemy);
                            if (life == false)
                        {
                            ReTry();
                        }
                        }
                    } 
                    else
                    {
                        Driver.DisplayEnemyClassDetails(enemy);
                        life = Enemies.BatlleLogic(playerClass, enemy);
                        if (life == false)
                        {
                            ReTry();
                        }
                    }
                    
                }
                else if (exploreChoice == 2)
                {
                    HpHeal(playerClass);
                }
                else if (exploreChoice == 3)
                {
                    DisplayClassDetails(playerClass);
                }
                else if (exploreChoice == 4)
                {
                    Movement();
                }
                else
                {
                    Console.WriteLine ("Invalid action");
                    Temple();
                }
            }
        }

        public static void HiddenRoom()
        {
            bool life = true;
            while(life)
            {
                Menu();
                int exploreChoice = Convert.ToInt32(Console.ReadLine());
                if (exploreChoice == 1)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(">>>YOU WENT STRAIGHT TO THE BOSS<<<\n!!!YOU CANNOT ESCAPE!!!");
                    
                    Stats enemy = Enemies.CreateBeing();
                    EnemyArt(enemy);
                    if (playerClass.GetLvl() < enemy.GetLvl())
                    {
                        Driver.DisplayEnemyClassDetails(enemy);
                        Thread.Sleep(500);
                        life = Enemies.BatlleLogic(playerClass, enemy);
                        if (life == false)
                        {
                            ReTry();
                        }
                        if (life == true)
                        {
                            Console.WriteLine("Congratulations you defeated the boss!");
                            ReTry();
                        }                       
                    } 
                    else
                    {
                        Driver.DisplayEnemyClassDetails(enemy);
                        life = Enemies.BatlleLogic(playerClass, enemy);
                        if (life == false)
                        {
                            ReTry();
                        }
                    }
                    
                }
                else if (exploreChoice == 2)
                {
                    HpHeal(playerClass);
                }
                else if (exploreChoice == 3)
                {
                    DisplayClassDetails(playerClass);
                }
                else if (exploreChoice == 4)
                {
                    Movement();
                }
                else
                {
                    Console.WriteLine ("Invalid action");
                    HiddenRoom();
                }
            }
        }

        public static void Menu()
        {
            Thread.Sleep(500);
            Driver.DisplayClassDetails(playerClass);
            Console.WriteLine(@"
===================================
[1] Explore 
[2] Drink an HP pot
[3] Check Stats
[4] Go back 
===================================
            ");
        }

        public static void HpHeal(Stats playerClass)
        {
            int maxHp = playerClass.MaxHP;
            playerClass.Hp = maxHp;
            Thread.Sleep(500);
            Console.WriteLine("Using Hp Pot");
            Driver.LoadingDots();
            Console.WriteLine("You used a Hp pot. You're fully healed");
            Console.WriteLine($"HP at: {playerClass.Hp}");
        }
        
        public static void ReTry()
        {
            Console.WriteLine("\n=====================\nPlay Again?\n[Y] or [N]");
            string res = Console.ReadLine();
            if (res == "Y")
            {
                playerClass = null;
                enemyClass = null;
                Console.Clear();
                Driver.Main();
            }
            else
            {
                Console.WriteLine("Thanks for playing my game. I miss my ex.");
                Environment.Exit(0);
            }
        }

        public static void Loading()
        {   
            Thread.Sleep(400);
            Console.WriteLine("==========\nBattling ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(300);
            }

            Console.WriteLine(); 
        }

        public static void LoadingDots()
        {   
            Thread.Sleep(500);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(300);
            }

            Console.WriteLine(); 
        }

        public static void EnemyArt(Stats Enemies){
        string enemyName = Enemies.GetName();
            switch(enemyName)
            {
                case "Ghoul":
                Console.WriteLine(@"
                                                                                                                                                 
                                                                                                                                                 
                                                                    ██████████                                                                   
                                                                  █▒ ░▒▓▓▒▒▒░▒▓██                                                                
                                                                █    ▒▒▓▓▓▓▓▓▓▒▒██                                                               
                                                              ██▒  ░▒▒▒▒▒▒▓▓▓▓▓ ▓██                                                              
                                                              ██░░▒▓▓▒░  ▒▒▓▓██ ▓██                                                              
                                                             ███▓░▓▓▓▒░  ░▒▒▓█▓░████                                                             
                                                             █████░▓▒▒▒░░░▒▒▓█▒▓████                                                             
                                                             █████▓░▒▒▒▒▒▒▒▒▓▓▒█████                                                             
                                                              ███▓▒▓▓▓█▒▒▒▒▓▓▓▓████                                                              
                                                              ██████████▓██████████                                                              
                                                              █████▓███▓▒▓████▓████                                                              
                                                               ███████▓▒▒▒█████████                                                              
                                                             ████████▓▒▒▒▒▒█████████                                                             
                                                            ██▓▒▓█████▓▒▒▒▓███████████                                                           
                                                          ██▓░ ▓████████████████▒██░░██                                                          
                                                       ███▒  ▒▓▒▓▓█████████████▒██▓▓▓ ▓██                                                        
                                                     ████  ██▓▓▒▒▓▓██▓██▓██▓██████████▓ ░████                                                    
                                                  ████▓░ ▒░ ░▒██▓█████▓███▓████████▓▓▓▓▓▓▒▓▓▓███                                                 
                                               ███░  ░▓██▓▓▓▒▒    ░▓▓▓███████▓░  ▓▒▓▓▓███▓░░   ░█                                                
                                             ██▓    ░▒▓▓▓▓███▓▓███▓▒░       ▒█████████████▓▓▒    █                                               
                                             █▒      ▒▓██████▓▓▓██▓▓███░ ░███████████████████▓   ██                                              
                                            ██▒     ░▓███████████▓▒░░░▓▓  █▓▒▒▒▓▓█████████████▒  ██                                              
                                            ██▒    ░░▓██████▓▒░░░░▒▒▓▓▓░ ░█▓▓▒▒▓▓█████████████▓▒████                                             
                                            ████▒░░░▒██████▓▓███▓▒▒▓▓▒▒░ ▒█▒▓█▓▓██████████████▓▓███                                              
                                            ████▓▓▒▒█████▓███▓▒▒░░░░░▒▓▓░██▓░░▒▒▓▓▓█████████████████                                             
                                           ████████████████▓▓▓▓▓████████▒██████████████████████▒▒███                                             
                                           ███▓░▒████████████▓▒▓▒░░░▓██▓░▒██▓▒▒▓█████████████▓▓  ░██                                             
                                           ██▒   ▒▒████████████████████▒░▓████████████████████▒░ ░██                                             
                                            █▓   ▒▒▓█████▓▒▓▓████▒  ░▒░░   ░▓████████████████▓▒▒  ▒██                                            
                                           ██   ░▒▓███████▓▒▓▓▓▒░ ▒▓▓▓█▒▒███▓░▒██████████████▓▒▒░░░███                                           
                                           █▒ ▒░░▒▓███████████▓▒░░▓████▓░█████▒░▓████████████▓▒▒▒░ ▓██                                           
                                          ██▒░▒▒▒▒███████▓▓▓▓██▒░░▒▓▓▓█▒▒▓▓▓███▓░▓▓███████████▓▒▓▒▓███                                           
                                          ███▓▓▓▓▓████████▓▓▓▓▓▓░░▓▓▓▓▓▒▒█▓▓███▒▒▒█████████████▓███████                                          
                                          ███████████████████▓▓▒░░▓████▓▒████████▓▓██████████████▓▓ ▓██                                          
                                         ██ ▒▓▓██▓▓████████▓▓▓█▒  ▒███▓▒░▒▓▓▒█▓█████████████████░▓█▒▒██                                          
                                        ██▒ ██▒▒░ ▒████████████▒░ ▒▓▓▓█▓▒▒▓█▓███▒░▓██████████████▓░░▒██                                          
                                         █ ░░░█▒░▒▓███ ███▓▓█▓▒░░▒▓▓▓▓█▓░▒█████▓░░░░▓░██████████▓▓▒▒▓██                                          
                                        ██ ░▒▓▓▓▓█████ ███▒▒▒▓▒▒░░▓████▓████████▒▓▓░░▓▓████████▓▓▓█▒▓██                                          
                                        ██ ░█▓▓█▓██████████████▒  ▓▓▓▓▒░   ▒▒▒▒▒▓█▒░▒█████ █████▒▓█▓▓██                                          
                                         █ ░▓████████ ██░░      ▒▓█░ ░▓██▓▒▓██████▒███████ █████▒▓█▓███                                          
                                         █ ░▓▓███████████▓▓▒▒▓▒▓▓▒██▓▓████▓███████████████ ████▓▒██▓███                                          
                                         █ ▒▓███████  ████▓████▓▓▒▒▓█▒   ░░▒▓████▓▓▓██████  ███▓▒██▓███                                          
                                         █ ▓██▓████   ████████▓███▓  ▒▓████▓███▒▒██████████ ████▓▓█████                                          
                                        █░ ██▓▓████  ███░ ░▓▓░▒██▒░▒███████████░▓████▓██████████▓▓█████                                          
                                        █ ░██▒▓███   ██▒▒▒▒▓▓▒░░░░▓███▓▒░░ ░░░▓░░▓██▓▓█████ █████▒▓████                                          
                                       ██ ░█▒▒████   ███▓▓███▓▒▒▒▒▒▒▓▒▒▒██████▓  ▓█▓███████  ████▓▒████                                          
                                        █  ▓▒▓████   ████████▓▓▓▒▒░ ▒▒████████▓█░▒█▓███████  █████▓▓███                                          
                                        █ ░▒▒████   ████████████▓▒░ █████████▓▒▒█▒░▒▓▓██████ ██████▒███                                          
                                       ██ ▒▒▒████   ███▓▓▓▓█████▓▓░ ▓█████████░▒▒▓▒▒▒▒▒▓████ █████▓▓███                                          
                                       ██▓▓▒▒▓███  ███▓▒▒▓▒████▓▓▓▒ ░███████▒█▒░▒▒██████████████████▓▓█                                          
                                       ██▒▒▓▒▓███  ██▓▒▒▒▒█▒▓▓▓▓▓▓▓▒░█████▓▒▒█▓▓▓▓███████▓▓████████▓▓▓█                                          
                                       ██░▓▒▓▓███████████▓▒▓▓▓▓▓█▓▓▓░░██▓▒▒▓███▓▓▓▓▓▓█████▒████████████                                          
                                      ██░▓▒▒█▓███████▓▓▓▓▓▓▓▓▓▓█████▓░███▓▓████▓▓▓▓▓▓██▓█▓█▒███████████                                          
                                      ██▓█▒▓████████▓▓▓▓▓▓▒▓█▓▓██████▓ ▒▒▓▒▒░ ▒███▓▓▓████▓▓█▒██████████                                          
                                      █████████████▓▓▒▒▓▓▒▒▓████████░ ▒█████▓▒  ░▓█████▓██▓▓▓█████████                                           
                                       ███████████▒▒▓▓▓▓▓▓▒▓▓█████▓░▒███████▓▓▓▓░░▓███████▓▓▓▓███████                                            
                                         █████████▓▓▓▓▓▓▓▒▓▓▒▒▒▓██ ░██▓██████▓▓▓▒▒░▒▓██▓▓██▓▓████                                                
                                                ██▓▓▓▓▓▓▒▓▓▓▓▓▒██▓░█████▓▓▓███▓▓▓▓▒▒░░▒▓▓▓█▓▓▓██                                                 
                                               ███▓▓▓▓▓▒▓████▓▒█▓░▒██████▓▓████▓▓▒▓░▒▓▓▓▓▓███▓▓██                                                
                                               ███▓▓▓▓▓▒▒▒▓██▓░▓░▒████████▓▓████▓▒▒▓░▓▓▒░░█████▓█                                                
                                               ███▓▓▓▓▓▒▓▓▓██▓▒░░█▓███████▓▓█████▓▓▓▒▒▒▓▒░░██████                                                
                                              ███▓▓▓▒▒▒▒▓▓▒▓▓█▓░▒▓██████████▓▓▓▒▓▓▓▓▓░▒▓█▒░▒▓▓████                                               
                                              ███▓▓▓▒▒▒░▒▓▓██░░░▓▒▓███████████▓███▒▒█▒▒▓▓▒▒▒░░▓███                                               
                                              ███▓▓▓▓▓███▒░░ ░▒▓▓▒███████████▓▓█▓█▒░▓▒░░▒▓▓▓▓▒  ██                                               
                                           █ ██████▓░   ░░▒▓████▓░▓███████████▓▓██▓▒▓░░  ▓▓███▓ ██                                               
                                             █▒   ░▒▒▒  ░████████▒▓██████▓▓█████▓▓▓▒▓░░░ ░▓▓▓█▓ ███                                              
                                            ███▒░██▓▓▓▒  ████████▒▓██████████▓▓▓██▓░█▒░  ░░▓▓▓▓ ███                                              
                                            ███▓██▓▓▓██░░▓███████ ▒████████████████▒██▓  ░▒█▓▓▓▓███                                              
                                           ██████▓▓▓▓▓█░▒▓██████▓ ░█████████████▓▓▓▒▒██▒░░░▓▓▓▓▓▓█▒                                              
                                           ███▒█▓▓▓▓▓▓▓▒▓███████▒ ░███████████▓▓█▓▓▓▒███▒▒ ▒▓▓▓▓▓██                                              
                                          ██▓▓▓█▓▓▓▓▓▓▒▒▓████████  ███████████████▓█▒████▓▒▓█▓▓▓▓▓██                                             
                                          ██▓▒██▓▓▓▓▓▒▒▒█▓███████▓ █████████████████▒█████▓▓█▓▓▓█▓██                                             
                                          ██▒▓▓▓▓▒▓▓▓░░▓█████████▓ ▓████████████████▓███████▓███▓▓██                                             
                                          ██░▓▓▒▓▓▓▓▓▒░░▓█████████▓▒████████████████████████████▓▓▓██                                            
                                         ██▒▒▓▓▓▓▓▓▓▓▓▓▒░▒▓███████▓ ██████████████████████████▓▓▓▓████                                           
                                         ███▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒███████▓ █████████████████████████▓██▓▓▓███                                           
                                         ████▓▓▓▓▓▓▒▓▓▒▒█▒▓██████▓▒ ▓██████████████████████▓▓██▓▓▓███                                            
                                         ██▓█▓▓▓▓▓▓▓▓▓▒▓█▓▓███████▓ ▓██████████████████████▓▓▓█▓▓▓████                                           
                                        ███▓█▓▓▓▒▓▒▒▓▒░▒▒▒████████▓░██████████████████████▓▓▓▓████████▓                                          
                                       ███▓██▓▓▓▒▒▒▒▓▒░▒██████████▓██████████████████████▓▓▓▓████▓▓███▒                                          
                                        ██▓▓▓▓▓▒▒▒▒▒▓░░▓██████████████████████████████████▓▓▓▓██▓▓▓███                                           
                                       ████▓▓▒▓▓▓▓██▒░░██████████████████████████████████▓▒▒▒▒▓▓██████                                           
                                         ███▓▓▓▓▓▓▓░░▒█████████████████████████████▓▓███▓▓▒▒▒▓▓███████                                           
                                          █████████▒░▓██████████████████████████▓▓▓▓▓████▓▓███████████                                           
                                            ███████████████████████████████████████████████████▓██████                                           
                                           █ ████████████████████                   █    ██████▒▓▒█████                                          
                                           ██████▓██████                                  █████▓▒▒█████                                          
                                           ███████▓█████                                   ████▓▒▓█████                                          
                                          ██████████████                                    █████▓▓████                                          
                                         ███████████████                                    ███▓████████                                         
                                    █  ████▓▓▓▓▓▓▒▒▓████     ██████████████████████████████████▓▒▓▓▓████████                                     
                                     ██████▒▓█▒▓▓▓▒▓▓██████████████████████████████████████████▒▓▓▒▓▓▓▓████                                      
                                █   ██▓▒▓████▓▒█████████████████████████████████████████████████▓▓▓▒█▓██████                                     
                                  ██▒█▓█▓▓██▒▒▓ ▒▓██████████████████████████████████████████████▒██▓████▓▓▓█████                                 
                                ███████▓████▓▓█ ░▓▓▓███████████████████████████████████████████▓▓██▓▓█▓▓▓██████                                  
                                 █████████████████████████████████████             ██████████████████████████                                    
                                        ████████████                                            ████                                             ");
                                                     break;
            case "Orc":
            Console.WriteLine(@"
                                                                                                                                       
                                                                                                                                       
                                                                                                                                       
                                                                                                                                       
                                                                                                                                       
                                                      ██                                                                               
                                              ▒▒████▓▒░░░▓▒                                                                            
                                         ▓▓▒▒▒▒▒▓███▓░░░░░▒▓█▓▓                                                                        
                                    ████▒░░░░░░░▒▒▓█▓▒▒░░░▒▒▒░░░▓█                                                                     
                                  █████▒░░░░░░░░▒▒▒▓▒▓█░░░▒▒▒▒░░░▒▓█▓▓▓▒░░                                                             
                                 █▓▓█▓▓▒░▒░░░░░▒▒▒▒▒▒▓▓▒░▒▒▒▓█▓▓▓▒░░░░░░░░░░                                                           
                               ██▓▓███▒▒░▒▒▒░░░░░░░░▒▓▓▓▒▒▒▒░░░░░░░▒▒▒▒▒▓▒░░▒▒                                                         
                           ██▓▓▓▓▓███▓░░░░░▒▒░░░░░░░▒▒▓▒▒▓▒░░░▓█░░░░░░░░░▒▒░░▒                                                         
                          █░░░▒▓▓████▒░░░░░▒▒▒▒░░░██░▓▓░░▒████▓░░░░░░░░░░░▒░░░▒                                                        
                         █░░░░▒▒▓████▒░░▒▒▒▓░▒▓████▒▒█▓░░░░▓█▒▒░░░░░░░░░░░░░░░██                                                       
                        █░░░░░▒▓██████▓▓▓█▓▓░░░▒▒▒░░▓██▒▒▓███▓██▒░░░░░░░░░░▒░▓▓▓██                                                     
                       ██▓▒░▒▓▓▓████████▓▒ ░░░▓▓▒░  ░█▒▒▓███░░▒▒▒░░░░░░░░░▒██▓▒▒▒██                                                    
                       █▓▒▒▒▓███████████▓▓▓▓█▓▓▒░░░▒█▒░░▒██▓▒░░░░░░░░░░▒▓▓▒▒▒░░░░▒█                                                    
                     ░░▓▒░░░▓▓▓█▓▓████████▓▓▒░░░▒███▓▒▒▒███▒░░░░░░░░░░▒▒▒▒▒▒░░░░▒▒██                                                   
                    ░░░▒░▒░▒▓▓▓▒▒▒▒▒█████████▒▓████▓▒░░▓██▒░░░░░░░░░░▒░░░░░░░▒▒░░▒██                                                   
                    ░░░▒░░░▒▒░░░░▒▒░░▒████████████▓▒▒░▓██▒░░▒░░░░░░░░▒▒▒▒▒░░░▒▓██▒▒▒▓                                                  
                    ░░░░░░░░░░▒░░▒▒░▒▒████▓▓▒▓▓░░░░░░▒██▓▒░▒▓░░░▒░░▒▒▒░░░░░░▒▒▒▓█░░░▓▓                                                 
                    ▒░░░░░░░░░░░░░▒░░▓███████▓▒░░░▒▒▓███▓▒▒▒█▓▓█▒▒▒▒▒█▓░░░░░▒▒░░▒▒▒▓▓▓█                                                
                    ▒▒▓▒░░░░░░▒░░▒▒▒▒███▓██████▓▓▒▒▓▓▒██▓▒▒▒▓██▓▒▒▓██▓▒░▒▒░░▒▒▒▒░░▒▓▓▒██                                               
                      ██▒░░░░░░▒▒▒▒▓██▓▒░░░░▒██▒ ░▓███▓▓▓▒░░░▒▓▓▓▓▓▓█▓▓▓▓░░░░▒▒▒▒▒░▒▓▓██                                               
                     ██▓▓▒▒▒▒▓▓▓▓▓████▒▒▒▒░░▒▒▓ ▒█▓▓▓▓██▓▒▒▒▒▒▓█████████▓▒░░░░░░▒▒▒▓█████                                              
                     ▓▓▒░░░░░░░▒▓▓▓██▓▓▓▒▒▒▒▒▒▓▒▓█▓▒░▒█▓▓▓▒▒▓█████████████▒▒░░░░▒▒▓██▓▓▓▓█                                             
                    ▒▒▓▒░░░░░░░▒▒▓▓████▓▓████▓██▒▓▓▒▒▓▒▒█████▓▓▓▓██████████▓▓▒▓▒░▒▒▒▒▒▓▒▒▓█                                            
                    ▒▒▓▓░░░░░░▓▒▒▓██████████▓▓▓▓██████▓█████▓▒▒▒▒▒▓▓▓██████████▓░░░▒▒▒▓▒░▒█                                            
                    ▒▒▓█▓▒▒▒▓██▓▓█████████▓▒▓▓███▓▓▒▒▒░░░▒▒███████████████   ██▓▒░░▒▒▒▒▓▒░▓█                                           
                    ▒▓█░░░░░▒▒▓▓▒▓███████▓▓▓████▒▓▒▒▒▒░░░░░▒▒▓████████████    ██▓▒▒░░▒▒▒▓▒▒█                                           
                    ▓█▒░░░░░░░▒▒░░▓███ █████████▓▒▓▓▓▓▓▓▓▓▓▓▓▓▓████████████     █▓▓▒░░▒▒▒▓▒▓                                           
                    ▓▒▒▒▒░░▒░░░░░▒███    ████████▓▓▓▓▓▓██████████████████████    ███▓░░▒▓█▓█                                           
                    ▓▒░▒▒░░░▒▒▒░░████   █████████████████████▓▓▓▓████████████     ████░░▒▓▒██                                          
                    █▓░▒▒░░▒▒▒▓▒▒████  ████████▓▓▓▓▓▓▓▓▓▓▓▓██████████████▓▓██████████▓▒░░▒▒▒▓                                          
                    ████▒░░░░▒▓▓▓██   ███████████████████████████████▓▓██████████████▓▒░░▓█▒▒██                                        
                    █▒▓▓░░░░▒▒█████  ██▓▓▓██▓▓▓██████████▓██▓████▓▓▓█▒▓▓███▓▓███  ███▓░░▒▓██▓▓█                                        
                    ▓░░░░░░▒▒▓█████ ██▓▓▓███▓▓▓▓█▓▓▓█▓██▓▓▓▓▓▓▓██▓▓▓█▓▓▓▓█▓█▓▓██   ██▓▓▓████████                                       
                    ▓░░░░░░▒▒▒▒▓███ █▓▒▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▒▓▒▓▓▓▒█▓███▓▓▓█▒▓▓██▓▓███   ██░▓███▒▒▒▒██████                                   
                    █▒░░█▓▒░░▒▒▓▓▓███▒▓▓▓▓█▓▓▓▓▒█▒▓▓▓▒░▒▒▒▓▓▒▒▓▓██▓▓▓██▒▓▓▓█████   █  ██▒▓▓████████████                                
                     ░▒▓█░░░▒░░░▒▓██▓▒▓█▓██▒▓█▓▒█▓▒▓▓▒░▒▒░▓▓▒░▒▓▓█▓▓▓▓█▓▒▓▓█████       █████▓██████████████                            
                     █▓▓▒░░░▓▒░░▒▓██▓▒▓█▓▒█▒▓█▓▒██▓▓▓▒░▒▒░▒█▓░▒███▓▓▓▓██▒▒▓▓████          █▓▓▓▓▓▓████████████████                      
                      █▓▒░░░▒█▓▒▓▓██▓██▓▒░▓▓▓█▓░▒█▓▓█▒░▒▒▒▒██▒░▓███▓▓▓███▓██▓▓▓█          ▓▒▒▒▓▓▓▓▓▓▓▓▓████████████████                
                       ▓▒▒░░▒▓█▓▓███████▓▒▓████▒░▒███▓▒▒▓▒▓███▓▓███████▓▓▓▓▓▓▓▓█         █░░▒▒▒░░▒▒▒▒▒▒▒▒▓▓▓█████████████████          
                       █▒▒░░░▒▓████████████████████████████████▓▓▒▒░░▒█▒░░░░░▒▓█         █▒    ░▒░░░▒▒░▒▒▓▒▓▓▓▓▓▓██████████████        
                       ██▒░░░▒▒▒▒███▓███▓▓▓█████▒▓████▓███████▓▓▒░░░░░░░░░░░░░▒▓█             ▒   ░▒▒░▒▒░░▒▒▒░▒▒▓▓▓▓▓▓██████████       
                       ██░▒░░▒▒░░░██▓▓▓▓▒▒▒▓▓█▓░▒▒▒░░░░▓▓▓████▓▓▒░░▒░░░░░░░░░░▒▓█                ▓░▒  ░  ▒▒▒▒▒▒░░▒▒▓▒▒▓▓▓▓▓▓▒███       
                     ███▓░▒▒░▓▒▒░░▓█▓▓▓▒▒▒▒▒▓█▓░░▒▒░░░░▒▒▒█████▓▒░░░░░░░░░░░░▒▓▓██                    ██    ░▓▓▒▓▒▒▒▒░░▒▓▓▓▒▓██        
                     ██▓▒░░░░░░▒░░▓█▓▓█▒▒▒▒▒▓█▓░░▒▒░░░▒▒░░▓█████▓▓▒░░░░░▒▒▒░▒▓▓▓██                        ░░    ░▒▓▓▒▓▒▒▒░░▒██         
                      ▓█▒░▓█▒░░▓░░▓▓▓▓▓▒▒▓▓████▒░▒▒░░░▒▒░▒██  ██████▓▓▒░░░▒▓▓▓▓███                            █▓▓▒█░ ▒▓▓▓▓▒██          
                      █░░░▒▓█▓▒▓▓██▓▒▓▒▒▒▒▒▓███▓░░▒░▒░░▒░░▓█ ████▒░█▓ ░░░░░▒▒░▒██                                 ██▓░   ▒██           
                       ░▒░░▒▓░░░░███▓▓██▓▓▓█████▓░░░░░▒▒░▒██ ████▒░▒▓░░░░░░░░░▒███                                     ▓▒█             
                       ██▓░░▓██▓██▒▒▒▒▒▓▓▓███████▒░░░▒▒░▓███  ████▒▒▓▓▒▒▒░▓▓▒█████                                                     
                        ███▓▓████▓██▓▓█▓▓▓▓███  █▒░░░▒░▒▓███   ████████████████▓██                                                     
                             ██▓▓▒░▒▒▒░▒▓███    █░░░░░░▒▓▓██   ███▒░▒▒▒▒▒▒▒▒░░▒▓▓█                                                     
                             ██▓▓█▓▓▓▓██████    █▒░░░░░░▒▒██   ███▓▒▓▓▓▒▒▒▒▒▒▓▒▒▓█                                                     
                             █▓▒░░▒██▒▒█         ▒░░░░░░░▒▓██   ██████████▓▒░░▒▓███                                                    
                          ██▓▓▓▒▒▓▓▓▓██         █▓░░░░░░░░▒▓███   ██████▓▓▓████▓▓██                                                    
                     ███████▒▒▓▓███▓█████   █████▓░░░▒░░░░░▒█████████████▓▒▓▒░░░█████                                                  
                    ██████▒░▒░░░░▒▒▒██████████████▒░░▓▒░░░░░▒█████████▒▒▒▒▒▒▒▓▓▒▒▒▒███████                                             
                       █████▒▒▓▒▒░▒████████████████░░▒█▒░░░░░▓█████████▓▓▓▓▓▒▒▓██▓▓██████████                                          
                            ████████████████████████▒░▒▓█▒░▒▒▓▓██████▒▒█▒▒░░░░░▒▒▓▓▓███████████████                                    
                                ███████████████████████▓▓████████████▓█▓▒░░░░░░░░▒▒▒▒▓███████████████████                              
                                            █████████████▒▓████████████▒▒░░▓▓░░░▓▒▒▓░▒██████  ████████████                             
                                                  █████████████████████▓▒░▒▓▒░▒▒▒▓▓█████              ███                              
                                                                  ███████▓▓████████                                                    
                                                                                                                                       ");
                                         break;
            case "Night Lurch":
            Console.WriteLine(@"
                                                                                                                                                 
                                                                                                                                                 
                                                                                                                                                 
                                                                                                                                                 
                                                                                   █                                                             
                                                                                 ███                                                             
                                                                                ████                                                             
                                                                                ████                                                             
                                                                               █████                                                             
                                                                              ██████                      ███                                    
                                                                              █████                   ████                                       
                                                                        █     ████                  ████                                         
                                                                   ███▓▓▒▒▓██████▓                █████                                          
                                                      ███████    ██▓▒▒▒▒▒▒▒▒▒▒▓█████            ██████                                           
                                                   ██▓▒▒▒▓████████▓▒▒▒▒▒▒▒▒▒▒▒▒▓█████         ███▒███                                            
                                                 ██▓▒▒░▓▓████████▓▓▒▒▒▒░░░░▒▒▒▓██████        ███▒███                                             
                                                █▓▓▓▓█▓██████████▓▓▓▒▒░░░░▒▒▓▓▓███▓██    ██████▒███                                              
                                              ██▓▒░▒▓█████████▓█████▓▓▓▓▓▓▓█████▓█████████████████                                               
                            ███▓█████     ██ ██▓▒░░▓▓██████████▓▒▒▓███████████▓▓████▓▓▓▓▓████▓▓▓████                                             
                          ███▓▓▒▓██▒███  █  ██▓▒░▒▓█████████████▓▒▓█████████▓▒███████████████▒▓▓██████                                           
                         ███▒▒▒░▒██▒▒▓███████▒░░▒▓████████████████▓▒▒▒▒▓▓▒▒▒▓████▒▓████▓▓▓███▓██████▓████                                        
                         ████▓▓▓█████▒░▒▓██▒░░▒▓█████  █ █████▓▒▒▒▓█████████▓▒▒▒▒▒▓██▓▓▓▓▓██▓▓█▓▓▓▓█▓▓▓▓███                                      
                         ███▓▓█████████▓▒▒░▒▓██████       ██████▓██▒█▒▒▒▒▓█▒█████████▓▓▒▓██▓▒▓▒▒▒▒▒▒▓▒▒▓▓█████████                               
                        ██▓▓████████████▒░░▓████           ████▓▒█▒█████████▓██▓▒█████▓▓███▒█▓▒▒▒▒▒▒▒▒▒▓▓█████▓▒▒▒▓██                            
                       ██████████████████▒▓████              ███▒██▓▓█▒█▒▓▒▒▒██▒▓███▓▓█████▒▓▒▒▒▒▒▒▒▒▒▒▒▓████████▒▒▒█                            
                       ██▒▒▓███████████▓▒▓▓██                ███▓▓█████████████▒██▓▓▓▓███▓▒▒▒▓▒▒▒▒▒▒▒▒▒▒▓▓████  █████                            
                       ██▓███████████▒▒░▒███                  ████████████████▓█▓▓▓▓▓▒▒▒▒▒░▒▒▓▓▒▒▒▒▒▒▒▒▒▒▓██                                     
                      █████████████████▓██               ██████████▒████████▒█▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▓▓▒▒▒▒▒▒▒▒▓███                                     
                      ██▓▓███████████▓▒▓██            ██▓▒▒▒▒▒▓███▓██▓▒▒▒▓▓██▓▓▒▒░░░▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▓███                                      
                      ██▓███████████▓▒▓███            ██████████████▒█▓▒▒█▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓███▓▓▒▒▒▒▒▓████       █  █████████████               
                      █▓▓██████████▓▓███               ████   █████████▓▓█████████▓▓▓▓▒▓▓███████▓▓▒▒▒▒▓███████████████▓▓▓▓▓▓▓▓████████           
                      ███████████▓▒████                          ███████▓▒▒▓▓████▓▓█▓███████████▓▓▒▒▒▓█████▓█▓▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒███████       
                      ██▓███████▓▓████                         ████████▓▒▒▓███▓█▓▓▓▓▓▒▒▒▒▒█████▒▒▒▒▒▓▒▓███▓▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▒▒▓▓████████     
                      ████████▓███████                      ████████▒████▒▒▒▓▓▓▓██▓▓▒▒▒▓█████▓▒▒▒▒▒▓▓▒▒▒██▓▓▒▒▒▒▒▒▒▒▒▒▒░▒░░░░░░▒▒▒▒▓▓▒▒█████     
                      ██████████ █████         █     ████████████▒▓▒▒▒████████████████▓▓▓▓███▒▒▒▒▒▒▓▓▒▒▓███▓▒▒░░░░░░▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒▒▓████    
                       █████      █████         ███████████▓▒▒▒▒▒▒▓▒▓▒▒▒██████▓█▓████████████▒▒▒▒▒▒▓██▓███▓▒▒░░░░░░▒▒▒▒▒░░░░▒▒░▒▓▓▓▒▒▒▒▒▓████    
                       ████         ██   ██████▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▓▓███▒▒▓████████████▓██████▒▒▒▒▒▒▓█████▓▒▒▒▒░░░▒▒▒▓▒▓▒▒▓▓▓▓▓▓▓▓▒▒░░▒▒▒▓███     
                       ████        █ ███████▓▓▓▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓███▓▒░▓█▓▓▓█████▓▓████▒█▒▒▒▒▒▓▓████▓▓▓▓▓▓▓▓▓▓████▓███▓▓▓▓▓▓▒▒▒▒▒▒▒█████     
                        ██            ███████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▓██████░▒▒▓▓██████████▓▓▒█▒▒▒▒▓▓████▓▒▒▒▒▒▓███████████▓▒▓▓██▓▒▒▒▒▒▓▓████      
                         █      ██████▒▒▒▓█▓████▓▒▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓█▒░░▓▓██▓░░░▒▓▓▓▓███▓▓▓▓░░█▓▓▓▓▓█████▓█▓▓▓████████████▓▒▒▒▓███▓▒▒▒▓██████      
                            █████████▒▒░▒▒▓█████▒▒▒▒▒▒▒▒▒▒▓▒▒▒▒▒▒▒▒▒▓▓██████▓▒▒▓▓████▓▒▒░░▒░██▓▓▓██▓▓████████████ █   ██▓▒▒▒▒██▓▒▒▓▓██████       
                          ██▓▒░░▒▓▓▓▒▒▒▒▒▒▒███▓▓▒▒▒▒▒███▒▒▒▒▒▒▒▒▓████████████▓▓██▒█████▓░░░░█▒▒▒▓▓▓▒▒████████        ██▓▒▒▒▒▒▓█▓▓▒▒██████        
                        ███▒░░░▒▒▒▒▒▒▒▒▒▓█████████████▓▒▒▓▓█████████▓▓    ███████▓▓▓▓▓█▓▒▒▓██▒▒▒▒▓▓▓▒██████          ██▓▒▒▒▒▒▓█▓▒▒▓██████        
                        ███▒░▒░▒▓▒▒▒██▓█████████████████████████           ██████▓▓▓▒▒███████▒▒▒▓███████             ██▓▒▒▒▓▓▓▓▒▒███████         
                       ██▓▓▓▒▓▒▒▓▒▒███████████                             █████▓▒▒▒█████████▓▓▓███████              ██▓▓▓█▓▒▓▓████████          
                       ██▓▓▓▓▓▒▒▓██▓██▓██████                        ▒██████████▓▒▒▒██   ██▓▓█▓▓▓▓▓████             ███▓▓▒▒▒██████████           
                   █ ███▒▓▓▓▓▒▓██▓▒▒▒████                          ██████████▓▓▓▓██     ██▒▒▒▓▓▒▒▓▓███         ███████▓▓▒▒████████               
                     █▓▒▒▒▒▒▓██▓▓▒▓██████                            ████████▓          █▓▒▒▒▓▒▒▒█████       ███████▓▓▓▒▒▓█████                  
                 █████▒▒▒▒█████████████                                                ██▒▒▒▓▓▒▒▓███        ██▓▒▒█▓▒▓▒▒▒█████                    
               ██████▒▒▒████████████                                                   ██▒▒▓▒▒▒▓▓███         █▓▒▒▒▒▒▒▒▒▓█████                    
             ██████▓▒▒███████████                                                   █████▓█▒▒▒▓█▓██          ██▓▓▒▒▒▒▒▓█████                     
            █████▓▒▒██████████                                       ████████████████████▓▓▒▒▓█▒▒██           ███▓▓▓▒▒▓██████                    
         ████▓▒▒▒▓███████████                                      ████████████████████▓▒▒▒▒▓██▓█████████      ████▓▒▒▓█▓████                    
          ██▒▒▒▓▓██████████                                      ██████████████████████▒▒▒▒███████████████     ███▓▒▒▓▓▓▓█████                   
        ███▒▒▒▓▓▓███████                                   ██████████████████████████▓▒▒▒▒▓██████████████████   ██▓▒▒▓█▓█▓████                   
       ████▒▓▒█▓███████                           ███████████████████████████████████▒▒▒▒▓█████████████████████████▓▒▓▓▓████████                 
      ████▒█▒▓█▓█████                ███████████████████████████████████████████████▓▒▒▒████████████████████████████▒▓█▓▓██▓███████              
    ███▓██▓▒▒▓█████████████████████████████████████████████████████████████████  ███▒▒▒▓████   ████████████████████▓▓▓██▓███████████             
 █████▓████████████████████████████████████████████████████████████████         ████▒▒▒▓▓███       █████████████████▓████████▓▒█████             
█ ███▓█▒▒▓▒▒█▒▒▒▓█████████████████████████████████████████████           ██████████▓▒▓▒▓███            ████████████▒▒▓███▓▒▓███████              
█████████████████████████                                            ████▓▒▓▓████▓▓█▓▓▒███                  ███████▓▒▒▒███████████               
  █ ███████████████                                               ████▒▒█████▒▒▒▒██▓████████                    ██████████████                   
                                                               █████████████▓▓▒▓██▓▓▓████████                       ███                          
                                                              ████████████▓▒█████▓▓███████████                                                   
                                                              ███████████▓▒███████▒▓███████████                                                  
                                                               █     ███▓▓▓▓██████▓████████████                                                  
                                                                    ███▓▓████████▓▓▓▓███████████                                                 
                                                                    █████████ ██████████    ████                                                 
                                                                    ███████   █████████      ████                                                
                                                                    ██████   █████████         █                                                 
                                                                    █████   ██████████                                                           
                                                                    ███    █████████                                                             ");
                                                                                                                                       break;
            case "Dark Priest":
            Console.WriteLine(@"
                                                                                                                                       
                                                                                                                                       
                                                                                                                                       
                                                 █████████████                                                                         
                                                ██▓▓▓▓▓▓▓▓▓▓▓████████████████                                                          
                                                  ██████████████▓▓▓▓▓▓▓▓██████████                                                     
                                                  ██████████████████████████████████                                                   
                                                  █████████████████████████████████                                                    
                                                  ████████████████████████████                                                         
                                                   ██████▓█▓▓▓████▓███████████                                                         
                                                   █▓▓█▓▓▓▓▓▓▓▓██▓▓▓██████████                                                         
                                                   █▓▓█▓▓▓▓▓▓▓▓██▓▓▓▓█████████                                                         
                                                   █▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓███████████                                                       
                                                   █▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓█████████████                                                      
                                                   █▓▓▓▓▓▓▓█▓▓▓▓█▓▓▓███▒▒▒███████                                                      
                                                   █▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓█████▓▓█████                                                       
                                                   █▓███▓▓██▓▓▓▓▓▓▓▓█████▓▓█████                                                       
                                                   █▓███▓▓███▓▓██▓▓▓██▓▒▒▒▓▓████                                                       
                                                   ██████▓███▓███▓▓███▓▒▒▓▓▓███                                                        
                                                   ███████████████████████████                                                         
                                                         ████████▓▓▓▒░█████████                                                        
                                                            █▓▓██░░  ███████████                                                       
                                                        █████▒▒▓███████▓▓▓▓█████████                                                   
                                                      ███████▒░░░░░░░░▒▒▒▓████████████                                                 
                                                     ██████▓░░▒▒▓▓█████████████████▓████                                               
                                                  █████████░▒░░░░▒▓▓▓▓▒▒▒▓███████▓▓▓▓████                                              
                                                  ████████▓▒▒▒░░░░░▒▒░░░▓████████▓▓▓█████                                              
                                                 █████████▒▒▒▒▒▒▒▒▒░░▒░░▓████████▓▓███████                                             
              ███████████                        █████████░▒▒▒▒▒▒▒▒▒▒▒░▓█████████▓▓████████                                            
            ██▓▒░░░░ ░▒███                      ██▓███████▒░▓▒▒▒▒▒▒▓▒░▒███████████▓█████████                                           
            █▒▒▒░░▒░░░░░░▓██                  ████▓████████▓░▒▒▓▒▒░░░▓█████████████▓▓█████████                                         
            █▓▓░░▓▒░░░▒▒░ ▓█                 ████▓▓███▓██████▒▒▒▒▒█████████████████▓▓█████████                                         
            ██▓░░▓▒░▓███▓░░██              ████▓▓▓████▓████████████████████████████▓▓██████████                                        
        ██████▓░▓▓░▒██████▓▓██              █▓▓███████▓████████████████████████████▓▓▓██████████                                       
       ████ ██▓░█▓░░░▒▓▓████ ███      ███████▓▓███████▓▓██████████▓█████████████████▓███████████                                       
       ███████████░░░░██████░ ███ █    █████▓▓▓▓▓████████▓▓████████▓████████████████████████████                                       
       ████     ▒        ▒██  ░██████████▓██▓▓█▓██████████▓▓██▓████▓████████████████▓▓████████████                                     
       ██       ▒  ░░░    ▒▓▓░░▓█████▓▓▓▓▓▓▓▓▓████████▓████▓▓█▓▓███▓█████████████████▓█████████████                                    
       █░    ░▒░   ▒░       █░▒░░▓████▓▓▓▓▓▓▓██████████████▓▓▓▓████▓██████████████████████████████                                     
      ██  ░░░▒░   ░▓        █▒▒░ ░▒▓██████▓▓▓██████████████████████████████████████▓▓▓▓▓▓█▓▓▓██████                                    
      █▓      █░  ███▒      █▓░░░ ░▒▓▓█████▓███████████████████████████████████████████▓███▓████████                                   
       █░     ▒█░▒▓█▓░      ██▒░▒░▓▒░▒█▓█████████████████████████████████████████████▓███▓▓▓▓▓███████                                  
       ██     █░░░░▓▒░     ████▒▒█░░ ▒▒█▓█████████████████████████████████████████████▓▓▓▓▓▓█████████                                  
       ███   ░▓░░  ░░     ██████ ░▒▒▒▒░▓█████████████▓██████▓▓▒▓████████████▓▒▒▒▒░░███████▓▓█████████                                  
        ████▓▒██████▓▓▓██████████ ░▓▓░▒▒█████████████░░░▓▓▒░░▒░▒▒░░░░▒▒▒▓▓▓▒▒░▒▓▓▒▒██▓▓▓▓▓███████████                                  
         ████▓▒▒▒█▓░ ▒██░██ █ ███▓░░▓█▓▓▓███████████████▓░▒███▒▓▓▒█████▒▒▒██▓▓▒▒░▒▒████▓██████████████                                 
          ██▒    █▓    ▒ ██  █████▓██▓███████████████▒▓▓▒▓██▓▓██▒▒███████▓░▓█▓▒▒▒▒▒██████▓▓▓█▓████████                                 
          ██▒    ▓░    ░ ██  ██████▓▓▓██████████████▒▒▓░░█▓▓▒▒▓▒▒▒█▓█▓▓▓██▓▓█▓▓▒▒▒▒▓███▓▓▓▓▓▓█████████                                 
          ███░░░░██░░░█▒░██  ████▓██████████████████▓██▒▓█▓▒▒▒▓█▓▓█▓██▓▓▓█▓░██▓▓▓▓▓█████▓▓▓▓███████████                                
           █████░░░████▒████ █ ██▓███████████████████▓▒░▓██▓▓▓██░▒██▓███▓▒█▒▒█▓▓▓▓▓▓▓█▓▓▓▓▓████████████                                
           █████▓▓████████ █ █ ██▓██████████████████▓▓▒▓██▓▒▒▒▓▓░▒██▒█▓▓▒▒▓▒░▓█▓▒▓▓███▓▓▓▓█████████████                                
              ████████     █    █▓▓███████████████████░▒▓███████▓▒▓█▓██████▒░▒████████▓▓▓▓█████████████                                
            █              █    ██▓████████████████████▓████████▓░▒▓▒███████▓▓█████████▓▓▓▓████████████                                
                                ███████████████████████▒▒████████▓▓█████████░▒█████████▓▓▓▓▓███████████                                
                              ██████████████████████████▒████████▒░▒███████▓▒███████████▓▓▓▓█████████████                              
                              ██ ███████████████████████▒▒▓███████▒▒███████░░▓█████████▓▓▓▓▓▓████████████                              
                              ███████████████████████████▓▒▓████▒▓█▒░▓████▒▓▓██████████▓▓▓▓▓▓▓███████████                              
                               ████████████████████████████▒▒▒▓▒▒███▓▒▓░▒█▒▓███████████▓▓▓▓▓▓▓███████████                              
                                ████████████████████████████████████████████████████████▓▓▓▓▓▓▓██████████                              
                                ████████████████████████████████████████████████████████▓▓▓▓▓▓▓██████████                              
                                 ████████████████████████████████████████████████████████▓▓▓▓▓▓██████████                              
                                     █████████ ███████████████████████████████████████████▓▓▓████████████                              
                                       ██████  ███████████████████████████████████████████████▓██████████                              
                                               ███████████████████████████████████████████████▓▒▒▒█████ █                              
                                              ████████████████████████████████████████████████▓░▓▒▒████ █                              
                                              █████████████████████████████████████████████████▓▒▒▒████ █                              
                                              █████████████████████████████████████████████████░ ▒████ █                               
                                              █████████████████████████████████████████████████▒ ░▓████                                
                                              █████████████████████████████████████████████████▒▒▓█████                                
                                              ████████████████████▓████████████████████████████░░▓█████                                
                                              █████████████████████████████████████████████████░░▓▓▓███                                
                                              ████████████████████████████████████████████████  ░▓▓▓▓▓█                                
                                             █████████████████████████████████████████████████  ░ ░▒▓██                                
                                             █████████████████████████████████████████████████ ░  ░▒███                                
                                             ████████████████████████████████████████████████░░▓█░▒▓██                                 
                                              ████████████████████████████████████████████████▓██▒▓██                                  
                                             ███████████████████████████████████████████████████ ▓███                                  
                                             ███████████████████████████████████████████████████                                       
                                             ███████████████████████████████████████████████████                                       
                                             ███████████████████████████████████████████████████                                       
                                             ███████████████████████████████████████████████████                                       
                                             ████████████████████████████████████████████████████                                      
                                            █████████████████████████████████████████████████████                                      
                                            ██████████████████████████████████████████████████████                                     
                                            ██████████████████████████████████████████████████████                                     
                                            ██████████████████████████████████████████████████████                                     
                                            ███████████████████████████████████████████████████████                                    
                                            ███████████████████████████████████████████████████████                                    
                                             ██████████████████████████████████████████████████████                                    
                                            ███████████████████████████████████████████████████████                                    
                                            █████████████████████████████████████████████████▓▓▓▓██                                    
                                             ████████████████████████████████████████████▓▓░▒▓▓▒▒▒██                                   
                                             █▓▒▓██████████████████████████████████████▓░░░░░▒▓▓▒▒██                                   
                                             ██▒▓▓░▒▒▓████████████████████████████░░░░░░░░░░░░░▓▓▒██                                   
                                             ██▓▓▒░░░░░░░░░░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓▒▒█                                   
                                             ██▓▓▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓███                                   
                                           ██ ██▓▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▓████                                    
                                              ██▓█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▓████                                      
                                            ██ █▓▓███░░░░░░░░░░░░░░░░░░░░▒░░░░░░░▒▒▓███████▓▓███                                       
                                               █▓████████▓░░░░░░░░░▒▒░░░░░▒██████████████▒▒▒▒▒███                                      
                                            ███▓▒▓▒▒▒▒███████████████████████████████████░▒▒░░███                                      
                                          ███▒▒▒▓█▒░░░▓██████████████████████████████████▒▒░░░░░██                                     
                                   ████████▓▒░░░░▓▓▒▒▒░▓█████████████████████████████████░░░░░░░░██                                    
                             ████████████▓▓░░░░░░▒▒▓▒▒▒█████████████████████████████████▓░▓██▓██████████                               
                            ██████████▒▒░░░░░░░░░▒▒████████████████████████████████████░░░▓██▒░░░▒▓███████                             
                            ████░░░░░░░░░░▒███████████████████████████████████████████▓░░░██░░░░░░▒███████                             
                            █████▓░░▒██████████████████████████████████████████████████▒░░▒▓░░▒███████████                             
                             ████████████████████████████████████████████████████████████████████████████                              
                                            ████████████████████████████████████████████████████████                                   
                                                                                                                                       
                                                                                                                                       
                                                                                                                                       ");
                                              break;
            case "Crow Mauler":
            Console.WriteLine(@"
                                                                                                                                       
                                                                                                                                       
                                                                                                                                       
                                                                                                                                       
                                                                                                                                       
                                                       ██████████                                                                      
                          ███████████████            ███████████████                                                                   
                          ██▓███████▓▓▓▓███████████  ████████████████                                                                  
                            ███▓▒▓████████▒▓████████████████████████████                                                               
                                 ███▓▓████████▓▒▓████████████████████████                                                              
                                     ███▓█████████▓▓▓▓▓██████░ ░░▓████████                                                             
                                         ███▓█████████████████▓▒▒███████████                                                           
                                            ███▓████████████████████████                                                               
                                              ███████████████████████████                                                              
                                      █        █████████▒█████████████████                                                             
                                █             ██▓██████▓███████████████████                                                            
                                             ██▓██████▓█████████████████                                                               
                                            ██▓█████▓▓███████████████████                                                              
                                           ██▓█████▒██████████████████████                                                             
                                          ██▓████▓█████████████████████████                                                            
                                         █▓████▓█████ ▓▓█████████████████████                                                          
                                        ▓▓███▓████   ▒░▒███████████████████▒▒▓██                                                       
                                      ████▓███     ░░ ░░██████████████████▒▒░▒▒███                                                     
                                     ██▒▓███ █  ▒▓▓▒░░▒█████████████████▓▓░░░░▒▒██                                                     
                                    █████  ██▒░░░░░▒▒▒███████████████████▓░░░▒█▒▓▓████                                                 
                                   ███    ██░░░░░░░▓▓▓███████████████▓░░▒▓▒▒▒▓▒▒▒▓▒▒▒███                                               
                                          ▒▒▒░░░░░▒▒░░░░░░▒▒▒▒▒▒▒▓▓▓█▒░░░▒▒▒▒░░░░░█▒ ░███                                              
                                         ██▒░░░░░░░░░▒▒▒░░▒█▓▒▒░░░▒░▒▓▒░░▒▒▓░░░░░░▓█▓▒▒▓█                                              
                                         █▓░░░▒▒░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▓██▒░░░░░░▓█▒▒██                                             
                                         ██▒▒▒█▓▒▒▒░▒░░░░░░░░░░░░░░░░▒▒▒▓▓▓▓██▓▒░░░░▓▒░░░▒                                             
                                         ██▒▓██▒░░░▒▒▓▒░░░▒░░░░░░░░▒▒▒▒▒▓▓▓▓▓▒▒▒░▒░░▒▒▒░▒▓                                             
                                         █░ ░█▓▒░░░░░▒▒▒▓░░░░░░░░▒▒▒▒▓▓████████▒▒▒▒▒▒█▓████                                            
                                         ░░░░██▓▒░░░░░░░░░░░░░░░░░▒▒██▓▒▒▓▓██████▓▓▓▓▒░▒▒▒█                                            
                                        █░░░░███▒▒▒░░░░░░░░░▒▒▒▒▒░░▒██▒░▒▓▓█████▓▒▒▒▓▒░░░░▒███                                         
                                        █░░░█▓████▓▓▒░░░░▒▒▓▒░░░▒▒░░▒█▓▓████████▓░░░░▒░░░▒█                                            
                                        █▒▒▒▓▒▓█▒▒░░░░░░▒▒▓██▒▓▓▒▒░░▒▒▓▓▓████████░░░░░░▒▒░░▒                                           
                                        ▓▓▒▒▒▒█▓▒░░░░░░░░▒▒▓██▓█▓▓▒▒▒▒▒▒█████   █▓░░░░░▒█▒░░█                                          
                                      ██▒▒▓█▒▒█▓▓░░▓▒▒░░░▒▓▓▓▒▒▒▒█▓▒░░▒▓███▓▓   ██▒▒░░░░░█▓▒▒██                                        
                                   █ ███▒░▒▓▒▒█▓▒░▒▒░░░▒░░▒▓▒▓▓▒▒▒▓▒▒▒███        ██▒▒▒▒▒▒▓██▓▓██                                       
                                      ██▓▒▓▓▒▒▓░░░▒▒░░░▒░░▒▒▒▒░░░▒▒▓████         ███▒▒▒▒░░▒█████                                       
                                      █▓▒███▒▒▒░░░▒░░░░░▒▒▒░▒░░░░▒▓▓████           ██████▓▒█▓▓███                                      
                                    ██▒░░░▓▒▒▓▒░░░▒░░░░░▒▒▒▒▒█▓▒▒▒▓██████           ███▒░██▓▓▓▓███                                     
                                  ███▒▒░░░▒░▓▓▒░░░█░░░░▒▒▒░▓██▓▒▒███████             ██▓██████████                                     
                                 ████▓█▒░▒▓▒▓███▓█▓░░░░▒▒▓░░▒▒▓▒▒▒▓█████               ████████████                                    
                                 █▒░░░▒▓░▓█▓███▓░▒▒▓▒▒▒▒▓█▒▒██░░▒███▓▓█████             ████████████                                   
                                 ▓░░░░░░▓██▓██▓░░░▒░░░░▒█▒▒▒▒▒▒▓███▓▓▓█████              ██████████████                                
                                ▓▒ ░░░░▓███████░░░▒░░░░▒▒▒░░▓█████▓█▓▓█████               ████████▓███                                 
                                █▒ ░▒░░▓▓▓█████▒▒░▒▒░░░▒▓▓██████▒▒▓▓▓▓███▓██             ███████▓▓▓▓████                               
                                ▓░░░▒░▒▓███████▓▒▒▒█▒▒▒▓█▓██▒▒░░░▒▒▒█████████               █████▓█▒▓███                               
                                █░░░▒░████ ██▒░▒▒▒▒▒▒▓▓████▒▒░░▒▓██▓▒▒▓██████                █████▓▓█████                              
                                ▒░░██▓██████▓▒▒▒░░░░░░░░░░▒▒▒▒▒▒░▒▓▓▒▒▓▓█████               ██░▒▒██▓▓███████                           
                               ▓▒ ░██████ ██▒░░░░░░░░░░░░▒░░░▒▒▒▒▓███████████               ███████▓▒▓██▓▒██                           
                              ██░░░▓████  ████▒▒░  ░░░░░░░▒▒▒▒▒▓▓████▓▓▓██████                  ███▓█▒▓████                            
                              ██░░▓▓████ ██▓▒░  ░░  ░▒▒▒▓█████▓▓▓███▓█████████                  █████▓▓█▓███                           
                            ███▓▒▒▓█████ ██▒▒░▒▒▓▓▓▒▒▒▒░░ ▒▓██████████▓███████                    ████▒▓▒▓████                         
                              █▓▒▒▓███  ██▒▒░░░░░  ░░▒▒▒▒▒▓▓████▓▓▓█▓▓▓███████                     ██▓█▓█▓██▓▒▒██                      
                             ██░▒▒▓██  ██▓▒▒▒░░░░░░▒▒▒▒▒░░▒▒▒▒▓▓▓▓▓▓█▓▓▓▓████                       ████▓▓▓██████                      
                           ███░░░░▒▓█████▒▒▒▒░▒▒░▒▒▒▓▒▒▒▒▒▒▒▒▓▓▓▓█▓▓█▓▓▓▓████                        ██▓▓▓█▓████                       
                          ███▒░░░░▒▒████▓▒▒▒▒░▓▓▒▒▒▓▓▓▒▒▒▒▒▒▒▓▓▓▓▓▒▓▓█▓▓▓████  █                      ██▓███▓▓████  █                  
                         █▒▓▒░░▓▓▒░░▒███▒▓▒▒▒▒▓▓▒▒▒▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓███                        █▒█▓█▓█▓▓█▓▓█▒▓█                  
                        ██░▒░░▓██▒▒▒███▓▒▒▒▒▒▒▓▓▒▒▒▓▓▓▓▓▓▓▒▒▒▓▓▓██▒▓██▓▓▓▓███                           ██▓██▓▓▓█████                  
                        ██░▒░▒█████▓████▓▓▒▒░▓▓▒▒▒▒▒▓▓▓▓▓▓▒▒▒▓▓▓▓▓▒▓█▓▓▓▓█▓███                           ██▓██▓▒████ ███               
                        ██▒▓░▓████▒░▒██▓▓▒▒▒▒▓▓▒▒▒▒▒▓▓▓▓▓▓▒▒▒▓▓▓▓▓▒▓██▓▓▓█▓▓███                          █▓▓▓███▓████▒██               
                        ███▓░██████▒▒▓█▓▓▒▓▒▓█▓▒▒▓▒▒▓▓▓▓▓▓▒▒▒▓██▓▓▓▒▓██▓▓██▓███                        ██▒▒▓█████▓▓█▒▓█                
                        ███▒░██████▒███▓▓▓▒▒▓█▓▒▒▓▓▓▓▓▓▓▓▓▒▒▒▓████▓▓▓▓█▓▓███████                        █████████▓▓████                
                         ███▓▓█  ██▒█▓▓▓▓▓▓▓██▓▒▒▒▓▓▓▓▓██▓▓▒▒▒████▓▓▓▓█▓▓███████                            █████▓██▓██                
                         ██████  ██▓█▓▓█▓▓▓▓███▓▒▒▒▓▓▓███▓▒▒▒▓▓████▓▓▓█▓▓████████                           ██░▒██▓▓▓▓████             
                             ██  ███▓▓▓█▓▓▓▓███▒▒▒▒▒▒▓███▓▓▓▒▓▓████▓▓▓██▓▓████████                          ███████▓▓▓▒███             
                             ██  ███▒▒▓▓▓▒▒▓██▓▒▒▒▒▒▒▓███▓▓▓▒▓▓████▓▓▓███▒▓███████                            ████████▓███             
                                 ██▒▒▒▓▓▓▒▒▓▓█▓▓▒▒▒▒▒▓████▒▒▒▓▓▓████▓████▓▓████████                           ███▓▓██▓█▓▓██            
                                ███▓▒▒██▓▒▓▓██▓▒▒▒▒▒▒▓████▒▒▒▒▒▓████▓▓████▓▓████████                           █▒▒▓███▓▓▓▓████         
                                ███▒▒▓█▓▓▒▓▓██▓▒▒▒▒▒▒▓████▓▒▒▒▒▓████▓▓█▓██▒▓████████                          ██▓██████▒█▒▓▓▒█         
                              █ ███▒▒▓█▓▒▒▒▓██▓▒▒▒▒▒▒▓████▓▒▒▒▒▓█████▓▓▓███▓▓███████                           █████▒▓█▓▓▓███          
                               ███▓▒▒▓█▓▒▒▒▓██▓▒▒▒▒▒▒█████▓▒▒▒▒▓█████▓▓▓▓██▓▒▓████████                             █▓▓██▓█▓▓██         
                               ███▓▒▒▓█▓▒▒▓▓██▓░▒▒▒▒▒██████▒▒▒▓▒█████▓▓▓████▒▓██████████                            █▓▓██▒▓▒▓██        
                               ██▓▓▒▒██▒░▒▓▒██▓▒▒▒▓▒▓██████▓▒▒▒▓██████▓▓████▓▒▓██████████                           █▓▓▓█▓▓▓▓████      
                              ███▓▒▒▒█▓▒▒▒▓▒██▓▒▒▒▓▒▓████▓█▓▒▒▒▓▓▓████▓▓█████▒▒▓█████████                         ██▒▒▓███▓▓▓▒▓██      
                              ██▓▓▓▒▒█▓▒▒▒▒▓█▓▒▒▒▓▓▒▓████▓█▓▒▒▓▓▒▓▓███▓▓█████▓▒▓█▓████████                       ██▒▓██████▒██▓██      
                              ██▓▓▒▒▒▓▒░▒▒▒▒▓▒▒▒▒▓▓▒▓███▓▓██▒▒▒▓▒▓▓███▓▓▓████▓▓▒▓▓█████████                      █    █████▓▒█▒███     
                              █▓▓▓▒▒▒▒▒░▒▒▒▒▓▒▒▒▒▓▓▒▓██▓▓▓██▒▒▒▓▓▓▓███▓▓▓█████▓▒▓█▓████████                            █████▓▓▓▒███    
                             ██▓▓▓▓▒▓▒▒░▒▒▒▒▓▒▒▒▒▓▓▓███▓▓▓██▒▒▒▓▒▓▓▓█▓▓▓▓█████▓▓▒▓▓██████████                            ██▓▓██████    
                           ████▓▓▓▓▓▓▓▒░▒▒▒▒▓▒▒░▒▓▓▓███▓▓▓█▓▒▒▒▓▒▒▓▓▓▓▓▓▓██████▓▓▓▓▓████████                             █▒▒██▓▒███    
                             ███▓▓▓▓██▒░▒▒▒▓▓▒▒▒▒▓▓▒▓███▓▓█▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓█████▓▓▓▓▓███████                             █▒████▓▓██    
                              ██▓▓████▒▒▒▒▒▓█▓▒▒▒▓▓▒▓██████▓▒▒▒▒▓▓▒▓▓▓▓▓▓▓███████▓▓▓▓███████                             ███  █████    
                            █  ██▓▓▓▓█▓▒▒▒▒▓█▓▒▒▒█▓▒▓███████▓▒▒▒▒▓▓▓▓█▓▓▓▓▓███████▒▓███▓▓███                                    █      
                                █▓█████▓▒▒▒▓▓█▓▒▒██▒▓▓███████▒▒▒▒▓▓▓███▓▓▓▓▓█████████▓▒▒▒▓██                                           
                                 ▓░▒▓█████▓████▒▒▒█▒▒▓▓██████▒▒▒▒▓▓▓████▓▓▓▓▓███████▒▓█▓▓▒██▒                                          
                                ██░▒██▓▒███████▓▓██▒▒▒▓██████▒▒▒▒▒▓▓▓███▓▓▓▓▓███████▒░▓▓▒▒▒▒██                                         
                                 █▒░▓▒▒▒▓███   ▒▓███▓▓████████▓▒▒▒▓▓▓▓▓▓████████████▒░░▒▒▒░░██                                         
                                 █▓░▒▒░▒▒▓███  ██████████ █ ██████████████        ███▒░░▒▒░░▒██                                        
                                 █▓▒▒▒░░▓████                                       ██▒░░░▒░▒▓█                                        
                                 █▒▒▒▒▒▒█████                                        ██▒░░░▒░▒███                                      
                          ██     █▓▒▒▓█▓█████                                         ██▒░░█▓▓███                                      
                          ██    ███▒▓████████     ██████████████████████████          ███▓▓▒▒▓█████                                    
                              ██▒░▒█▒▒▓██████████████████████████████████████████████████▒░▒▒▒▒▒████                                   
                     ████████▒░░░░░▒▒▒▒▒▒████████████████████████████████████████████████▓░░░░▒▒▒▒▓████                                
                     ▓▒░░░░░░░░▒▒▒▓███▓▒▒███████████████████████████████████████████████▓█▓░▒▒▒▓▓▓▓█▒░▓████████                        
                ██████▒▒▒▒▒▒▒▒▒▓███████▓██████████████████████████████████████████████████▒░░░▓░░▒░▒▓▒▓████████                        
                ██████████████████████████                █████████████████████████████████▓▒▒██▓▓▓████████                            
                                  ██████                                     ███████████████████████████                               ");
                                  break;                                                                                                 
            case "Gro-goroth":
            Console.WriteLine(@"
                                                                                                                                    
                                                                                                                                    
                                                     ██                      ████                 █                                 
                                                  █▒ ░██                    █▒▒▓██               █▓████████                         
                                                 █▒░ ░██                    █▓ ▒███             ██▓███████████                      
                                ███████         ██▒▓▒██                ██    ██░▓███            ████▓▓██████████████▓▒▒▒▓██         
                      █████▓▓▓███▓ ░▓██   ██    █▒▒▓██████   ████    ███████████▓███            ▒▒█████████████▓▓█████▓░░▓███       
              ███████████▓▓▒▒▒▒░░▒▒██     ██   █▓░▒█████████████████████████████▒███           █████████████████████████░░████      
            ██▓▒░▒▓▓██░▒▓█████▓░░▓▒██     ███  ███▒██████ ▒██████████████▒█████▒▓████ ██     ███████████████████████████▒▒▓████     
          █▓▒▒▓████▓▒░███████░ ░█████      ███████▓▓▒████▒▒▓███████████▓▓▓████▒▒████████  █████████████████▓█████████████▓▒▒███     
        ██▒░▓██████▒███▓████▓█████████     ████████▓▒▓████░▓▒█▓▒▓▒▓▒▓██▓████▒░▓█████████████████████████████▓▓███████████▓▒▒██      
       ██▒░▒██████████████▓████████████    ██████████░▓████▒███▓▓░░▒██▓████░▒███████████████████████████████████▓▓████████▒▓██      
      ██▓▒▓███▓▓████████████████████████████████▓███████████████▓█▓█▒▓▓█████████████████████████████████▓██████████▓███████▓██      
     ██▒▒▒▓█▓████████▓▓████████████████████▓██▓██████████▒  ░░▓█▓▓▒▒▒█████████████████████████████████████████████████████████      
     ██▓▓▒▓▒████████░███████████████████████▓▓▓▒▒███████░  ██▓ ▓█▒░░▒▓███▒████████████████████████████████████████████████████      
    ███▓▒▓▓███████▓▒████████████████████████▓▒▒▒▓███████ ▒██▒ ▒▓██▓▒█████▓████████████████████████████████████████████████████      
    ██▓▒█████████▒▓███████████████████████▓▓▓▓▓██████████▓░░░▓████▒░▓███▓▓███████▓▒▓██████████████████████████████████████████      
    ██▒▒████████▓████████████████████████▓▒▒▒▒▒▒▒▓██████████████▒░▒▓▓▒█▓████████▓▒▒▒▓████████████████████████████████████████       
    ██▒████████▓████████████████████████████▓▓▒░▒▒▒▒█████████▓▓▓░▒█▒▓█████████▓▓▓▒█████████████████████████████ █████████████       
    ██▓███████▓█████████████████████████████▓▒▒█▓▒▒▒▒▒▓████████▓▓▓▓▓█████████▓▓▓▓██████████████████▓▓▓▓████████       ███████       
    ██████████████████████████▓▓█▓▒████████████████▓▒░█▓▓██████▓▓▒▓▓██████▓▒  ░▒▓█████████▓██████████▒▒▒████████      ███████       
    ███████████████████████▒  ░░░████████████▓▓▓▒▒██████▒▒▒░▒▓▓████▓█████▓ ░░▒███████████████████████░▒░▒▓███████       █████       
   ███████████████████████▓░▒▒██▒░▓█▓▓█████████████▓████▓▓░░ ░░▒██████▓▓▓█▒▒▓▒███████████████████████░░░░▒▓██████       █████       
   █████████▓███████    ███░▒▓▓░▒▓██▓▓█████▓░░░▒▒░▒██████▒██████████████████▒███████████████████████▓▒░░░▒▓███████      █████       
   ███████ █████         ████▓▓▓████▓█████░   ▓▓▓█▒▒██▓█▓███████████████████████████████████████████░░░▒▒▒▓████████     ████        
   ██████  ████          ██▒▓█▓▓█▒░▒███▓██░  ▓███▓▓░░██▓██▒▒▓██████████▒ ▒▒▒▒███▓▓█████████████████▓▒░░░▒▒▓█████████    ████        
   █████   ████          █████▓▒▒▒▒▓██▓▓██▓▒▒█▓▓██▒▒███▓▓▒██████▓███▓██░░██▓▒██████████████████▒▓█▒▒▓▓▒░░░▒█████████     ███        
    ████   ████         ██████▒░ ░░▒▓██░░███▓▒░░░░▓██▓▓██ ▓█▓▒██▓████▓██▒▒▓▓███████████████▓███▓▓▓▒▒▒▒▓▓▒▒▒▓██▓█████     ███        
    ████   ███          ███▓▒▒░   ░▒▓█▒▒██▓▒▓▓████████████▓░░███████████████▓███████████████████▓▒▓▒▓███▓▒▓▓▓████████    █          
    ███    ███         ███░       ░▒░░▓█████▓▓███▓▓█████▒▓▓▒██████████████▓▓█▓████▓▓█▓▓███████████▓██▓██▓░▓▓▓████████               
    ███               ████░      ░░░░████████████████▓▒▒░▓█░██████▒░░█▒▓█████▓███▓▒▒▒█▓██████████████▓▓█▓░░▒▓██████████             
    ██               █████░ ░   ░░░▓█████▓ ░▒▓███▓███▒▒░▒▒█░▒████▓██████▒█████████▒░░████████████████▓▓▓█▒░░ ░▒█████████            
     █              ███▒███▓░░░░░░▒▓█████  ▒█▓▓██▓▒▓▒░▒▒ ▒███████▓▒▒▒██▒▓▓█████████▓▓█████████████████▓▓█▒ ▒░░░▓████████            
     █             ██████▓▒▒░░▒▒░▒█▓█████░▒▒▒░░███▓▓▒░▒▒▒▒██████▓█▓▓▓▒▓█▓▓▓█▓████████████████████████▓▒▓▒█▒ ▒▒░░▓▓██████            
               ███████▓██▒ ░░ ▒▓▒▒▓█████████████████████████████████▓▒▓██▓▒▓▓█████████████████████████▓▓▓██████▓▒█████████          
              █  █████▓▒▓░░▒░░▓▓▒▒▒███████▓█████████▓▓▒▓▒███▒▓██████▓▒▓▓▓██▓██████████████████████████████▓▓█▓▒▓▓▓████████          
                ████▓▒▒▒▒ ▒▓▒▒█▓▓▓▓██████████████████▓▒▓█████████████▓█▓███▓▓▓▓████████████████████████▓█▓▒▓▓▓▓▓░▒▓████████         
                 ███▓░░▓▓▓█████████████████████████████▓██▓▓░░░    ░░░░▓▓█████▓███████████████████████▓█▓▓██▓█▓▒▓█▓████████         
           █    ███▒█▒██▓▓▒▒▓█▓▒██▓▓██████████████▒▒▒▒▓▓▓▓░▒▓▓████▓▓█████████████████████████████████▒▓███▓▓█▓▒▓▓▓▓█▓██████         
                ███████▒▒░▒▓▓▓██▓▓██▒██████████████▓▒████████████████████████▓█████████████████████▓▒▒████▓█▓█▓██▓▒▒███████         
                ████████▓▓▓▒▓██▓██▓██▒▒████████████▓██████████████████████████████████████████████▓▒▒████████▓▓▓▒▒▓███████          
                ██████████▓▓▓▓▓█▓▓████▒░▓███████████████████████████████████████████████████████▒▒█████▓████▓██▓▓▓████████          
                 ███▓▓▒▓▓▒███▓▓▓███▓██████▒░▒█████████████████████████████████████████████████▓░▒▓▓███▓▓█████▓▒██████████           
                 ███████▓▓▒▒▓▓▓▓████▓▓█████▓▓███████████████████████████████████████████████████████▒███████████████████            
                  ███▓▓██▓█▓▓████████▓█▓▓▓████████▓████████████████████████████████████████▓██▓███▓▒███▓▒▒▒██▓████████              
                    ███▓▒▓█████▓▒▓██▓▓▓███▒▓██▓▒▒██░░█████████████████████████████████████░██░▓█▓█░▓██▓▓████▓▒███████               
                     █████▓▓███████▒▒▒▓▓███▒▓█▒██████▒▒▓████████████████████████████████▓▒▓█▓██▒█████▓▓██▓██▓███████                
                       █████████▓▓█████▓▓██████▒█████████▓██████████████████████████████████████████████▓██████████                 
                         █████████▓██▓▓██▓███▓█▓▓████▓░███▓▓██▒█▓▒▒▓███████████████████▓▓██▓███▓▒██████████████████                 
                           ████████████▓█████▓█▓░▓███░░▓██▓▓▓███▒░▒▒▓▓▒▓█████████████▓░▓███████▒░▓███▓████████████                  
                             ████▓█████████████▓░░████▓████░▒▓███▓███▒  ████████████░░▓████▓▒███▒██████████████████                 
                             ████████▓█████▒▓███▓░▓██▓▓█████░ ▒███████░ ▓██     ███▒▓█████▓▓████▓░▒████▓▒██████▓███                 
                              ███▓▓██▓█▓▒░▓█████▒▓███▓▒▒███████████ ██▒ ▓██     ██▒░████████▓████░ ░████████████▓██                 
                               ██▓████▓▓▒ ▒████░░▓█████████▓███░▓█████▓▓██     ██████▓▓███▓▒░ ███░▒▒█████▓░█████████                
                               █████████░█████▒ ░░███▒▒▒███▒▓▓██▓▓███████     ██░▒████████▓▒░ ████▓██████▓░▓█████████               
                               ████▓███▓ ▒███████▓███▒░░░████████▓▒▓████     ██  █████████▓▒░ ███▓░░▓████▓▒▓████▓█▓██               
                                ███▓████▒▒▒████▓▓████▓▒▒░█████████▒░░███    ██   █████  █████████    ▓██████████████                
                                 ██▓███▒▒█████▓░▒░███▓█████   ████▒ ░██    ███░ ░████    ██▓░ █▓█    ████▓░████▓███                 
                                 ███▓██ ░░████▓   ▓███░ ░██    ██▓░░███      ██▓▒███     ██▒ ▓█▓█   ░████▒░███████                  
                                  ████▒▒ ░█████░   ███▓  ███    ▓████         █████▓     ██░░█▓██   ▓███▓░░██████                   
                                     █▒█▓ ██ ███░ ▒█████▓ ██   █████            ████     █▒▓██████▒▒████▒░▓█████                    
                                     █░█▓▓█   ███▓░██ ███ ██   ████              ██     ██░███  █ ▒██████▓████                      
                                      █ ░█      ██▓███ ███▓█                             ████  █████   █▓░▓██                       
                                      ███         ████                                         ███      ████                        
                                                                                                                                    
                                                                                                                                    ");  
                                   break;                                                                                                           
        }
        }
    }
}



