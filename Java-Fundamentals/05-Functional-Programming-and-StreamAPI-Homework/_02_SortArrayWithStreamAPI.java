package com.company;

import java.util.Arrays;
import java.util.Comparator;
import java.util.Scanner;

public class _02_SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int[] numbers = Arrays.stream(input.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        String sortingOrder = input.nextLine();

        if (sortingOrder.equals("Ascending")) {
            Arrays.stream(numbers)
                    .sorted()
                    .forEach(a -> System.out.print(a + " "));
        } else {
            Arrays.stream(numbers)
                    .boxed()
                    .sorted(Comparator.reverseOrder())
                    .forEach(a -> System.out.print(a + " "));
        }

    }
}