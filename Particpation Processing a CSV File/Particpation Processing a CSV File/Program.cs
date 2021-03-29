﻿using System;
using System.IO;

namespace Particpation_Processing_a_CSV_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("sales_data_sample.csv");

            double totalFor2003 = 0;
            double totalFor2004 = 0;
            double totalFor2005 = 0;

            double[] monthlySales = new double[13];
            //monthlySales[0] = 0;  don't need it starting at month 1
            monthlySales[1] = 0;
            monthlySales[2] = 0;
            monthlySales[3] = 0;
            monthlySales[4] = 0;
            monthlySales[5] = 0;
            monthlySales[6] = 0;
            monthlySales[7] = 0;
            monthlySales[8] = 0;
            monthlySales[9] = 0;
            monthlySales[10] = 0;
            monthlySales[11] = 0;
            monthlySales[12] = 0;


            for (int i = 1; i < lines.Length; i++)
            {
                // 0               1              2          3            4       5           6  7         8
                //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE
                string line = lines[i];

                string[] pieces = line.Split(","); //seperating lines by comma

                string status = pieces[6];
                int year = Convert.ToInt32(pieces[9]);
                int month = Convert.ToInt32(pieces[8]);
                double sales =Convert.ToDouble(pieces[4]);

                if (pieces[6].ToLower() =="shipped")
                {
                    switch (year)
                    {
                        case 2003:
                            totalFor2003 += sales;
                            break;
                        case 2004:
                            totalFor2004 += sales;
                            break;
                        case 2005:
                            totalFor2005 += sales;
                            break;
                        default:
                            break;

                           
                    }
                    monthlySales[month] += sales;
                }
                

               


            } // end of for

            for (int i = 1; i < monthlySales.Length; i++)
            {

                if (i == 1)
                {
                    Console.WriteLine($"January sales total is {monthlySales[i].ToString("C")}");

                }

                else if (i == 2)
                {
                    Console.WriteLine($"February sales total is {monthlySales[i].ToString("C")}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"March sales total is {monthlySales[i].ToString("C")}");
                }
                else if (i == 4)
                {
                    Console.WriteLine($"April sales total is {monthlySales[i].ToString("C")}");
                }

                else if (i == 5)
                {
                    Console.WriteLine($"May sales total is {monthlySales[i].ToString("C")}");
                }
                else if (i == 6)
                {
                    Console.WriteLine($"June sales total is {monthlySales[i].ToString("C")}");
                }
                else if (i == 7)
                {
                    Console.WriteLine($"July sales total is {monthlySales[i].ToString("C")}");
                }
                else if (i == 8)
                {
                    Console.WriteLine($"August sales total is {monthlySales[i].ToString("C")}");
                }

                else if (i == 9)
                {
                    Console.WriteLine($"September sales total is {monthlySales[i].ToString("C")}");
                }
                else if (i == 10)
                {
                    Console.WriteLine($"October sales total is {monthlySales[i].ToString("C")}");
                }
                else if (i == 11 )
                {
                    Console.WriteLine($"November sales total is {monthlySales[i].ToString("C")}");
                }
                else //12 
                {
                    Console.WriteLine($"December sales total is {monthlySales[i].ToString("C")}");
                }

            }

            Console.WriteLine($"The total sales for shipped items for 2003 is {totalFor2003.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items for 2004 is {totalFor2004.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items for 2005 is {totalFor2005.ToString("C")}!");





        }
    }
}
