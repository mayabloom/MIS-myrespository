using System;

namespace Redo_hw_2_grades
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(" What is your grade percentage for Accounting? ");
            string accounting = Console.ReadLine();
             double accountinggrade;

            if (double.TryParse(accounting, out accountinggrade) == false)
            {
                Console.WriteLine($"Sorry {accounting}  was invalid!");
                Environment.Exit(-1);
            }

            accountinggrade = accountinggrade / 100;

            

            Console.WriteLine("What is your grade percentage for Marketing");
            string marketing = Console.ReadLine();
             double marketinggrade;

            if (double.TryParse(marketing, out marketinggrade) == false)
            {
                Console.WriteLine($"Sorry {marketing}  was invalid!");
                Environment.Exit(-1);
            }

            marketinggrade = marketinggrade / 100;

            

            Console.WriteLine("What is your grade percentage for Economics?");
            string economics = Console.ReadLine();
             double economicsgrade;

            if (double.TryParse(economics, out economicsgrade) == false)
            {
                Console.WriteLine($"Sorry {economics}  was invalid!");
                Environment.Exit(-1);
            }

            economicsgrade = economicsgrade / 100;

            

            Console.WriteLine("What is your grade percentage for MIS?");
            string mis = Console.ReadLine();
             double misgrade;

            if (double.TryParse(mis, out misgrade) == false)
            {
                Console.WriteLine($"Sorry {mis}  was invalid!");
                Environment.Exit(-1);
            }

            misgrade = misgrade / 100;

            char accountinglettergrade, marketinglettergrade, economicslettergrade, mislettergrade;
            double TotalPointsEarned = 0, gpa = 0;
            const int Total_Credits_Attempted = 12;

            if (accountinggrade > .09)
            {
                TotalPointsEarned += 4; ;
                accountinglettergrade = 'A';
            }
            else if (accountinggrade > .08)
            {
                TotalPointsEarned +=3;
                accountinglettergrade = 'B';
            }
            else if (accountinggrade > .07)
            {
                TotalPointsEarned +=2;
                accountinglettergrade = 'C';
            }

            else if (accountinggrade > .06)
            {
                TotalPointsEarned += 1;
                accountinglettergrade = 'D';
            }

            else
            {
                TotalPointsEarned += 0;
                accountinglettergrade = 'F';
            }

            if (marketinggrade > .09)
            {
                TotalPointsEarned += 4;
                marketinglettergrade = 'A';
            }
            else if (marketinggrade > .08)
            {
                TotalPointsEarned += 3;
                marketinglettergrade = 'B';
            }
            else if (marketinggrade > .07)
            {
                TotalPointsEarned += 2;
                marketinglettergrade = 'C';
            }

            else if (marketinggrade > .06)
            {
                TotalPointsEarned += 1;
                marketinglettergrade = 'D';
            }

            else
            {
                TotalPointsEarned += 0;
                marketinglettergrade = 'F';
            }

            if (economicsgrade > .09)
            {
                TotalPointsEarned += 4;
                economicslettergrade = 'A';
            }
            else if (economicsgrade > .08)
            {
                TotalPointsEarned += 3;
                economicslettergrade = 'B';
            }
            else if (economicsgrade > .07)
            {
                TotalPointsEarned += 2;
                economicslettergrade = 'C';
            }

            else if (economicsgrade > .06)
            {
                TotalPointsEarned += 1;
                economicslettergrade = 'D';
            }

            else
            {
                TotalPointsEarned += 0;
                economicslettergrade = 'F';
            }

            if (misgrade > .09)
            {
                TotalPointsEarned += 4;
                mislettergrade = 'A';
            }
            else if (misgrade > .08)
            {
                TotalPointsEarned += 3;
                mislettergrade = 'B';
            }
            else if (misgrade > .07)
            {
                TotalPointsEarned += 2;
                mislettergrade = 'C';
            }

            else if (misgrade > .06)
            {
                TotalPointsEarned += 1;
                mislettergrade = 'D';
            }

            else
            {
                TotalPointsEarned += 0;
                mislettergrade = 'F';
            }

            gpa = TotalPointsEarned / (Total_Credits_Attempted / 3);

            Console.WriteLine();

            Console.WriteLine($"You earned a {accountinglettergrade} for accounting");
            Console.WriteLine($"You earned a {marketinglettergrade} for marketing");
            Console.WriteLine($"You earned a {economicslettergrade} for economics");
            Console.WriteLine($"You earned a {mislettergrade} for mis");

            Console.WriteLine($" You earned a {gpa.ToString("N2")} gpa for the semester");

        }

        


    }
}
