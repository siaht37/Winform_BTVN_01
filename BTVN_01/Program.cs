using System;

class BTVN_01
{
    static void Main()
    {
        Random random = new Random();
        int targetNumber = random.Next(100, 999);
        string targetString = targetNumber.ToString();
        int maxAttempts = 7;

        Console.WriteLine("------------Chuong trinh doan so!--------------");
        Console.WriteLine("Vui long nhap 1 so tu 100 den 999");

        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
            Console.Write($"Nhap lan {attempt}: Doan di: ");
            string guess = Console.ReadLine();

            if (guess.Length != 3)
            {
                Console.WriteLine("Vui long nhap toi da 3 ky tu");
                attempt--;
                continue;
            }

            if (guess == targetString)
            {
                Console.WriteLine("Dung oyyyyyyy");
                Console.ReadKey();
                return;
            }

            string response = GetFeedback(targetString, guess);
            Console.WriteLine($"Response: {response}");
        }

        Console.WriteLine($"Ban da nhap sai {maxAttempts} lan. So can doan la {targetString}.");
        Console.ReadKey();
    }

    static string GetFeedback(string target, string guess)
    {
        string feedback = "";
        for (int i = 0; i < target.Length; i++)
        {
            if (target[i] == guess[i])
            {
                feedback += "+";
            }
            else if (target.Contains(guess[i].ToString()))
            {
                feedback += "?";
            }
            else
            {
                feedback += "_";
            }
        }
        return feedback;
    }
}
