using System;
using System.Collections.Generic;
using System.Text;

public class OldPhone
{
    /// <summary>
    /// Converts a sequence of keypad presses into a corresponding text string.
    /// </summary>
    /// <param name="keypadSequence">The sequence of keypad button presses.</param>
    /// <returns>The corresponding text string.</returns>
    public static string ConvertKeypadToText(string keypadSequence)
    {
        if (string.IsNullOrEmpty(keypadSequence))
        {
            return string.Empty; // Return an empty string for empty input
        }

        // Map each digit to the corresponding letters on a traditional phone keypad.
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
                // When the 'send' key is pressed, add the last letter and reset.
                if (lastDigit != '\0' && repeatCount > 0)
                {
                    result.Append(GetLetterFromRepeatCount(keypadMapping, lastDigit, repeatCount));
                }
                break; // Exit the loop
            }
            else if (digit == '*')
            {
                // Delete the last character
                if (result.Length > 0)
                {
                    result.Length--;
                }
            }
            else if (keypadMapping.ContainsKey(digit))
            {
                // If the same digit is pressed multiple times, increment the repeat count.
                if (digit == lastDigit)
                {
                    repeatCount++;
                }
                else
                {
                    // If a new digit is pressed, add the previous letter and reset the repeat count.
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

    /// <summary>
    /// Gets the letter corresponding to a repeated digit press.
    /// </summary>
    private static char GetLetterFromRepeatCount(IReadOnlyDictionary<char, string> keypadMapping, char digit, int repeatCount)
    {
        var letters = keypadMapping[digit];
        var index = (repeatCount - 1) % letters.Length;
        return letters[index];
    }
}