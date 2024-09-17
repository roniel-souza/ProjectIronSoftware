# Old-Style Telephone Keypad Simulator

## Description
This program simulates the behavior of an old-style telephone keypad where each numeric key corresponds to several letters. Users can press the key multiple times to select the desired letter.

## Functionality

- **Key sequence conversion**: Transforms a sequence of pressed keys into a corresponding string of letters.
- **Repeat handling**: Counts the number of consecutive key presses to determine the correct letter.
- **Special character handling**: Recognizes the `#` (send) and `*` (delete) characters to control input termination and character removal, respectively.

## Code Structure

- **`OldPhone` class**: Contains the main `ConvertKeypadToText` method responsible for converting the key sequence into text.
- **`ConvertKeypadToText` method**: Maps each numeric key to its corresponding letters. Iterates over the input sequence, counting repetitions of each key and adding the corresponding letters to the result. Handles special characters `#` and `*` according to their functions.
- **`GetLetterFromRepeatCount` method**: Calculates the index of the correct letter based on the number of key repetitions.

## Testing

The program includes a series of tests to verify the correct functioning of the different features:

1. **Test 1**: Checks the conversion of a simple key sequence (`"33#"`) to the letter **"E"**.
2. **Test 2**: Tests the combination of key repetitions and the use of the `*` character to delete (`"227#"`).
3. **Test 3**: Verifies the conversion of a complete sentence with spaces (`"4433555 555666096667775553#"`).
4. **Test 4**: Tests the functionality of the `*` character to delete multiple characters (`"4433*22#"`).
5. **Test 5**: Checks the program's behavior for an empty input (`"#"`).
6. **Test 6**: Tests the conversion of a sequence with consecutive repetitions of the same key (`"222 2 22#"`).

Each test prints the input, the obtained output, and the expected output to the console for easy verification of the results.

## How to Use

To use the program, simply run the code and the tests will be executed automatically, displaying the results in the console.

## Notes

- The program assumes that the input is valid, i.e., it only contains numeric digits, `#` and `*`.
- The order of the letters on each key corresponds to the traditional order of telephone keypads.