using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class register
    {
        public void reg()
        {
            string name;
            string occupation;
            string experience;

            Console.WriteLine("Enter the name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the designation : ");
            occupation = Console.ReadLine();
            Console.WriteLine("Enter the experience : ");
            experience = Console.ReadLine();

            string nam = name.Substring(0, 3);
            string upnam = nam.ToUpper();

            Random rand = new Random();
            int randEmp = rand.Next(1, 100);


            DateTime dt = new DateTime();
            string day = dt.Day.ToString();
            string month = dt.Month.ToString();
            string year = dt.Year.ToString();
            string msecond = dt.Millisecond.ToString();

            using (TextWriter write = File.AppendText("C:/Users/humam/Google Drive/Naico Assignments/Humam Abdullah/.Net Tasks/Task_1/Employee/Employee/Emp_det.txt"))
            {
                write.WriteLine("Name : " + name + ",");
                write.WriteLine("Occupation : " + occupation + ",");
                write.WriteLine("Experience : " + experience + ",");
                write.WriteLine("Employee code : " + upnam + randEmp + year + month + day + msecond);
                write.WriteLine(".");
            }

        }
    }
}
