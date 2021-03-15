using System;

namespace redo_hw_2_student_gpa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What  is your grade percentage for Accounting?");
            string accounting = Console.ReadLine();
            double accountinggrade;

            if (double.TryParse(accounting, out accountinggrade) == false)
            {
                Console.WriteLine("Sorry that was an invalid input");
                Environment.Exit(-1);
            }

            accountinggrade /= 100;

            Console.WriteLine("What  is your grade percentage for Marketing?");
            string marketing = Console.ReadLine();
            double marketinggrade;

            if (double.TryParse(marketing, out marketinggrade) == false)
            {
                Console.WriteLine("Sorry that was an invalid input");
                Environment.Exit(-1);
            }

            marketinggrade /= 100;

            Console.WriteLine("What  is your grade percentage for Economics?");
            string economics = Console.ReadLine();
            double economicsgrade;

            if (double.TryParse(economics, out economicsgrade) == false)
            {
                Console.WriteLine("Sorry that was an invalid input");
                Environment.Exit(-1);
            }
            Console.WriteLine("What  is your grade percentage for MIS?");
            string mis = Console.ReadLine();
            double misgrade;

            if (double.TryParse(mis, out misgrade) == false)
            {
                Console.WriteLine("Sorry that was an invalid input");
                Environment.Exit(-1);
            }

            double totalpointsearned = 0;
            const double total_credits_attempted = 12;
            double gpa = 0;

            string accountinglettergrade,marketinglettergrade, economicslettergrade, mislettergrade;

            if (accountinggrade >=.90)
            {
                accountinglettergrade = "A";
                totalpointsearned += 4;
            }
            else if (accountinggrade =>.80)
            {
                accountinglettergrade = "B";
                totalpointsearned += 3;
            }

            else if (accountinggrade =>.70)
            {
                accountinglettergrade = "C";
                totalpointsearned += 2;
            }

            else if (accountinggrade => .60)
            {
                accountinglettergrade = "D";
                totalpointsearned += 1;
            }
            else
            {
                accountinglettergrade = "F";
                totalpointsearned += 0;
            }


            if (misgrade => .90)
            {
                mislettergrade = "A";
                totalpointsearned += 4;
            }
            else if (misgrade => .80)
            {
                mislettergrade = "B";
                totalpointsearned += 3;
            }

            else if (misgrade => .70)
            {
                mislettergrade = "C";
                totalpointsearned += 2;
            }

            else if (misgrade => .60)
            {
                mislettergrade = "D";
                totalpointsearned += 1;
            }
            else
            {
                mislettergrade = "F";
                totalpointsearned += 0;
            }


            if (economicsgrade => .90)
            {
                economicsgrade = "A";
                totalpointsearned += 4;
            }
            else if (economicsgrade => .80)
            {
                economicslettergrade = "B";
                totalpointsearned += 3;
            }

            else if (economicsgrade => .70)
            {
                economicslettergrade = "C";
                totalpointsearned += 2;
            }

            else if (economicsgrade => .60)
            {
                economicslettergrade = "D";
                totalpointsearned += 1;
            }
            else
            {
                economicslettergrade = "F";
                totalpointsearned += 0;
            }

            if (marketinggrade => .90)
            {
                marketinglettergrade = "A";
                totalpointsearned += 4;
            }
            else if (marketinggrade => .80)
            {
                marketinglettergrade = "B";
                totalpointsearned += 3;
            }

            else if (marketinggrade => .70)
            {
                marketinglettergrade = "C";
                totalpointsearned += 2;
            }

            else if (marketinggrade => .60)
            {
                marketinglettergrade = "D";
                totalpointsearned += 1;
            }
            else
            {
                marketinglettergrade = "F";
                totalpointsearned += 0;


            }
        }
    }
