package com.company;

import java.util.Scanner;

public class _11_GetFirstOddOrEvenElements {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);


        String[] numbers = input.nextLine().split(" ");
        String[] command = input.nextLine().split(" ");

        getFirstOddOrEvenElements(numbers, command);

    }

    private static void getFirstOddOrEvenElements(String[] numbers, String[] command) {


        int returnCount = Integer.parseInt(command[1]);
        String oddOrEven = command[2];

        for (int i = 0; i < numbers.length; i++) {

            if (returnCount <= 0) {
                break;
            }

            if (oddOrEven.equals("odd") && Integer.parseInt(numbers[i]) % 2 != 0) {
                System.out.print(numbers[i] + " ");
                returnCount--;
            } else if (oddOrEven.equals("even") && Integer.parseInt(numbers[i]) % 2 == 0) {
                System.out.print(numbers[i] + " ");
                returnCount--;
            }
        }
    }

}