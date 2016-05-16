#Java Fundamentals Exam

**Contents:**&nbsp;&nbsp;&nbsp;
[Problem 1](#problem-1-royalism)&nbsp;&nbsp;&nbsp;
[Problem 2](#problem-2-royal-nonstop)&nbsp;&nbsp;&nbsp;
[Problem 3](#problem-3-royal-flush)&nbsp;&nbsp;&nbsp;
[Problem 4](#problem-4-royal-accounting)&nbsp;&nbsp;&nbsp;

###[Problem 1. Royalism](_01_Royalism.java "See the Code")
It is the era of the religions, and one of them stands above all others – The Royalism. The individuals from this religion worship an almighty being called Royal. You will receive the names of random people, and you must find those who are royalists.

You are given a sequence of strings containing random ASCII characters, separated by a space. You must then sum the ASCII code values of all the characters, for every string. If while summing, one by one, every character’s ASCII code, the value exceeds 26, you should subtract from it 26, and do that until it becomes less or equal to 26. When you finish summing all characters’ codes, if the sum is equal to the position of the letter ‘R’ in the English alphabet, it means that the current person is a royalist.

When you find the ASCII sum of all strings, if there are any royalists, you must check if the royalists are more or equal, as count, to the non-royalists. If they are, you must print their count, then their names (strings), each on a new line, and on the final line – “All hail Royal!”. If the royalists are less than the non-royalists, you must print the names of all non-royalists, each on a new line, and on the final line – “Royalism, Declined!”.

####Input
- The input comes in format - a single line of strings with random ASCII characters, each string - separated by a space.

####Output
- If you find any royalists, and they are more or equal to the non-royalists, you should print their count, their corresponding strings, each on a new line, and after them, on the final line – “All hail Royal!”. See the examples for more info.
- If the royalists are less than the non-royalists you should print the non-royalists’ names, each on a new line, and after them - “Royalism, Declined!”.

####Constraints
- The strings can consist of any ASCII character except whitespace.
- Every string will consist of at least 1 character.
- Allowed time/memory: 250ms/16MB.

####Example

Input            | Output
---------------- | ----------------
Qp8;\|f7,+X\| R#x#Ul+"XFn msg'Vsg]]. f9z35o1(igG ` | Qp8;\|f7,+X\|
                                                   | R#x#Ul+"XFn
                                                   | f9z35o1(igG
                                                   | Royalism, Declined!

___
<p align="right">[<a href="#java-fundamentals-exam">up</a>]</p>
###[Problem 2. Royal NonStop](_02_RoyalNonStop.java "See the Code")
The Royal NonStop is a regular non-stop shop in which Royal works. Royal, proclaimed that this shop is royal because he didn’t want to feel shame for working in just a normal street-corner shop, which sells lukanka and rakija.

You will be given n and m, 2 integers separated by a space – the dimensions of a matrix, the size of the non-stop shop. You will then be given two floating point numbers, separated by a space – the price for the lukanka and the price for the rakija. 

Royal has a few regular drunk customers, which come in late at night, go at a specific stall, buy something from it and then, while walking to Royal on the pay desk, they buy everything on their path. You will start receiving two integers separated by a space which will represent row and column in the matrix, on each line. That is where the customer goes initially. On every even row there is lukanka, and on every odd – rakija. He buys the product at that cell and starts going towards the first cell of the matrix (the top-left). 

If the given row is smaller than the given column, the customer first goes up to the top row, and then starts going left to the first cell. If the row is more or equal to the column the customer first goes left to the left-most column and then goes up to the first cell. The first cell is always the pay desk so the customer buys nothing there, he only pays. For every step the customer makes he buys the product at that cell, either lukanka or rakija, depending on the row. The price of the product is – (row * col) * product price. For this formula ONLY, count the first row and the first column as 1.

When the customer reaches the pay desk, he pays the total price for all of his products and goes home to drink and eat. When you receive the command “Royal Close”, the input ends. Then you print the total money Royal earned that day, and the amount of customers he had.

####Input
-	The first input line will contain the dimensions of the matrix, separated by a space.
-	The second line will contain the prices of the products, separated by a space, first the lukanka price, and then the rakija price.
-	Then you will get several lines containing two integers separated by a space which will be the customer row and column.
-	When you receive the command “Royal Close” the input ends.

####Output
-	The output is simple. You must print the total money Royal earned that day, rounded the default way and printed to the 6th digit after decimal point, and the count of customers, each on a new line.

####Constraints
-	The dimensions of the matrix will be integers in the range [4, 10000].
-	The prices of the products will be floating point numbers in the range [-2^64, 2^64].
-	The amount of customers Royal can have is in the range [0, 1000].
-	The given row and column, representing the initial customer cell, will always be in the range of the matrix.
-	Allowed time/memory: 100ms/16MB.

####Example

Input            | Output
---------------- | ----------------
100 100          | 209998922.870000
254.452 361.163  | 4
2 2              |
56 54            |
99 99            |
12 84            |
Royal Close      |

___
<p align="right">[<a href="#java-fundamentals-exam">up</a>]</p>
###[Problem 3. Royal Flush](_03_RoyalFlush.java "See the Code")
Royal likes to play poker very much, and he is really good at it too. But he doesn’t the rules so he needs some help.

You will be given n – an integer. On the next n lines you will receive strings of random amounts of random card characters - Royal’s poker cards. You need to see if any combination of the cards successfully forms a Royal Flush hand (10-J-Q-K-A). The cards will be ranked: 2, 3… 10, J, Q, K, A, and will have suits: c, d, h, s, which go for clubs, diamonds, hearts and spades. The Royal Flush combination cards might not be placed next to each other, and on the same line, but they need to be in the correct order (10 – A) and of the same suit to form it.

If there is a card that doesn’t follow the rank order but the suit is different, it doesn’t break the combination. If there is a card of the same suit however and does NOT follow the rank order, it breaks the current combination, and makes it invalid.

When Royal gets a Royal Flush you should print “Royal Flush Found – {Suit}”, where suit is the suit of the current combination.

####Input
-	The first line of input will hold an integer n.
-	On the next n lines of input you will receive strings holding sequences of cards.

####Output
-	Every time you find a Royal Flush, you must print “Royal Flush Found – {Suit}”. See the examples below.
-	At the end you must print how many Royal Flushes you’ve found – “Royal’s Royal Flushes – {count}”.

####Constraints
-	The lines with strings will always consist only of cards and suits.
-	The integer n will be in the range of [1, 1000]. 
-	Allowed time/memory: 100ms/16MB

####Example

Input            | Output
---------------- | ----------------
2                          | Royal Flush Found – Spades
2s10s10dJsQsJdKsQdAsKdAd   | Royal Flush Found – Diamonds
10sJsQdQsKs10cAsJcQcQcKcAc | Royal Flush Found – Spades
                           |Royal’s Royal Flushes – 3.

___
<p align="right">[<a href="#java-fundamentals-exam">up</a>]</p>
###[Problem 4. Royal Accounting](_04_RoyalAccounting.java "See the Code")
Royal was very impressed by the legendary dragon Karl Marx, who managed to establish an accounting system for dragons, and decided to make his own one. 

You will be given several input lines. This is the format they must follow:

{employeeName};{workHoursPerDay};{dailyPayment};{team}

Where “employee name” and “team name” are strings, and must consist only of English alphabet characters, “work hours per day” is an integer, and must, obviously, consist only of digits, and “daily payment” is a floating point number, it can have digits after the decimal point. Every employee has its own team. There can be more than one employee in a team. Any format that does not consist only of what was, specified above, as a valid format, must be ignored. If an employee name already exists, you should ignore that specific line of input.

When you receive the command “Pishi kuf i da si hodim” - that means Royal got bored of all the accounting and he will not accept any other employee data for the day. That means that you must print the data you have gathered, but in a specific format.

You must order the teams, by the amount of money every team has gathered, which depends on the sum of the monthly payment of each employee from that team. Each employee’s monthly payment is calculated by his:

((daily payment * work hours) / 24) * 30

The order of the teams is descending, by the criteria specified above. For every team you must print info about each of its employees. The employees must also be sorted first by their work hours – descending order, second by their daily income, which is (daily payment * work hours) / 24 – descending order. If even after that they are not sorted, order them alphabetically.

####Input
-	As input, you will receive several lines containing information, but only those that follow the format, specified above, must be accepted as valid.
-	When the command “Pishi kuf i da si hodim” is entered, you must end the input sequence and start the output.

####Output
-	The output is simple, you must print every team, and for every team its employees, padded three dollar symbols inside (because Royal loves money), in the following way:
-	“Team - {teamName}”
-	“$$${employeeName1} – {workHours} – {dailyIncome}
-	“$$${employeeName2} – {workHours} – {dailyIncome}
-	“{teamName2}…”
-	The daily income must be printed to 6 digits after the decimal point. See the examples for more info.

####Constraints
-	The employee name and team name will always be strings consisting of at least 1 character.
-	The valid work hours per day will be an integer in range [-2^31 + 1, 2^31 - 1].
-	The valid daily payment will be a floating number in range [-2^64, 2^64].
-	Allowed time/memory: 100ms/16MB.

####Example

Input            | Output
---------------- | ----------------
Toshko;4;15.56;Trainers       | Team - Procrastinators
Moni;8;22.768;Trainers        | $$$Ivo - 12 - 7.000000
Nasko;12;8.34;Procrastinators | $$$Nasko - 12 - 4.170000
Ivo;12;14;Procrastinators     | Team - Trainers
Pishi kuf i da si hodim       | $$$Moni - 8 - 7.589333
                              | $$$Toshko - 4 - 2.593333

___
<p align="right">[<a href="#java-fundamentals-exam">up</a>]</p>
