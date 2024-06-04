using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userString = "121";


            Console.WriteLine(IsPalindrome(userString));

            bool IsPalindrome(string input) 
            {
                int L = 0;
                int R = input.Length - 1;

                while (L < R)
                {
                    if (userString[0] == userString[R])
                    {
                        L++;
                        R--;
                    }
                    else 
                    {
                        return false;
                    } 
                }
                return true;
            }      
                
                
                
                    
                

            
            
            

        }
    }
}
