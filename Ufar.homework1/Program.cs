// Sheroyan Magdalena
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ufar.homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* // Temperature condition
            Console.WriteLine("What's your current weather temperature?");
            int temp = Convert.ToInt32(Console.ReadLine());
            
            
            if( temp <= 0 ) { 
                Console.WriteLine(" Freezing cold");
                Console.ReadLine();
            }
            else if(  temp > 0 && temp <= 15 ) {
                Console.WriteLine("Outside is cold, wear warm cloths");
                Console.ReadLine();
            }
            else if( temp > 16 && temp <= 30)
            {
                Console.WriteLine("Nice weather for a walk");
                Console.ReadLine();
            }
            else if(temp > 31 && temp <= 40)
            {
                Console.WriteLine("It's hot outside");
                Console.ReadLine();
            }
            else { Console.WriteLine("Extremely hot");
                Console.ReadLine();
            }
            */

            /*
            //Categorize a person's age group
            Console.WriteLine("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            if(age < 0)
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
            }
            
             else if (age >= 0 && age < 13)
                {
                    Console.WriteLine("You're a child");
                    Console.ReadLine();
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine("You're a teenager");
                    Console.ReadLine();

                }
                else if (age >= 20 && age <= 116)
                {
                    Console.WriteLine("Congratulations, You're an adult");
                    Console.ReadLine();
                }
                else {
                    Console.WriteLine("You're dead");
                    Console.ReadLine();
                }
            */

            //Temperature convert

            /*
             Console.WriteLine("Choose 1 for Celsus to Fahreinheit convert \n " +
                 "Choose 2 for Fahrenheit to Celsus convert");

             int choice = Convert.ToInt32(Console.ReadLine());

             switch (choice)
             {
                 case 1:
                     Console.Write("Enter temperature in Celsius: ");
                     double celsius = Convert.ToDouble(Console.ReadLine());
                     double fahrenheit = (celsius * 9 / 5) + 32;
                     Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}°F");
                     Console.ReadLine();
                     break;
                 case 2:
                     Console.Write("Enter temperature in Fahrenheit: ");
                     double fah = Convert.ToDouble(Console.ReadLine());
                     double cel = ( fah - 32) * 5 / 9;
                     Console.WriteLine($"Equivalent temperature in Celsius: {cel}°C");
                     Console.ReadLine();
                     break;
             }

             */

            // max & min
            /*
            int[] arr = {4,9,8,5,10,19,4,3,2,1};
            int i, j, min = 1000, max = -1000;
            Array.Sort(arr); 
            foreach (var item in arr)
            {
                Console.Write(item);
                Console.ReadLine();
            }
            for (i = 0; i < arr.Length; i++)
            {
                
                if(max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }

            }
            Console.WriteLine($"Maximum number in arrray is {max}");
            Console.WriteLine($"Minumum number in array is {min} ");
            Console.ReadLine();
            */

            /*
            // Reverce array
            int[] arr = { 5, 7, 10, 11, 8 };
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }

            for(i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.ReadLine();
            }
            */

            /*
            //Second largest number in array
            int[] arr = { 4, 9, 10,8, 5, 19};
            int i, j;

            Array.Sort(arr);    
            Console.Write($"The second largest number in arry is {arr[arr.Length-2]}");
            Console.ReadLine();
            */

            /*
            int[] arr = { 5, 7, 10, 11, 8 };
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }

            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.ReadLine();
            }
            */
        }

    }
}
