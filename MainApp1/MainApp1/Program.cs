//********************************************************************
// File:Program.cs
//
// Purpose: Contains Main.
//
// Written By: Mike Lindner
//
// Compiler: Visual Studio 2017
//********************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace MainApp1
{
    class Program
    {
        //********************************************************************
        // Method: Main
        //
        // Purpose: To display menu and call methods from ClassLibrary1.
        //********************************************************************
        static void Main(string[] args)
        {
            int x = 1;
            while (x !=16)
            {

            
                Console.WriteLine("Transcript Menu\n");
                Console.WriteLine("------------------\n");
            Console.WriteLine("1 - Read Course from JSON file\n");
            Console.WriteLine("2 - Read Course from XML file\n");
            Console.WriteLine("3 - Write Course to JSON file\n");
            Console.WriteLine("4 - Write Course to XML file\n");
            Console.WriteLine("5 - Display Course data on screen\n");
            Console.WriteLine("6 - Read Student from JSON file\n");
            Console.WriteLine("7 - Read Student from XML file\n");
            Console.WriteLine("8 - Write Student to JSON file\n");
            Console.WriteLine("9 - Write Student to XML file\n");
            Console.WriteLine("10 - Display Student data on screen\n");
            Console.WriteLine("11 - Read Transcript from JSON file\n");
            Console.WriteLine("12 - Read Transcript from XML file\n");
            Console.WriteLine("13 - Write Transcript to JSON file\n");
            Console.WriteLine("14 - Write Trancsript to XML file\n");
            Console.WriteLine("15 - Display Transcript data on screen\n");
            Console.WriteLine("16 - Exit\n");
            Console.WriteLine("Enter Choice: \n");
            Course c = new Course();
            Student s = new Student();
            Transcript t = new Transcript();
            String input = Console.ReadLine();
            x = Convert.ToInt32(input);
            #region Menu
            //********************************************************************
            // Switch statement takes user input and calls corresponding method
            // from Student, Course, or Transcript class in CourseLibrary1.
            //********************************************************************

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Please enter the file name: \n");
                        String input3 = Console.ReadLine();
                       c = c.OpenJSON(input3);
                        break;
                    case "2":
                        Console.WriteLine("Please enter the file name: \n");
                        String input4 = Console.ReadLine();
                       c = c.OpenXML(input4);
                        break;
                    case "3":
                        Console.WriteLine("Please enter the file name: \n");
                        String input5 = Console.ReadLine();
                       c = c.SaveJSON(input5);
                        break;
                    case "4":
                        Console.WriteLine("Please enter the file name: \n");
                        String input6 = Console.ReadLine();
                        c = c.SaveXML(input6);
                        break;
                    case "5":
                        c.Show();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Please enter the file name: \n");
                        String input7 = Console.ReadLine();
                        s = s.OpenJSON(input7);
                        break;
                    case "7":
                        Console.WriteLine("Please enter the file name: \n");
                        String input8 = Console.ReadLine();
                        s = s.OpenXML(input8);
                        break;
                    case "8":
                        Console.WriteLine("Please enter the file name: \n");
                        String input9 = Console.ReadLine();
                        s = s.SaveJSON(input9);
                        break;
                    case "9":
                        Console.WriteLine("Please enter the file name: \n");
                        String input10 = Console.ReadLine();
                        s = s.SaveXML(input10);
                        break;
                    case "10":
                        s.Show();
                        break;
                    case "11":
                        Console.WriteLine("Please enter the file name: \n");
                        String input11 = Console.ReadLine();
                       t = t.OpenJSON(input11);
                        break;
                    case "12":
                        Console.WriteLine("Please enter the file name: \n");
                        String input12 = Console.ReadLine();
                       t = t.OpenXML(input12);
                        break;
                    case "13":
                        String input13 = Console.ReadLine();
                        t = t.SaveJSON(input13);
                        break;
                    case "14":
                        String input14 = Console.ReadLine();
                        t = t.SaveXML(input14);
                        break;
                    case "15":
                        t.Show();
                        break;
                    case "16":
                        break;

                }
            }
        }
    }
}
#endregion