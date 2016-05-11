package com.company;

import java.util.Scanner;

public class _08_OddAndEvenPairs {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String[] inputNumbers = input.nextLine().split(" ");

        if (inputNumbers.length % 2 != 0) {
            System.out.println("Invalid length!");
            return;
        }

        int[] numbers = new int[inputNumbers.length];

        for (int i = 0; i < inputNumbers.length; i++) {
            numbers[i] = Integer.parseInt(inputNumbers[i]);
        }

        for (int i = 0; i < numbers.length; i += 2) {

            if (numbers[i] % 2 == 0 && numbers[i + 1] % 2 == 0) {
                System.out.println(numbers[i] + ", " + numbers[i + 1] + " -> both are even");
            } else if (numbers[i] % 2 != 0 && numbers[i + 1] % 2 != 0) {
                System.out.println(numbers[i] + ", " + numbers[i + 1] + " -> both are odd");
            } else {
                System.out.println(numbers[i] + ", " + numbers[i + 1] + " -> different");
            }
        }

    }
}