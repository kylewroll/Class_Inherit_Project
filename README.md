# Class_Inherit_Project

Author: Kyle Rolland
Date: 1/23/2021
File: README.md
Description: Short description of program and capabilities

This program is a simple test of inheritance and overriding in C#. It creates a base abstract Item class, and then creates 3 child classes: Vegetable, Textbook, and Toy_Car, which build upon the Item class. Each child class has its own singular private variable that is unique that class, and is used when providing information about that class. Vegetables have quality (as in how it looks), Textbooks have a page number, and Toy Cars have a decal.

The function overrides are very simple, mostly because I was trying to play it safe and not jump head first into trying to make something whacky, and when I was cross referencing with MSDN while working on the project, the article didn't really change much when they had overridden the function, either. In both cases, we could have just called the parent function from the child class and added the extra data, while leaving the parent function non-virtual. But nonetheless, the functions are overridden, to an extent.

I tried to add some catches in the code for things like entering choices that aren't options, and the like, but it's somewhat minimal. For example, the program will boot the user out if they enter a number past 5 when choosing what they would like to do with the list, and if they choose to add an item that isnt a toy car, textbook, or vegetable, it kicks out, as well. However, I tried to implement some code to tell the user that an item can't be located (there are two times where the user is asked to enter the name of an item, and I wanted to prevent gobbly-de-gook from breaking the program), but the approach that I was trying to do wasn't working properly so I had to scrap it. Currently, if the user tries to search for an item that doesn't exist in the list, it just won't print anything out, and return to the switch statement, and in other cases it will boot out and throw an exception, which isn't ideal, but I don't think I have the C# knowhow to try and prevent something like a string being passed when the program is looking for an int, and catching that in the code and not in a catch statement. So, I will settle for the error catching that's in place right now, and everything else works.
