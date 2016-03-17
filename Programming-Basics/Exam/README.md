#Programming Basics Exam

**Contents:**&nbsp;&nbsp;&nbsp;
[Problem 1](#problem-1-cake-tycoon)&nbsp;&nbsp;&nbsp;
[Problem 2](#problem-2-beer-stock)&nbsp;&nbsp;&nbsp;
[Problem 3](#problem-3-illuminati-lock)&nbsp;&nbsp;&nbsp;
[Problem 4](#problem-4-master-herbalist)&nbsp;&nbsp;&nbsp;
[Problem 5](#problem-5-emergency-repairs)&nbsp;&nbsp;&nbsp;

###[Problem 1. Cake Tycoon](01.CakeTycoon.cs "See the Code")
Young Ivancho really likes cakes, in fact he likes them so much he decided to open his own cake factory and since Ivancho’s father is a big mafia boss, he apparently can do that. However there is one problem, Ivancho really hates math, so he asked his father to get him a programmer who will make a program which would calculate his expenses for him. Unluckily for you, you are that programmer, needless to say Ivancho’s father made you an offer you can’t refuse, so you better make sure the program works.

Since Ivancho is very whimsical he decides the kilograms of flour needed to make a cake and the number of cakes he wants, every day. First thing Ivancho needs for his cakes is flour, however it turns out there is only one provider of flour in the city and he can only deliver a specific amount of kilograms of flour per day, luckily though he’s a friend of Ivancho’s father so Ivancho doesn’t have to pay for the flour. The second thing Ivancho likes the most after cakes is truffles, so Ivancho decided he wants all his cakes to have truffles in them, as much truffles as he can buy, which he will then divide evenly amongst all cakes he can make that day, but since truffles are so rare the amount of truffles available and the price for a truffle changes each day. Lastly Ivancho has to make a profit, so he decided that the price at which he will sell one cake will be equal to the price of the ingredients for one cake increased by 25%.

Your task is to write a program to calculate the amount of cakes that Ivancho can make that day and the price for one cake. You’ll be given some numbers. The number of cakes Ivancho wants that day, the kilograms of flour needed to make one cake, the kilograms of flour which the provider can give you, the amount of truffles you can buy and the price for each truffle. If Ivancho has enough flour to make the amount of cakes he wants, he will make exactly that amount, the leftover flour will be discarded and you should print on the console “All products available, price of a cake: {price of one cake}”. Alternatively if there is not enough flour you should round down the number of cakes that can be produced to a whole number (since Ivancho only wants whole cakes) and print them on the console in the format “Can make only {number of cakes that can be produced} cakes, need {kilograms of flour needed} kg more flour” where kilograms of flour needed is the difference between the kilograms of flour required to make the amount of cakes Ivancho wanted and the kilograms of flour available. 

####Input
The input data should be read from the console. It consists of five input values, each at a separate line:
- The number n – amount of cakes Ivancho wants.
- The number c – kilograms of flour needed to make one cake.
- The number f – kilograms of flour available.
- The number t – amount of truffles available.
- The number p – price of one truffle.

The input data will always be valid and in the format described. There is no need to check it explicitly.
####Output
The output should be printed on the console.
- If there isn’t enough flour to make the amount of cakes Ivancho wants print on the console:
 - “Can make only {number of cakes that can be produced} cakes, need {kilograms of flour needed} kg more flour”
- If there is enough flour:
 - “All products available, price of a cake: {price of one cake}”
- The number of cakes that can be produced must be a whole number; the price of the cake and the kilograms of flour needed must be rounded to two digits after the decimal point.

####Constraints
- The number n will be a valid integer in the range [1 … 18 446 744 073 709 551 615]
- The number c will be a floating-point numbers in the range [0 … 7.9 x 1028].
- The numbers f, t and p will be valid integers in the range [0 ... 4 294 967 295].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

####Example

Input            | Output
---------------- | ----------------
123              | All products available, price of a cake: 304.88
1.2              |
150              |
15               |
2000             |

___
<p align="right">[<a href="#programming-basics-exam">up</a>]</p>
###[Problem 2. Beer Stock](02.BeerStock.cs "See the Code")
Students in SoftUni really like drinking beers, so the Game Bar has to always be stocked with beer and with all the students that will be celebrating passing the Programming Basics Exam a lot of beer is going to be needed today.  Normally Stamat would be keeping track of the stock, however he was at a party last night and got wasted, since he’s too drunk to go and count the beers he asked you to write him a program to do it instead.

Before the exam starts the students who will want a beer will tell you, so on the first line you’ll get the amount of reserved beers, then the shipments will start coming in. Each shipment will be in the format “{amount} {type}”, where type is the type of package received – either beers, sixpacks or cases and amount is the amount received, each sixpack holds exactly 6 beers and each case holds exactly 24 beers. However since the world isn’t perfect in every 100 beers exactly the 100th is always broken so it gets discarded. On the last line you’ll receive the text “Exam Over”, at that point you have to calculate all the beers received and if they are more or equal to the amount of reserved beers print “Cheers! Beer left: {amount of cases left} cases, {amount of sixpacks left} sixpacks and {amount of beers left} beers.” or if they are less print “Not enough beer. Beer needed: {amount of cases needed} cases, {amount of sixpacks needed} sixpacks and {amount of beers needed} beers.” Where {amount of cases left/needed}, {amount of sixpacks left/needed} and {amount of beers left/needed} represent respectively the amount of beer left/needed, represented so that the most amount of cases are used, after which the most amount of sixpacks are used (see the Examples to get a better idea).
####Input
The input data should be read from the console.
- On the first line you’ll receive the amount of reserved beers.
- On each of the next lines you will be given a string representing a shipment in the format 
“{amount} {type}”*, until you receive the command “Exam Over”.
- The names will always be given in plural regardless of amount “beers”, ”sixpacks”, ”cases”.
- The amount and the type will be separated by exactly one space, there will be no leading or trailing spaces in the input.

The input data will always be valid and in the format described. There is no need to check it explicitly.  
*HINT: Use string.Split() to separate {amount} from {type}.
####Output
The output should be printed on the console.
- If the amount of beer is more or equal to the amount of reserved beer:
 - “Cheers! Beer left: {amount of cases left} cases, {amount of sixpacks left} sixpacks and {amount of beers left} beers.”
- If the amount of beer is less than the amount of reserved beer:
 - “Not enough beer. Beer needed: {amount of cases needed} cases, {amount of sixpacks needed} sixpacks and {amount of beers needed} beers.”
- The names must always be printed in in plural regardless of amount “beers”, ”sixpacks”, ”cases”.

####Constraints
- The input lines will be in the range: [1… 100].
- The amount of reserved beer, and the amount in a shipment will be valid integers in the range [0... 2,147,483,647].
- Allowed working time for your program: 0.25 seconds.
- Allowed memory: 16 MB.

####Example

Input            | Output
---------------- | ----------------
197              | Not enough beer. Beer needed: 4 cases, 1 sixpacks and 1 beers.
1 beers          |
2 cases          |
7 sixpacks       |
3 beers          |
Exam Over        |

___
<p align="right">[<a href="#programming-basics-exam">up</a>]</p>
###[Problem 3. Illuminati Lock](03.IlluminatiLock.cs "See the Code")
Hello 008, you have been tasked with assisting 007 on a top secret mission to bring down a Global Illuminati Conspiracy. You’re standing in front of the final lock to the Illuminati Secret Meeting. It is a very special lock which asks you to input a specific symbol. 007 quickly guesses that the symbol has to be the Illuminati symbol, luckily for you 007 is really good at drawing triangles, what he isn’t good at however is drawing eyes so he asks for your help.

You are given an integer number N (always odd) – the height of the eye is N+1, while the width is 3 * N
####Input
The input data should be read from the console.
- On the only input line you will be given the number N.

The input data will always be valid and in the format described. There is no need to check it explicitly.
####Output
The output should be printed on the console. Use the “#” (number sign) for the eye and “.” (dot) for the rest. Follow the examples below.
####Constraints
- N will always be a positive odd number in the range [5 … 59].
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

####Example

Input            | Output
---------------- | ----------------
5                | `.....#####.....`
                 | `...###...###...`
                 | `.##..#...#..##.`
                 | `.##..#...#..##.`
                 | `...###...###...`
                 | `.....#####.....`

___
<p align="right">[<a href="#programming-basics-exam">up</a>]</p>
###[Problem 4. Master Herbalist](04.MasterHerbalist.cs "See the Code")
Penka is a young and aspiring herbalist, every day she gets up early and goes collecting herbs in the mountains, however the mountains are big and she only has a limited amount of time for gathering each day. At the end of the day she sells the tinctures she prepares with the herbs at the market, she repeats this process until the end of the season at which point she has to calculate the average money she made per day. Since Penka is too busy gathering herbs and doesn’t want to lose time calculating she asked you to make a program which would do the calculations for her.

You will receive input from the console, on the first line you will receive a number representing Penka’s daily expenses. On each of the next lines you will receive input in the format “{hours} {path} {price}” until you receive the command “Season Over”. The hours in the format represents the hours Penka has for gathering herbs that day, path will be a string containing only capital letters representing the path through the mountains she will take and price represents the money she gets for each herb sold that day (assume Penka always sells all the herbs she gathers on the same day). Penka will traverse the path linearly from left to right and each letter represents a location in the mountain which Penka will search for herbs, if the letter is “H” it means Penka found 1 herb, any other letter means she found nothing. Regardless if she finds or doesn’t find anything a location will take exactly 1 hour to get searched. If Penka has more hours for gathering that the length of the path, she will start again from the beginning and all the herbs will have regrown. Upon receiving the command “Season Over” you have to calculate Penka’s average earnings per day of the season, the average being the total amount of money Penka made that seasons divided by the number of days that season (number of days being the number of input lines excluding the first and the last line (the line with her daily expenses and the line with “Season Over” respectively)). If Penka’s average earnings per day are more or equal to her daily expenses print on the console “Times are good. Extra money per day: {extra money}.” where extra money is the difference between her average earning per day and her daily expenses. Alternatively if her average earnings are less than her daily expenses print “We are in the red. Money needed: {money needed}.” where money needed is difference between her total expenses (her daily expenses multiplied by the number of days in the season) and the total amount of money she made that season. For more details see the examples below.
####Input
The input data should be read from the console. The input will contain a random number of lines. On the first input line you will receive a number representing Penka’s daily expenses. Each of the next lines will contain information in the following format “{hours} {path} {price}”*. The last line of the input will always be “Season Over” – signaling the end of the input.

The input data will always be valid and in the format described. There is no need to check it explicitly.  
*HINT: Use string.Split() to separate {hours}, {path} and {price}.
####Output
The output should consist of only one line:
- If Penka’s average earnings are more or equal than her daily expenses print:
 - “Times are good. Extra money per day: {extra money}.”
- Alternatively if her daily expenses are more than her average earnings print:
 - “We are in the red. Money needed: {money needed}.”
- The extra money must be rounded to two digits after the decimal point; the money needed must be a whole number.

####Constraints
- The number of input lines will be between [3…100].
- The elements in the input lines will be separated by a single space, there will be no leading or trailing spaces.
- The daily expenses will be a valid integer between [1...1000].
- The hours will be between [1…20].
- The path will be a valid string containing only capital letters with a length between [1…20].
- The price will be a valid integer between [1…1000].
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

####Example

Input            | Output
---------------- | ----------------
250              | Times are good. Extra money per day: 8.50.
5 MMZHQQQQ 37    |
11 ZZHHHQ 80     |
Season Over      |

___
<p align="right">[<a href="#programming-basics-exam">up</a>]</p>
###[Problem 5. Emergency Repairs](05.EmergencyRepairs.cs "See the Code")
Bai Ivan has a nice wall around his garden, but moles keep burrowing under it and destroying it. Just last night he had to fend off a mole attack on his wall and today he came to town to buy materials to repair it. However he forgot how many holes there were in the wall, you as a talented bit programmer offer to reconstruct the condition of his wall with bit representation based on his account of the story.

On the first line you will receive a 64 bit number representing the condition of Bai Ivan’s wall before the attack. Zero bits (0) represent holes in the wall, while one bits (1) represent unbroken parts of the wall. On the second line you will receive a number representing Bai Ivan’s emergency repair kits. One emergency repair kit can fix exactly one hole (one zero bit). On the third line you will receive a number N representing the number of attacks the moles did on Bai Ivan’s wall. On each of the next N lines will be a number representing which bit of the wall the attack targeted. If the bit is a one (1) it gets destroyed (set to 0), if it is zero (0) – nothing happens. After all the attacks pass Bai Ivan will pass through the wall from right to left to perform emergency repairs using his emergency repair kits, however since Bai Ivan has bad eyesight he doesn’t see the smallest holes and will thus try to fix only the bigger ones (bigger holes are at least 2 or more consecutive zero bits). If Bai Ivan runs out of emergency repair kits before he finishes repairing the wall he will just leave the rest of the holes unfixed. Your task is to print the condition of the wall represented as a number after the attacks pass and Bai Ivan finishes applying his emergency repairs.
####Input
The input data should be read from the console.
- On the first input line you will receive a 64 bit number representing Bai Ivan’s wall before the attack.
- On the second line you will receive a number representing the amount of emergency kits Bai Ivan has.
- On the third line you will receive a number N representing the number of attacks.
- On each of the next N lines you will receive a number representing which bit is attacked (bits are counted from right to left starting at 0).

The input data will always be valid and in the format described. There is no need to check it explicitly.
####Output
The output should consist of only one line – the number representing the condition of the wall after the attacks and Bai Ivan’s emergency repairs printed as a positive whole number.
####Constraints
- The number representing the wall will be a valid integer between [0…18,446,744,073,709,551,615].
- The number of emergency repair kits will be between [0…64].
- The number of attacks will be between [0…64].
- The numbers representing the attacks will be valid integers between [0…63].
- Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

####Example

Input            | Output
---------------- | ----------------
6564654864521654 | 2061055237676990
5                |
2                |
4                |
52               |

___
<p align="right">[<a href="#programming-basics-exam">up</a>]</p>
