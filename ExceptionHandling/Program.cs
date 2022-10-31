using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class AgeException : Exception
    {
        public AgeException(string msg) : base(msg)
        {
        }

    }
    public class User
    {
        public void AcceptAge(int age)
        {
            if (age < 18)
            {
                throw new AgeException("Your age is not valid for vote, ");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                user.AcceptAge(age);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
