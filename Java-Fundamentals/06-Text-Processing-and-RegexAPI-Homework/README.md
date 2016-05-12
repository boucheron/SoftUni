##Homework: Text Processing and Regex API
####Problem 1. Extract Emails
Write a program to extract all email addresses from given text. The text comes at the first input line. Print the emails in the output, each at a separate line. Emails are considered to be in format \<user>@\<host>, where:
-	\<user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them. Examples of valid users: "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345". Examples of invalid users: ''--123", ".....", "nakov_-", "_steve", ".info".
-	\<host> is a sequence of at least two words, separated by dots '.'. Each word is sequence of letters and can have hyphens '-' between the letters. Examples of hosts: "softuni.bg", "software-university.com", "intoprogramming.info", "mail.softuni.org". Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-".
-	Example of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy.

####Problem 2. Count Substring Occurrences
Write a program to find how many times given string appears in given text as substring. The text is given at the first input line. The search string is given at the second input line. The output is an integer number. Please ignore the character casing.
####Problem 3. Count Specified Word
Write a program to find how many times a word appears in given text. The text is given at the first input line. The target word is given at the second input line. The output is an integer number. Please ignore the character casing. Consider that any non-letter character is a word separator.
####Problem 4. Count All Words
Write a program to count the number of words in given sentence. Use any non-letter character as word separator.
####Problem 5. Extract words
Write a program that extracts words from a string. Words are sequences of characters that are at least two symbols long and consist only of English alphabet letters. Use regex.
####Problem 6. Starts and Ends With Capital Letter
Write a program that takes as input an array of strings are prints only the words that start and end with capital letter. Words are only strings that consist of English alphabet letters. Use regex.
####Problem 7.*** Magic exchangeable words
Write a method that takes as input two strings of equal length, and returns Boolean if they are exchangeable or not. Exchangeable are words where the characters in the first string can be replaced to get the second string. Example: egg and add are exchangeable, but aabbccbb and nnooppzz are not. (First bb corresponds to oo, but second bb corresponds to zz)
