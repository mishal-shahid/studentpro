using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vp_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            profile obj1 = new profile();
            char option;
            string choice = null ;
            string choice1;
            do
            {
                Console.WriteLine("enter an option");
                Console.WriteLine("press 1 for creating profile");
                Console.WriteLine("press 2 for searching");
                Console.WriteLine("press 3 to delete");
                Console.WriteLine("press 4 to find top 3 gpas");
                Console.WriteLine("press 5 to mark attendance");
                Console.WriteLine("press 6 to view attendance");
                Console.WriteLine("press e to Exit");
                string name, id, sem, dept, uni;
                float cgpa;
                string present = "absent";
                option = char.Parse(Console.ReadLine());
                if (option == '1')
                {
                    Console.WriteLine("enter name");
                    name = Console.ReadLine();
                    Console.WriteLine("please enter id in format as 001,002....");
                    id = Console.ReadLine();
                    Console.WriteLine("please enter semester in format as 1st,2nd,3rd,4th...");
                    sem = Console.ReadLine();
                    Console.WriteLine("please enter dept in format as bse,bce,bcs....");
                    dept = Console.ReadLine();
                    Console.WriteLine("enter uni");
                    uni = Console.ReadLine();
                    Console.WriteLine("please enter cgpa with 2 floating points as 3.00..");
                    cgpa = float.Parse(Console.ReadLine());
                    // obj1.checkid("002",args[0]);
                    obj1.createprofile(name, id, sem, dept, uni, cgpa, present, args[0]);
                }
                else if (option == '2')
                {
                    do
                    {
                        Console.WriteLine("enter an option");
                        Console.WriteLine("1. search by name");
                        Console.WriteLine("2. search by id");
                        Console.WriteLine("3. search by semester");
                        char option1;
                        option1 = char.Parse(Console.ReadLine());
                        if (option1 == '1')
                        {
                            Console.WriteLine("please enter name");
                            name = Console.ReadLine();
                            obj1.search(name, args[0]);
                        }
                        else if (option1 == '2')
                        {
                            Console.WriteLine("please please enter id in format as 001,002.... in format as 001,002....");
                            id = Console.ReadLine();
                            obj1.search(id, args[0]);
                        }
                        else if (option1 == '3')
                        {
                            Console.WriteLine("please enter dept in format as bse,bce,bcs....");
                            dept = Console.ReadLine();
                            Console.WriteLine("please enter semester in format as 1st,2nd,3rd,4th....");
                            sem = Console.ReadLine();
                            obj1.search(dept, sem, args[0]);
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        Console.WriteLine("want to continue?");
                        Console.WriteLine("press y for yes and n for main menu");
                        choice1 = Console.ReadLine();
                    } while (choice1 == "y");
                }
                else if (option == '3')
                {
                    Console.WriteLine("please enter id in format as 001,002....");
                    id = Console.ReadLine();
                    obj1.delete(id, args[0]);
                }
                else if (option == '4')
                {
                    obj1.max(args[0]);
                }
                else if (option == '5')
                {
                    Console.WriteLine("please enter dept in format as bse,bce,bcs....");
                    dept = Console.ReadLine();
                    Console.WriteLine("please enter semester in format as 1st,2nd,3rd,4th...");
                    sem = Console.ReadLine();
                    obj1.attendance(dept, sem, args[0]);
                }
                else if (option == '6')
                {
                    Console.WriteLine("please enter dept in format as bse,bce,bcs....");
                    dept = Console.ReadLine();
                    Console.WriteLine("please enter semester in format as 1st,2nd,3rd,4th...");
                    sem = Console.ReadLine();
                    obj1.viewAttendance(dept, sem, args[0]);
                }
                else if (option == 'e')
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
                Console.WriteLine("want to continue?");
                Console.WriteLine("press y for yes and n for no");
                choice = Console.ReadLine();
            } while (choice=="y");
        }
    }
}
