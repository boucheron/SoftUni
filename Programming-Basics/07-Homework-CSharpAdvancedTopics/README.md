##Homework: C# Advanced Topics
####Problem 1. Fibonacci Numbers
Define a method Fib(n) that calculates the nth Fibonacci number.
####Problem 2. Prime Checker
Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.
####Problem 3. Primes in Given Range
Write a method that calculates all prime numbers in given range and returns them as list of integers:
```C#
static List<int> FindPrimesInRange(startNum, endNum)
{
    …
}
```
Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.
####Problem 4. Difference between Dates
Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.
####Problem 5. Sorting Numbers
Write a program that reads a number n and a sequence of n integers, sorts them and prints them.
####Problem 6. Longest Area in Array
Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them. 
####Problem 7. Matrix of Palindromes
Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:

Input | Output
----- | -----------------------
      | aaa aba aca	ada aea afa
3 6   | bbb bcb bdb	beb bfb bgb
      | ccc cec cdc	cfc cgc chc

####Problem 8. Remove Names
Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line.
####Problem 9. Join Lists
Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line.
####Problem 10. Count of Letters
Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order.
####Problem 11. Count of Names
Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order.
####Problem 12. Average Load Time Calculator
We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. Your tasks is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report. Print the output in the format given below. Use double floating-point precision.

Input                                        | Output
-------------------------------------------- | --------------------------------
2014-Mar-02 11:33 http://softuni.bg 8.37725  | http://softuni.bg -> 7.813625
2014-Mar-02 11:34 http://www.google.com 1.335| http://www.google.com -> 2.24875
2014-Mar-03 21:03 http://softuni.bg 7.25     |
2014-Mar-03 22:00 http://www.google.com 2.44 |
2014-Mar-03 22:01 http://www.google.com 2.45 |
2014-Mar-03 22:01 http://www.google.com 2.77 |

####Problem 13. Longest Word in a Text
Write a program to find the longest word in a text.
####Problem 14. Extract URLs from Text
Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
- [http://something](http://something), e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
- www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com

####Problem 15.* Counting a Word in a Text
Write a program that counts how many times a given word occurs in given text. The first line in the input holds the word. The second line of the input holds the text. The output should be a single integer number – the number of word occurrences. Matching should be case-insensitive. Note that not all matching substrings are words and should be counted. A word is a sequence of letters separated by punctuation or start / end of text.
