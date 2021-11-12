On creation of a story object you pass in the parameters StoryLocation and StoryTitle
# Class Variables
## StoryLocation (string)
Text location of the story.txt file

## StoryTitle (string)
Name of the story file, combined with location can give file path of story

## CurrentStoryText (LinkedList<string>)
A linked list with read in story lines, used to control story progression flow

## Current_Action (Markup)
A current running action based on what was parsed (aka #CT means to change text which would change the current running action to the ChangeText enum from Markup enum

# Functions
## ChangeStory (returns void, takes in string newStoryTitle as a parameter and string newStoryLocation and bool insert as optional parameters)
Reads in story file based on location and name. Appends the text to the CurrentStoryText linked list. If insert is true, the lines are inserted to the front of the list (but are reversed prior in order to keep order)

## ReadInStory (returns void, takes in bool insert)
Does the actual file reading and insertion based on insert value described in ChangeStory

## ParseLine (returns void, takes no parameters)
Takes the top line from the the currentstorytext linked lists, parses the first index of spaced out inputs, checks what it is equal to, and then changes the Current_Action markup before removing the markup value from the top and then reinserting the line

## GetNextLine (returns string, takes no parameters)
Checks if CurrentStoryText is empty, if so closes the application, if not parses the input using parse line, and removes the new line from the top of the linked list before returning it.

## Empty (returns bool, takes no parameters)
Checks if CurrentStoryText is empty
