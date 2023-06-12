# Task 4        Marks: 5

This question refers to the PlayGame method in the Dastan class and creation of a new method AwardWafr in the Dastan class, and GetWafrAwarded and SetWafrAwarded together with a new attribute WafrAwarded in the Player class.

Create a ‘Wafr’ award (Abundance) which can be applied to either player once per game. The Wafr has a 25% chance of being awarded to a player on their turn.

On receipt of the Wafr, the player has the option of ANY move from their move queue rather than just being able to select from the first three items. The Wafr award removes the move cost for the move the player selects for that turn.

Note: If the player makes an invalid move then they ‘lose’ their Wafr and get no value from it. Also the player should not be able to ‘take the offer’ if a Wafr is awarded.

## What you need to do

## Task 1

- Create a new method in the Dastan class called AwardWafr. This method should have a 25% chance of returning true.
- Add a new private attribute to the Player class called WafrAwarded. Include accessor and mutator (getter/setter) methods for this attribute.

## Task 2

Update the PlayGame method in the Dastan class to call the new AwardWafr method.

If the player hasn’t already been awarded a Wafr, print out a message saying ‘You have been awarded a Wafr, you can select any move from your queue for free this turn.’

Adjust the input range to allow any move option in the queue to be selected. Ensure that there is no score adjustment for playing a move, and update the value of the attribute to ensure that they cannot receive another Wafr.

## Task 3

Test that the changes you have made work:

- run the skeleton program.
- play the game to show a player being awarded a Wafr
- play a move option from position 4 or 5 in the move option queue.
- show the updated board and correctly modified score.
