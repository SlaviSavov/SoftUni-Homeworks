﻿# Exercises: Streams, Files and Directories 
Problems for exercises and homework for the  [&quot;CSharp Advanced&quot; course @ Software University](https://softuni.bg/courses/csharp-advanced).
#
**01.Even Lines**

Write a program that reads a text file and prints on the console its even lines. Line numbers start from 0. Use StreamReader. Before you print the result replace {"-", ",", ".", "!", "?"} with "@" and reverse the order of the words.

#
**02.Line Numbers**

Write a program that reads a text file and inserts line numbers in front of each of its lines and count all the letters and punctuation marks. The result should be written to another text file. Use StreamReader in combination with StreamWriter.
#
**03.Word Count**

Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file text.txt. Matching should be case-insensitive. Write the results in file actualResults.txt. Sort the words by frequency in descending order and then compare the result with the file expectedResult.txt. Use StreamReader in combination with StreamWriter.

#
**04.Copy Binary File**

Write a program that copies the contents of a binary file (e.g. image, video, etc.) to another using FileStream. You are not allowed to use the File class or similar helper classes.
#
**05.Directory Traversal**

Write a program that traverses a given directory for all files with the given extension. Search through the first level of the directory only and write information about each found file in report.txt. The files should be grouped by their extension. Extensions should be ordered by the count of their files descending, then by name alphabetically. Files under an extension should be ordered by their size. report.txt should be saved on the Desktop. Ensure the desktop path is always valid, regardless of the user.
#
**06.Zip and Extract**

Write a program that creates a zip file in a given directory and extracts it in another one. Use the copyMe.png file from your resources and zip it in a directory of your choice. Extract the zip file in another directory, again, by your choice.

