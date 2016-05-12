package com.company;

import java.util.HashMap;
import java.util.Scanner;

public class _07_MagicExchangeableWords {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String[] words = input.nextLine().split(" ");
        String firstWord = words[0];
        String secondWord = words[1];

        if (firstWord.length() != secondWord.length()) {
            System.out.println("Invalid input: Unequal words length!");
            return;
        }

        System.out.println(checkWordsExchange(firstWord, secondWord));

    }

    private static boolean checkWordsExchange(String word1, String word2) {
        boolean isExchangeable = true;
        HashMap<Character, Character> charCorrespondence = new HashMap<>();

        for (int i = 0; i < word1.length(); i++) {
            if (charCorrespondence.containsKey(word1.charAt(i))) {
                if (!(charCorrespondence.get(word1.charAt(i)) == word2.charAt(i))) {
                    isExchangeable = false;
                    break;
                }
            } else {
                charCorrespondence.put(word1.charAt(i), word2.charAt(i));
            }
        }

        return isExchangeable;
    }

}