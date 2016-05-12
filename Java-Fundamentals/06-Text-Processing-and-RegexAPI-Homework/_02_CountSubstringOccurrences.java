package com.company;

import java.util.Scanner;

public class _02_CountSubstringOccurrences {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String text = input.nextLine();
        String substring = input.nextLine();

        int substringCounter = 0;
        int substringIndex = text.indexOf(substring);

        while (substringIndex != -1) {
            substringCounter++;
            substringIndex = text.indexOf(substring, substringIndex + 1);
        }

        System.out.println(substringCounter);
    }
}