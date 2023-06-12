# Task 8        Marks: 5

This question refers to the PlayGame method of the Dastan class and creation of new methods ResetQueueBack in the MoveOptionQueue class and ResetQueueBackAfterUndo in the Player class.

Introduce a new option that allows a player to undo their last move (after they have seen the result of it and before the next player makes their move), undoing any score gained or lost in that move and returning the game to its previous state. Undoing a move costs a player 5 points.  

After undoing a move, a player can then make an alternative move.

## What you need to do

## Task 1

Add the functionality to reset the queue if a move is undone.

- Create a new method in the MoveOptionQueue class called ResetQueueBack. This method should move the last element of the queue back to the original position in the queue.  The method should take one parameter, Position, which is the place to which the last element of the queue will be restored.
- Create a new method in the Player class called ResetQueueBackAfterUndo. This method should call the newly created ResetQueueBack method on the Queue attribute in the Player class. The method should take one parameter, Position, which is the choice that the player made from the menu.

## Task 2

Modify the PlayGame method to introduce the new functionality.

- If a move is legal, store the player score prior to the move.
- After displaying the board as a result of the move, give the player the option to undo it.
- If they choose to undo then: return the player score to the stored pre-move score, subtract 5 points and restore the board and the player’s queue back to their pre-move states.

## Task 3

Test that the changes you have made work:

- run the skeleton program.
- show player one attempt a ‘Chowkidar’ move and then undo the move and play a ‘Ryott’.
- show the game board after the undo and the score set correctly and that player one can choose a new move.
