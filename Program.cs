using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== 簡単計算機 ===");

        double num1 = ReadDouble("1つ目の数字: ");
        double num2 = ReadDouble("2つ目の数字: ");

        Console.WriteLine($"足し算: {num1 + num2}");
        Console.WriteLine($"引き算: {num1 - num2}");
        Console.WriteLine($"掛け算: {num1 * num2}");

        // 0除算対策
        if (num2 != 0)
        {
            Console.WriteLine($"割り算: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("割り算: 0では割れません");
        }
    }

    // 安全にdoubleを受け取る（数字以外なら再入力）
    static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double value))
            {
                return value;
            }

            Console.WriteLine("数値として読み取れません。例: 12.3 のように入力してください。");
        }
    }
}