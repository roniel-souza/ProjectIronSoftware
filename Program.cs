using System;
using System.Collections.Generic;
using System.Linq;

public class KeyPadToNumber
{
    private static readonly Dictionary<char, object> CharactersMap = new Dictionary<char, object>()
    {
        { '1', new[] { '&', '\'', '(' } },
        { '2', new[] { 'A', 'B', 'C' } },
        { '3', new[] { 'D', 'E', 'F' } },
        { '4', new[] { 'G', 'H', 'I' } },
        { '5', new[] { 'J', 'K', 'L' } },
        { '6', new[] { 'M', 'N', 'O' } },
        { '7', new[] { 'P', 'Q', 'R', 'S' } },
        { '8', new[] { 'T', 'U', 'V' } },
        { '9', new[] { 'W', 'X', 'Y', 'Z' } },
        { '0', new[] { ' ' } },
        { ' ', (string result) => result },
        { '#', (string result) => result },
        { '*', (string result) => result.Substring(0, result.Length - 1) }
    };

    private static string ExecuteInputButton(string text, char character, int pressed)
    {
        if (CharactersMap[character] is char[] keypad)
        {
            return $"{text}{keypad[pressed]}";
        }

        var keypadFunction = (Func<string, string>)CharactersMap[character];
        return keypadFunction(text);
    }

    public static string ConvertKeyPadInput(string input)
    {
        var finalText = "";
        var indexCount = -1;
        var lastCharacter = '\0';

        foreach (var currentCharacter in input)
        {
            if (currentCharacter == lastCharacter)
            {
                indexCount++;
                continue;
            }

            if (indexCount > -1)
            {
                finalText = ExecuteInputButton(finalText, lastCharacter, indexCount);
            }

            lastCharacter = currentCharacter;
            indexCount = 0;
        }

        return finalText;
    }

    public static void Main()
    {
        var input1 = "33#";
        var input2 = "227*#";
        var input3 = "4433555 555666096667775553#";
        var input4 = "44*33*22#";
        var input5 = "#";
        var input6 = "222 2 22#";

        Console.WriteLine($"Input: \"{input1}\"\nResult: {ConvertKeyPadInput(input1)}\n");
        Console.WriteLine($"Input: \"{input2}\"\nResult: {ConvertKeyPadInput(input2)}\n");
        Console.WriteLine($"Input: \"{input3}\"\nResult: {ConvertKeyPadInput(input3)}\n");
        Console.WriteLine($"Input: \"{input4}\"\nResult: {ConvertKeyPadInput(input4)}\n");
        Console.WriteLine($"Input: \"{input5}\"\nResult: {ConvertKeyPadInput(input5)}\n");
        Console.WriteLine($"Input: \"{input6}\"\nResult: {ConvertKeyPadInput(input6)}\n");
    }
}