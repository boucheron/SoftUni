package com.company;

import java.util.Scanner;
import java.util.regex.Pattern;
import java.util.regex.Matcher;

public class _05_ExtractWords {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String strInput = input.nextLine();

        Pattern patternWord = Pattern.compile("[a-zA-Z]{2,}");
        Matcher words = patternWord.matcher(strInput);

        while (words.find()) {
            System.out.print(words.group() + " ");
        }

    }
}