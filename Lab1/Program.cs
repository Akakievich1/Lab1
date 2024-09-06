using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "29535123p48723487597645723645";
        Console.WriteLine();

        long totalSum = 0;
        int length = input.Length;

        for (int i = 0; i < length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                char startChar = input[i];

                int j = input.IndexOf(startChar, i + 1); 

                while (j != -1 && j < length)
                {
                    if (char.IsDigit(input[j]))
                    {
                        string number = input.Substring(i, j - i + 1);  

                        if (number.Length > 1)
                        {
                            bool isValidNumber = true;
                            foreach (char c in number)
                            {
                                if (!char.IsDigit(c))
                                {
                                    isValidNumber = false;
                                    break;
                                }
                            }

                            if (isValidNumber)
                            {
                                Console.Write(input.Substring(0, i));

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(number);
                                Console.ResetColor();

                                Console.WriteLine(input.Substring(j + 1)); 

                                totalSum += long.Parse(number); 
                                break;
                            }
                        }
                        j = input.IndexOf(startChar, j + 1); 
                    }
                    else
                    {
                        j = input.IndexOf(startChar, j + 1); 
                    }
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Summan av giltiga tal: {totalSum}");
    }
}
