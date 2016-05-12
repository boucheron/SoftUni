package com.company;

import java.util.*;

public class _07_CombineListsOfLetters {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        char[] letters = input.nextLine().toCharArray();
        List<Character> l1 = new ArrayList<>();
        for (char c : letters) {
            if (Character.isLetter(c)) {
                l1.add(c);
            }
        }

        letters = input.nextLine().toCharArray();
        List<Character> l2 = new ArrayList<>();
        for (char c : letters) {
            if (Character.isLetter(c)) {
                l2.add(c);
            }
        }

        List<Character> combinedList = new ArrayList<>();
        combinedList.addAll(l1);
        for (Character c : l2) {
            if (!combinedList.contains(c)) {
                combinedList.add(c);
            }
        }

        for (Character c : combinedList) {
            System.out.print(c + " ");
        }
    }
}