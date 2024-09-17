using System;
using System.Collections.Generic;
using System.Text;

public class OldPhone
{
    public static string ConvertKeypadToText(string keypadSequence)
    {
        if (string.IsNullOrEmpty(keypadSequence))
        {
            return string.Empty;
        }

        var keypadMapping = new Dictionary<char, string>
        {
            {'2', "ABC"},
            {'3', "DEF"},
            {'4', "GHI"},
            {'5', "JKL"},
            {'6', "MNO"},
            {'7', "PQRS"},
            {'8', "TUV"},
            {'9', "WXYZ"}
        };

        var result = new StringBuilder();
        char lastDigit = '\0';
        int repeatCount = 0;

        foreach (char digit in keypadSequence)
        {
            if (digit == '#')
            {
                if (lastDigit != '\0' && repeatCount > 0)
                {
                    result.Append(GetLetterFromRepeatCount(keypadMapping, lastDigit, repeatCount));
                }
                break;
            }
            else if (digit == '*')
            {
                if (result.Length > 0)
                {
                    result.Length--;
                }
            }
            else if (keypadMapping.ContainsKey(digit))
            {
                if (digit == lastDigit)
                {
                    repeatCount++;
                }
                else
                {
                    if (lastDigit != '\0' && repeatCount > 0)
                    {
                        result.Append(GetLetterFromRepeatCount(keypadMapping, lastDigit, repeatCount));
                    }
                    lastDigit = digit;
                    repeatCount = 1;
                }
            }
        }

        return result.ToString();
    }

    private static char GetLetterFromRepeatCount(IReadOnlyDictionary<char, string> keypadMapping, char digit, int repeatCount)
    {
        var letters = keypadMapping[digit];
        var index = (repeatCount - 1) % letters.Length;
        return letters[index];
    }
}