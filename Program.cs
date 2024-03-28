using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace Izpitvane27._03._2024
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            Console.WriteLine(InputGrades(grades));
            Console.WriteLine(PrintEmptyGrades(grades));             
            Console.WriteLine(CountGrades);
            Console.WriteLine(PoGolemi(grades));
            Console.WriteLine($"moita {grades[8]}"); 
            Console.WriteLine($"poslednata-{grades[12]}"); 
            Console.WriteLine(CalculateAverageMiddle); 
            grades[8] = 6; 
            Console.WriteLine("moita ocenka: " + grades[8]);
            //imeto
            Console.Write("dai ime: ");
            string name = Console.ReadLine();
            Console.WriteLine("imeto: " + Replace(name)); 
        }



        static int InputGrades(List<int>grades)
        {           
            for (int i = 14; i <=26; i++)
            {
                Console.Write($"Dai ocenka na {i}: ");
                grades.Add(int.Parse(Console.ReadLine()));
            }
            return 0;    
        }

        static int PrintEmptyGrades(List<int> grades)
        {
            int count= 0;   
            for (int i = 14; i <= 26; i++)
            {
                if (grades[i] == 0)
                {
                    count++;
                    Console.WriteLine($"uchenika {i} nqma ocenka.");
                }
            }return count;
        }

        static int CountGrades(List <int> grades)
        {
           int count = 0;
           for(int i = 0;i < grades.Count; i++)
            {
                if (grades[i] == 6)
                {
                    count++;
                    Console.WriteLine($"uchenik{i} ima 6");
                }
            }return count;
        }

        static int PoGolemi(List<int> grades)
        {
            int count = 0;
            for(int i = 0; i < grades.Count; i++)
            {
                if (grades[8] < grades[i])
                {
                    count++;
                    Console.WriteLine($"{grades[i]}e > ot moqta");
                }
            }
            return count;       
        }

        static double CalculateAverageMiddle(List<double>grades)
        {
            int count = 0;
            double average = 0;
            double sum = 0;
            int mid= grades.Count / 2;
            for (int i = 14; i <= 26; i++)
            {
                if (grades[i] == mid)
                {
                count++;
                sum += grades[i];
                average= sum/count;
                Console.WriteLine(average);
                }                            
            }
            return average;
        }

        static string Replace(string name)
        {
            int middleIndex = name.Length / 2;
            if (name.Length % 2 == 0)
            {
                return name.Substring(0, middleIndex - 1) + "@" + name.Substring(middleIndex + 1);
            }
            else
            {
                return name.Substring(0, middleIndex) + "@" + name.Substring(middleIndex + 1);
            }
        }
    }
}