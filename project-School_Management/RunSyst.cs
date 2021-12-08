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
                                while (answer != "Student" && answer != "Facultee" && answer != "Admin" && index_error <= 5)
                                {
                                    Console.WriteLine("Identify yourself !" + "\n");
                                    Console.WriteLine("Type Student if you are a student, Facultee if you are a facultee or Admin if you are an admin" + "\n");
                                    answer = Convert.ToString(Console.ReadLine());
                                    index_error++;
                                }

                                if (index_error >= 5)
                                {
                                    Console.WriteLine("To much attempt: Retry...");
                                    Console.ReadKey();
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

                            Console.WriteLine("-> See Timetable");
                            Console.WriteLine("   Pay Fee" + "\n");


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
                                                Console.WriteLine("-> See Timetable");
                                                Console.WriteLine("   Pay Fee" + "\n");

                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 1;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 1;

                                                break;
                                            }
                                        case 1:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("   See Timetable");
                                                Console.WriteLine("-> Pay Fee" + "\n");


                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 0;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 0;

                                                break;
                                            }
                                    }
                                }
                                switch (arrow_position)
                                {
                                    case 0:
                                        positional_value = 4;
                                        break;
                                    case 1:
                                        positional_value = 5; 
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
                            Console.WriteLine("   Add an Assignement");
                            Console.WriteLine("   Add an Exam");
                            Console.WriteLine("   Show student Results" + "\n");


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
                                                Console.WriteLine("   Add an Assignement");
                                                Console.WriteLine("   Add an Exam");
                                                Console.WriteLine("   Show student Results" + "\n");

                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 4;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 1;

                                                break;
                                            }
                                        case 1:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("   Add grade to an Exam");
                                                Console.WriteLine("-> Add grade to an Assignement");
                                                Console.WriteLine("   Add an Assignement");
                                                Console.WriteLine("   Add an Exam");
                                                Console.WriteLine("   Show student Results" + "\n");


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
                                                Console.WriteLine("-> Add an Assignement");
                                                Console.WriteLine("   Add an Exam");
                                                Console.WriteLine("   Show student Results" + "\n");


                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 1;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 3;

                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("   Add grade to an Exam");
                                                Console.WriteLine("   Add grade to an Assignement");
                                                Console.WriteLine("   Add an Assignement");
                                                Console.WriteLine("-> Add an Exam");
                                                Console.WriteLine("   Show student Results" + "\n");


                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 2;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 4;

                                                break;
                                            }
                                        case 4:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("   Add grade to an Exam");
                                                Console.WriteLine("   Add grade to an Assignement");
                                                Console.WriteLine("   Add an Assignement");
                                                Console.WriteLine("   Add an Exam");
                                                Console.WriteLine("-> Show student Results" + "\n");


                                                Console.WriteLine("PRESS ENTER TO SELECT");
                                                Console.WriteLine("PRESS ESCAPE TO RETURN");

                                                UserKey = Console.ReadKey();
                                                if (UserKey.Key == ConsoleKey.UpArrow)
                                                    arrow_position = 3;
                                                else if (UserKey.Key == ConsoleKey.DownArrow)
                                                    arrow_position = 0;

                                                break;
                                            }
                                    }
                                }
                                switch (arrow_position)
                                {
                                    case 0:
                                        positional_value = 6;
                                        break;
                                    case 1:
                                        positional_value = 7; 
                                        break;
                                    case 2:
                                        positional_value = 12;
                                        break;
                                    case 3:
                                        positional_value = 13;
                                        break;
                                    case 4:
                                        positional_value = 8;
                                        break;
                                }
                            }
                            break;
                        }
                    case 3: // --------------------------------Admin branch --------------------------------
                        {
                            Console.Clear();

                            Console.WriteLine("-> Add Student");
                            Console.WriteLine("   Add Course");
                            Console.WriteLine("   See if a student paid his fees" + "\n");


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
                                                Console.WriteLine("-> Add Student");
                                                Console.WriteLine("   Add Course");
                                                Console.WriteLine("   See if a student paid his fees" + "\n");

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
                                                Console.WriteLine("   Add Student");
                                                Console.WriteLine("-> Add Course");
                                                Console.WriteLine("   See if a student paid his fees" + "\n");


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
                                                Console.WriteLine("   Add Student");
                                                Console.WriteLine("   Add Course");
                                                Console.WriteLine("-> See if a student paid his fees" + "\n");


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
                                        positional_value = 9;
                                        break;
                                    case 1:
                                        positional_value = 10;
                                        break;
                                    case 2:
                                        positional_value = 11;
                                        break;
                                }
                            }
                            break;
                        }
                    case 4: // --------------------------------Student branch (See Timetable)--------------------------------
                        {
                            Console.Clear();
                            Student student = StudentList.FromKeyToStudent();

                            Console.Clear();
                            Action.SeeTimetable(student);

                            positional_value = 1;
                            break;
                        }
                    case 5: // --------------------------------Student branch (Pay Fee)--------------------------------
                        {
                            Console.Clear();
                            Student student = StudentList.FromKeyToStudent();

                            Console.Clear();
                            Action.PayFee(student);

                            positional_value = 1;
                            break;
                        }
                    case 6: // --------------------------------Facultee branch (Add grade Exam)--------------------------------
                        {
                            Console.Clear();

                            ActionForFacultee.AddGradeToExam();

                            positional_value = 2;
                            break;
                        }
                    case 7: // --------------------------------Facultee branch (Add grade Assignement)--------------------------------
                        {
                            Console.Clear();

                            ActionForFacultee.AddGradeToAssignement();

                            positional_value = 2;
                            break;
                        }
                    case 8: // --------------------------------Facultee branch (Show Student Results)--------------------------------
                        {
                            Console.Clear();

                            ActionForFacultee.ShowStudentResults();

                            positional_value = 2;
                            break;
                        }
                    case 9: // --------------------------------Admin branch (Add Student)--------------------------------
                        {
                            Console.Clear();
                            ActionForAdmin.AddStudent();

                            positional_value = 3;
                            break;
                        }
                    case 10: // --------------------------------Admin branch (Add Course)--------------------------------
                        {
                            Console.Clear();
                            ActionForAdmin.AddCourse();

                            positional_value = 3;
                            break;
                        }
                    case 11: // --------------------------------Admin branch (See if Paid)--------------------------------
                        {
                            Console.Clear();
                            ActionForAdmin.SeeIfPaid();

                            positional_value = 3;
                            break;
                        }
                    case 12: // --------------------------------Facultee branch (Add Assignement)--------------------------------
                        {
                            Console.Clear();

                            ActionForFacultee.AddAssigment();

                            positional_value = 2;
                            break;
                        }
                    case 13: // --------------------------------Facultee branch (Add Exam)--------------------------------
                        {
                            Console.Clear();

                            ActionForFacultee.AddExam();

                            positional_value = 2;
                            break;
                        }
                }
            }
        }
    }
}
