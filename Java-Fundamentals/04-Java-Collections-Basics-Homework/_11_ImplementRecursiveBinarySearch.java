package com.company;

import java.util.Scanner;

public class _11_ImplementRecursiveBinarySearch {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int searchElement = Integer.parseInt(input.nextLine());
        String[] data = input.nextLine().split(" ");
        int[] numbers = new int[data.length];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(data[i]);
        }

        int minInd = 0;
        int maxInd = numbers.length - 1;

        System.out.println(recursiveBinarySearch(searchElement, numbers, minInd, maxInd));

    }

    private static int recursiveBinarySearch(int element, int[] nums, int start, int end) {
        int middle = (start + end) / 2;

        if (element == nums[middle]) {
            return middle;
        } else if (end < start) {
            return -1;
        } else {
            if (element > nums[middle]) {
                return recursiveBinarySearch(element, nums, middle + 1, end);
            } else {
                return recursiveBinarySearch(element, nums, start, middle - 1);
            }
        }

    }

}