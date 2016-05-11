package com.company;

import java.util.Scanner;

public class _09_HitTheTarget {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int targetSum = input.nextInt();

        for (int i = 1; i <= 20; i++) {
            for (int j = 1; j <= 20; j++) {
                if (i + j == targetSum) {
                    System.out.println(i + " + " + j + " = " + targetSum);
                } else if (i - j == targetSum) {
                    System.out.println(i + " - " + j + " = " + targetSum);
                }
            }
        }

    }
}