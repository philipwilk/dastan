# Task 6        Marks: 5

This question refers to the PlayGame method together with the modification of GetSquareReference, UseMoveOptionOffer methods and creation of a new method GetValidInt in the Dastan class.

Currently the game has a number of areas where it does not handle erroneous user input.

Introduce error handling into the PlayGame, GetSquareReference and UserMoveOptionOffer methods to prevent unhandled exceptions from occurring if the user inputs data in an incorrect data type. Allow the user to re-enter their input, until it is valid.

Note: There is no need to check that the square contains a player piece or that the move is valid; the player should still have a wasted turn if the move is invalid, the purpose of this is to stop the program from crashing.

## What you need to do

## Task 1

Create a new private method called GetValidInt in the Dastan class which checks if the user input is a valid integer.  If the input is invalid, allow the user to keep trying again without penalty.

## Task 2

Modify the GetSquareReference method to use the new GetValidInt method to test for erroneous user input.  Add an error message if the user enters an invalid square.

## Task 3

Modify the UseMoveOptionOffer method to use the new GetValidInt method to test for erroneous user input and test to confirm that the user input is within the correct range.

## Task 4

Test that the changes you have made work:

- run the skeleton program.
- from the main game playing menu, enter ‘help’ as your choice and show a suitable error message. Then choose move 1.
- For player one, enter a square of 19 and show the error message. Then choose square 22.
- For player two, select option 9 to take the offer move and choose position 8. Show the error message.
