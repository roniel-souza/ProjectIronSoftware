using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Test 1: Testing "33#"
        string input1 = "33#";
        string result1 = OldPhone.ConvertKeypadToText(input1);
        Console.WriteLine($"Input: {input1} => Output: {result1}"); // Expected: "E"

        // Test 2: Testing "227*#"
        string input2 = "227*#";
        string result2 = OldPhone.ConvertKeypadToText(input2);
        Console.WriteLine($"Input: {input2} => Output: {result2}"); // Expected: "B"

        // Test 3: Testing "4433555 555666096667775553#"
        string input3 = "4433555 555666096667775553#";
        string result3 = OldPhone.ConvertKeypadToText(input3);
        Console.WriteLine($"Input: {input3} => Output: {result3}"); // Expected: "HELLO WORLD"

        // Test 4: Testing with multiple backspaces
        string input4 = "44*33*22#";
        string result4 = OldPhone.ConvertKeypadToText(input4);
        Console.WriteLine($"Input: {input4} => Output: {result4}"); // Expected: "A"

        // Test 5: Empty test
        string input5 = "#";
        string result5 = OldPhone.ConvertKeypadToText(input5);
        Console.WriteLine($"Input: {input5} => Output: {result5}"); // Expected: ""

        // Test 6: Testing consecutive characters on the same button
        string input6 = "222 2 22#";
        string result6 = OldPhone.ConvertKeypadToText(input6);
        Console.WriteLine($"Input: {input6} => Output: {result6}"); // Expected: "CAB"
    }
}