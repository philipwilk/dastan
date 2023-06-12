# Task 7        Marks: 5

This question refers to the PlayGame and UseMoveOptionOffer methods in the Dastan class and the creation of a new attribute ChoiceOptionsLeft along with accessor and mutator (getter/setter) methods DecreaseChoiceOptionsLeft and GetChoiceOptionsLeft in the Player class.

Currently a player can repeatedly select option 9 from the main game playing menu, filling their queue with new move options.

Introduce a limit so that a player can only ‘accept the offer’ from the Move Option menu three times in a game. Each time a player accepts the offer, advise them of how many selections they have left and remove the menu for that player once they have used it three times.

## What you need to do

## Task 1

Modify the Player class to introduce a new private attribute called ChoiceOptionsLeft.

- Initialise ChoiceOptionsLeft to 3.
- Create a new accessor method called GetChoiceOptionsLeft which returns the value of the attribute ChoiceOptionsLeft.
- Create a new mutator method called DecreaseChoiceOptionsLeft which decrements the ChoiceOptionsLeft attribute.

## Task 2

Modify the PlayGame method to test the number of options the player has left so that they can only use three during the game.

- Modify the PlayGame method so that if the player has used up all their option choices, option 9 will no longer be available to the player.
- Modify the UseMoveOptionOffer method so that when a move option is selected by the player, the number of options available to them decreases by one. Advise the player how many option choices they have left.

## Task 3

Test that the changes you have made work:

- run the skeleton program.
- select four sequential option moves from the move option list adding them to positions 1 to 4 in the player one queue.
- show the removal of option 9 from the main game playing menu and show that it does nothing if the player attempts to select option 9
