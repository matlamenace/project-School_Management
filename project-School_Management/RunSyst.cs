using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    class RunSyst
    {
        int positional_value = 0;

        public RunSyst()
        {
            while(positional_value != -1)
            {
                switch(positional_value)
                {
                    case 0: // --------------------------------Menu beginning --------------------------------
                        {
                            Console.Clear();
                            Console.WriteLine("          SCHOOL MANAGEMENT APPLICATION" + "\n");
                            Console.WriteLine("By Matthieu PERRET (24475), Mathis TIBERGHIEN (24445), Lucie MALLET (24470) & Benoit JAFFUEL (24431)" + "\n");

                            Console.WriteLine("PRESS ENTER TO CONTINUE, ESCAPE TO EXIT");

                            ConsoleKeyInfo KeyInfo = Console.ReadKey();
                            if (KeyInfo.Key == ConsoleKey.Escape) // Escape part
                            {
                                positional_value = -1;
                            }
                            else if (KeyInfo.Key == ConsoleKey.Enter) // Login part
                            {
                                string answer = "";
                                int index_error = 0;
                                Console.Clear();
                                while (answer != "Student" || answer != "Facultee" || answer != "Admin" || index_error.Equals(5))
                                {
                                    Console.WriteLine("         Identify yourself !" + "\n");
                                    Console.WriteLine("     Type Student if you are a student, Facultee if you are a facultee and Admin if you are an admin" + "\n");
                                    answer = Console.ReadLine();
                                }

                                if (index_error == 5)
                                {
                                    Console.WriteLine("To much attempt: Retry...");
                                }
                                else
                                {
                                    switch (answer)
                                    {
                                        case "Student":
                                            positional_value = 1;
                                            break;
                                        case "Facultee":
                                            positional_value = 2;
                                            break;
                                        case "Admin":
                                            positional_value = 3;
                                            break;
                                    }
                                }
                            }
                            break;
                        }
                    case 1: // --------------------------------Student branch --------------------------------
                        {
                            Console.Clear();

                            Console.WriteLine("-> 1111111111111111111");
                            Console.WriteLine("   2222222222222222222");
                            Console.WriteLine("   3333333333333333333" + "\n");


                            Console.WriteLine("PRESS ENTER TO SELECT");
                            Console.WriteLine("PRESS ESCAPE TO RETURN");

                            ConsoleKeyInfo UserKey = Console.ReadKey();
                            if (UserKey.Key == ConsoleKey.Escape)
                            {
                                positional_value = 0;
                            }
                            else
                            {
                                int arrow_position = 0;
                                while (UserKey.Key != ConsoleKey.Enter)
                                {
                                    switch (arrow_position)
                                    {
                                        case 0:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("-> 1111111111111111111");
                                                Console.WriteLine("   2222222222222222222");
                                                Console.WriteLine("   3333333333333333333" + "\n");

                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 2;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 1;

                                                break;
                                            }
                                        case 1:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("   1111111111111111111");
                                                Console.WriteLine("-> 2222222222222222222");
                                                Console.WriteLine("   3333333333333333333" + "\n");


                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 0;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 2;

                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("   1111111111111111111");
                                                Console.WriteLine("   2222222222222222222";
                                                Console.WriteLine("-> 3333333333333333333" + "\n");


                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");
        
                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 1;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 0;

                                                break;
                                            }
                                    }
                                }
                                switch (arrow_position)
                                {
                                    case 0:
                                        positional_value = 0;
                                        break;
                                    case 1:
                                        positional_value = 0; 
                                        break;
                                    case 2:
                                        positional_value = 0;
                                        break;
                                }
                            }
                            break;
                        }
                    case 2: // --------------------------------Facultee branch --------------------------------
                        {
                            Console.Clear();

                            Console.WriteLine("-> Add grade to an Exam");
                            Console.WriteLine("   Add grade to an Assignement");
                            Console.WriteLine("   Show student Attendance" + "\n");


                            Console.WriteLine("PRESS ENTER TO SELECT");
                            Console.WriteLine("PRESS ESCAPE TO RETURN");

                            ConsoleKeyInfo UserKey = Console.ReadKey();
                            if (UserKey.Key == ConsoleKey.Escape)
                            {
                                positional_value = 0;
                            }
                            else
                            {
                                int arrow_position = 0;
                                while (UserKey.Key != ConsoleKey.Enter)
                                {
                                    switch (arrow_position)
                                    {
                                        case 0:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("-> Add grade to an Exam");
                                                Console.WriteLine("   Add grade to an Assignement");
                                                Console.WriteLine("   Show student Attendance" + "\n");

                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 2;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 1;

                                                break;
                                            }
                                        case 1:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("   Add grade to an Exam");
                                                Console.WriteLine("-> Add grade to an Assignement");
                                                Console.WriteLine("   Show student Attendance" + "\n");


                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 0;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 2;

                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("   Add grade to an Exam");
                                                Console.WriteLine("   Add grade to an Assignement");
                                                Console.WriteLine("-> Show student Attendance" + "\n");


                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 1;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 0;

                                                break;
                                            }
                                    }
                                }
                                switch (arrow_position)
                                {
                                    case 0:
                                        positional_value = 0;
                                        break;
                                    case 1:
                                        positional_value = 0; 
                                        break;
                                    case 2:
                                        positional_value = 0;
                                        break;
                                }
                            }
                            break;
                        }
                    case 3: // --------------------------------Admin branch --------------------------------
                        {
                            Console.Clear();

                            Console.WriteLine("-> 1111111111111111111");
                            Console.WriteLine("   2222222222222222222");
                            Console.WriteLine("   3333333333333333333" + "\n");


                            Console.WriteLine("PRESS ENTER TO SELECT");
                            Console.WriteLine("PRESS ESCAPE TO RETURN");

                            ConsoleKeyInfo UserKey = Console.ReadKey();
                            if (UserKey.Key == ConsoleKey.Escape)
                            {
                                positional_value = 0;
                            }
                            else
                            {
                                int arrow_position = 0;
                                while (UserKey.Key != ConsoleKey.Enter)
                                {
                                    switch (arrow_position)
                                    {
                                        case 0:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("-> 1111111111111111111");
                                                Console.WriteLine("   2222222222222222222");
                                                Console.WriteLine("   3333333333333333333" + "\n");

                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 2;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 1;

                                                break;
                                            }
                                        case 1:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("   1111111111111111111");
                                                Console.WriteLine("-> 2222222222222222222");
                                                Console.WriteLine("   3333333333333333333" + "\n");


                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 0;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 2;

                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("   1111111111111111111");
                                                Console.WriteLine("   2222222222222222222");
                                                Console.WriteLine("-> 3333333333333333333" + "\n");


                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 1;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 0;

                                                break;
                                            }
                                    }
                                }
                                switch (arrow_position)
                                {
                                    case 0:
                                        positional_value = 0;
                                        break;
                                    case 1:
                                        positional_value = 0;
                                        break;
                                    case 2:
                                        positional_value = 0;
                                        break;
                                }
                            }
                            break;
                        }
                }
            }
        }
    }
}
