package com.company;

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class _07_RandomizeNumbersFromNtoM {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int n = input.nextInt();
        int m = input.nextInt();

        if (n > m) {
            int temp = n;
            n = m;
            m = temp;
        }

        int numbersCount = m - n + 1;

        ArrayList<Integer> rangeNumbers = new ArrayList<>();

        for (int i = 0; i < numbersCount; i++) {
            rangeNumbers.add(n + i);
        }

        Random rnd = new Random();

        for (int i = 0; i < numbersCount; i++) {
            int index = rnd.nextInt(rangeNumbers.size());
            System.out.print(rangeNumbers.get(index) + " ");
            rangeNumbers.remove(index);
        }

        System.out.println();

        //another solution - exchange of the elements
        int[] randomizedNumbers = new int[numbersCount];

        for (int i = 0; i < numbersCount; i++) {
            randomizedNumbers[i] = n + i;
        }

        for (int i = 0; i < numbersCount; i++) {
            int first = rnd.nextInt(numbersCount);
            int second = rnd.nextInt(numbersCount);

            int temp = randomizedNumbers[first];
            randomizedNumbers[first] = randomizedNumbers[second];
            randomizedNumbers[second] = temp;
        }

        for (int a : randomizedNumbers) {
            System.out.print(a + " ");
        }

    }
}