using System;
using System.Collections.Generic;

public class OTPGenerator
{
    // Method to generate a 6-digit OTP using Math.Random()
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000); // Generates a number between 100000 and 999999
    }

    // Method to save 10 OTPs in an array
    public static int[] GenerateMultipleOTPs(int count)
    {
        int[] otps = new int[count];
        for (int i = 0; i < count; i++)
        {
            otps[i] = GenerateOTP();
        }
        return otps;
    }

    // Method to check if all OTPs in the array are unique
    public static bool AreOTPsUnique(int[] otps)
    {
        HashSet<int> uniqueCheck = new HashSet<int>(otps);
        return uniqueCheck.Count == otps.Length;
    }

    public static void Main(string[] args)
    {
        int count = 10; // Number of OTPs to generate
        int[] otpArray = GenerateMultipleOTPs(count);

        Console.WriteLine("Generated OTPs: " + string.Join(", ", otpArray));

        bool isUnique = AreOTPsUnique(otpArray);
        Console.WriteLine("Are all OTPs unique? " + (isUnique ? "Yes" : "No"));
    }
}
