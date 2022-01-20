using System;
using System.Collections.Generic;

namespace SuperHeroes
{
    class Program
    {
        static List<SuperHero> heroList = new List<SuperHero>();

        static SuperHero CreateHero()
        {
            Console.WriteLine("What's your super heroes real name?");
            string realname = Console.ReadLine();

            Console.WriteLine("Can your super hero fly? (y/n)");
            char flyinginChar = Console.ReadLine()[0];

            bool flying = false;
            if (flyinginChar == 'y')
            {
                flying = true;
            }

            //Console.WriteLine("Does your super hero have a weakness? (y/n)");
            //string hasWeakness = Console.ReadLine();

            //if (hasWeakness == "y" || hasWeakness == "yes")
            //{
            Console.WriteLine("What are you super heroes weaknesses?");
            string weakness = Console.ReadLine();
            //}

            Console.WriteLine("Does your super hero have a costume? (y/n)");
            string hasCostume = Console.ReadLine();

            bool costume = false;
            if (hasCostume == "y")
            {
                costume = true;
            }

            Console.WriteLine("What is your super hero's gender identity?");
            string genderidentity = Console.ReadLine();

            Console.WriteLine("What is your super hero's backstory?");
            string backstory = Console.ReadLine();

            Console.WriteLine("Is this story tragic?");
            string hasTragic = Console.ReadLine();

            bool tragic = false;
            if (hasTragic == "y")
            {
                tragic = true;
            }

            SuperHero myHero = new SuperHero();
            myHero.SetRealName(realname);
            myHero.SetFlying(flying);
            myHero.SetWeakness(weakness);

            //SuperHero myHero = new SuperHero(flying, realname, weakness, costume, backstory, tragic, genderidentity);

            return myHero;
        }

        static void Main(string[] args)
        {
            //SuperHero[] heroArray = new SuperHero[3];
            
            for(int i=0; i < 3; i++)
            {
                SuperHero newSuper = CreateHero();
                //heroArray[i] = newSuper;
                heroList.Add(newSuper);
            }

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Choose from one of the menu options:");
                Console.WriteLine("1. Edit Super Hero");
                Console.WriteLine("2. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        EditSuperHero();
                        break;
                    case 2:
                        isRunning = false;
                        break;
                }

                Print();
            }
            
            
        }

        static void Print()
        {
            int count = 0;
            foreach (SuperHero hero in heroList)
            {
                Console.WriteLine(hero);
                count++;
            }
        }

        static void EditSuperHero()
        {
            Console.WriteLine("Please choose a super hero to edit: ");

            for (int j = 0; j < 3; j++)
            {
                //Console.WriteLine($"Printing Super Hero {j+1}\n");
                Console.WriteLine((j + 1) + ". " + heroList[j].GetRealName());

                //Console.WriteLine(heroArray[j]);

            }

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Let's change your super hero's name to: ");

            heroList[choice - 1].SetRealName(Console.ReadLine());

        }
    }
}
