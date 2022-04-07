using System;
using System.Text;

namespace RandomPasswordApp
{
    class Program
    {
        public static string GetRandomPassword(int length)
        {
            const string chars = "0123456789abcdefghıjklmnoprstuvwxyzABCDEFGHIJKLMNOPRSTUVWXYZ.,_-*/(){}&+-#";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }
            return sb.ToString();

        }
        static void Main(string[] args)
        {
            int length = 10;
            string password = GetRandomPassword(length);
            Console.WriteLine(password);
        }
    }
}
