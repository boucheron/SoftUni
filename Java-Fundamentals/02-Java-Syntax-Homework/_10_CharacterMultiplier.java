package com.company;

import java.util.Scanner;

public class _10_CharacterMultiplier {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String[] inputStrings = input.nextLine().split(" ");
        String firstStr = inputStrings[0];
        String secondStr = inputStrings[1];

        getStringsCharacterCodeMultiplied(firstStr, secondStr);

    }

    private static void getStringsCharacterCodeMultiplied(String str1, String str2) {

        if (str1.length() < str2.length()) {
            String temp = str1;
            str1 = str2;
            str2 = temp;
        }

        int totalSum = 0;

        for (int i = 0; i < str1.length(); i++) {

            if (i <= str2.length()) {
                totalSum += str1.charAt(i) * str2.charAt(i);
            } else {
                totalSum += str1.charAt(i);
            }
        }

        System.out.println(totalSum);
    }
}