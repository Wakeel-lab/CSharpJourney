using System;

namespace CSharpJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allowedCharacters = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Console.WriteLine(GenerateRandomOTP(5, allowedCharacters)); 
        }

        public static string GenerateRandomOTP(int OTPLength, string[] allowedCharacters)
        {
            string OTP = string.Empty;
            string tempCharacters = "";

            Random randomNumbers = new Random();

            for (int i = 0; i < OTPLength; i++)
            {
                int randomOTP = randomNumbers.Next(0, allowedCharacters.Length);
                tempCharacters = allowedCharacters[randomOTP];
                OTP += tempCharacters;
            }

            return OTP;
        }
    }
}
