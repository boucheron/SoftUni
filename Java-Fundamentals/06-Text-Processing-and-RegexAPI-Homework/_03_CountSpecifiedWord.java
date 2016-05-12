package com.company;

import java.util.Scanner;

public class _03_CountSpecifiedWord {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String[] text = input.nextLine().split("[^a-zA-Z]+");
        String targetWord = input.nextLine();

        int targetWordCounter = 0;

        for (String a : text) {
            if (a.equalsIgnoreCase(targetWord)) {
                targetWordCounter++;
            }
        }

        System.out.println(targetWordCounter);
    }
}