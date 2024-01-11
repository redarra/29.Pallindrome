using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _29.Pallindrome
{
    internal class Program
    {//this is for a and b as part b can just be saved as a string and processed the same way
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like code A that works for letters and numbers or code B that only works for numbers?");
            string procedure = Console.ReadLine();
            if (procedure == "A" || procedure == "a") { 
            Console.WriteLine("Enter Pallindrome");
            string text = Console.ReadLine();
            char[] charArray = text.ToCharArray();

            string reversedString = "";
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }
            if (text.Equals(reversedString)) { Console.WriteLine($"{text} is a pallindrome"); }
            else { Console.WriteLine($"{text} is not a pallindrome"); }
        }
        else if(procedure=="b" || procedure=="B"){
            Console.WriteLine("Enter Pallindrome");
                int num, rev, sum = 0, temp;
                num = int.Parse(Console.ReadLine());
             
                temp = num;
                while (num > 0)
                {
                    rev = num % 10;
                    sum = (sum * 10) + rev;
                    num = num / 10;
                }
                if (temp == sum)
                    Console.Write($"{temp} is a pallindrome");
                else
                    Console.Write($"{temp} is not a pallindrome");
            }

            
        }
    }
}