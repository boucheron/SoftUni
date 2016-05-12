package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _06_StartsAndEndsWithCapitalLetter {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String strInput = input.nextLine();

        Pattern patternWord = Pattern.compile("\\b[A-Z][a-zA-Z]*[A-Z]\\b");
        Matcher words = patternWord.matcher(strInput);

        while (words.find()) {
            System.out.print(words.group() + " ");
        }

    }
}