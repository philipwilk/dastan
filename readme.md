# Task 5        Marks: 5

This question refers to the PlayGame method of the Dastan class and the creation of a new method GetJustQueueAsString in the Player class.

Introduce a new option 8 to the main game playing menu. On selecting this option, a player can look at their opponent’s queue to spy what move options their opponent might be considering next.

Spying on an opponent’s queue, however, carries a cost of 5 points from the player’s score. After spying on an opponent’s queue, the player’s turn should continue as normal.

## What you need to do

## Task 1

Create a new method in the Player class called GetJustQueueAsString which uses the GetQueueAsString method to return a string version of just the player’s queue.

## Task 2

Modify the PlayGame method to introduce new functionality which adds a new option 8 to the main game playing menu. If the user selects this option, display the move option queue for the opposing player.

(Hint: You can check the current player using the SameAs method and then pick the other player.)

Subtract 5 from the current player score and display the game state again allowing the player to continue their turn as normal.

## Task 3

Test that the changes you have made work:

- run the skeleton program.
- show player one selecting option 8 from the main game menu.
- show the opponent queue being displayed clearly on the screen and the player one score reducing by 5 points.
