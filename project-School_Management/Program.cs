using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_School_Management
{
    // PROJECT BY Matthieu Perret (24475), Lucie Mallet (24470), Mathis Tiberghien (24445), Benoit Jaffuel (24431)
    class Program
    {
        static void Main(string[] args)
        {
            //ActionForAdmin.AddStudent();
            //Console.ReadKey();
            //ActionForAdmin.AddCourse();
            //Console.ReadKey();
            //Action.SeeTimetable(StudentList.studentlist["Mathis-Tiberghien"]);


            // Just adding one student to begin
            string firstname = "Benoit";
            firstname = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(firstname.ToLower()); 
            string famname = "Jaffuel";
            famname = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(famname.ToLower());
            Student BJ = new Student(firstname, famname, "09/03/2001", "male");
            StudentList.studentlist.Add(firstname + "-" + famname, BJ);

            
            RunSyst A = new RunSyst();
            Console.ReadKey();


        }
    }
}
