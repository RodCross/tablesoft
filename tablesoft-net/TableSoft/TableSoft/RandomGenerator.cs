using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableSoft
{
    public class RandomGenerator
    {
        public static string GenerateRandomPassword()
        {
            Random random = new Random();
            string characters = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ123456789";
            int length = characters.Length;
            char letter;
            int passLength = 8;
            string randomPassword = string.Empty;

            for (int i = 0; i < passLength; i++)
            {
                letter = characters[random.Next(length)];
                randomPassword += letter.ToString();
            }

            return randomPassword;
        }
        public static string GenerateRandomCode()
        {
            Random r = new Random();
            int randNum = r.Next(1000000);

            return randNum.ToString("D6");
        }
    }
}
