using System;
using System.IO;
using System.Collections.Generic;

namespace No_to_the_List
{
    class Program
    {
        static void Main(string[] args)
        {

            string Studentpath = @"C:\Users\David\Desktop\Para Borrar\SAS.txt";
            string[] arrStudents = File.ReadAllLines(@Studentpath);
            if ((!File.Exists(@"C:\Users\David\Desktop\Para Borrar\Answer.txt")))
            {
                TextWriter tw = new StreamWriter(@"C:\Users\David\Desktop\Para Borrar\Answer.txt");

                foreach (String s in arrStudents)
                {
                    
                    string[] arr = s.Split(" ");
                    if (s!="")
                    {
                        tw.WriteLine(" G.AddEdge(" + arr[0] + "," + arr[1] + "," + arr[2] + ");");
                    }
                  
                }

                tw.Close();
            }
            Console.WriteLine("DONE!!!!");
            Console.ReadKey();
        }
    }
}   
