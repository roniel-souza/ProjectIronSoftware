using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input1 = "33#";
        string result1 = OldPhone.ConvertKeypadToText(input1);
        Console.WriteLine($"Input: {input1} => Output: {result1}");

        string input2 = "227*#";
        string result2 = OldPhone.ConvertKeypadToText(input2);
        Console.WriteLine($"Input: {input2} => Output: {result2}");

        string input3 = "4433555 555666096667775553#";
        string result3 = OldPhone.ConvertKeypadToText(input3);
        Console.WriteLine($"Input: {input3} => Output: {result3}");

        string input4 = "44*33*22#";
        string result4 = OldPhone.ConvertKeypadToText(input4);
        Console.WriteLine($"Input: {input4} => Output: {result4}");

        string input5 = "#";
        string result5 = OldPhone.ConvertKeypadToText(input5);
        Console.WriteLine($"Input: {input5} => Output: {result5}");

        string input6 = "222 2 22#";
        string result6 = OldPhone.ConvertKeypadToText(input6);
        Console.WriteLine($"Input: {input6} => Output: {result6}");
    }
}