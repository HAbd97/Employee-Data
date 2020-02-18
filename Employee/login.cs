using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class login
    {
        public void log()
        {
            string readData, name;
            string[] data = new string[100];
            string[] datum = new string[100];
            string[] item = new string[100];
            int user = 0;

            Console.WriteLine("Enter the name : ");
            name = Console.ReadLine();
            using (TextReader read = File.OpenText("C:/Users/humam/Google Drive/Naico Assignments/Humam Abdullah/.Net Tasks/Task_1/Employee/Employee/Emp_det.txt"))
            {
                readData = read.ReadToEnd();
                char[] WhiteSpace = new char[] { ' ' };
                string[] split = readData.Split(WhiteSpace, StringSplitOptions.RemoveEmptyEntries);
                string compactedString = string.Join("", split);
                Console.WriteLine("_____________________________________________________");
                for (int i = 0; i < compactedString.Split('-').Length; i++)
                {
                    datum[i] = compactedString.Split('-')[i];
                    for (int j = 0; j < datum[i].Split(',').Length; j=j+5)
                    {
                        data[j] = datum[i].Split(',')[j];
                        for (int k = 1; k < data[j].Split(':').Length; k++)
                        {
                            item[k] = data[j].Split(':')[k];
                            if (name == item[k])
                            {
                                Console.WriteLine("Successful login as " + item[k]);
                                user = 1;
                                break;
                            }
                        }
                    }
                }
                if(user != 1)
                {
                    Console.WriteLine("User Not Found");
                }


            }

        }
    }
}
