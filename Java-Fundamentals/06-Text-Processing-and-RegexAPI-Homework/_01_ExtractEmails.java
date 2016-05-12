package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _01_ExtractEmails {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String text = input.nextLine();

        Pattern patternEmail = Pattern.compile("[A-Z0-9]+([.-_]?[A-Z0-9]+)+@[A-Z]+[-]?[A-Z]+(\\.[A-Z]+[-]?[A-Z]+)+", Pattern.CASE_INSENSITIVE);
        Matcher emails = patternEmail.matcher(text);

        while (emails.find()) {
            System.out.println(emails.group());
        }

    }
}