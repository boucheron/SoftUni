package com.company;

import java.util.Scanner;

public class _01_SortArrayOfNumbers {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++) {
            numbers[i] = input.nextInt();
        }

        int minIndex = 0;
        int swap = 0;

        // Algorithm - selection sort
        for (int i = 0; i < numbers.length - 1; i++) {
            minIndex = i;

            for (int j = i + 1; j < numbers.length; j++) {
                if (numbers[minIndex] > numbers[j]) {
                    minIndex = j;
                }
            }

            if (minIndex != i) {
                swap = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = swap;
            }
        }

        for (int a : numbers) {
            System.out.print(a + " ");
        }

    }
}