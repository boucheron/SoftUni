package com.company;

import java.math.BigInteger;
import java.util.Scanner;

public class _12_CalculateNFactorial {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int number = input.nextInt();

        System.out.println(calculateFactorial(number));

    }

    private static BigInteger calculateFactorial(int num) {

        if (num == 0) {
            return BigInteger.ONE;
        } else {
            return BigInteger.valueOf(num).multiply(calculateFactorial(num - 1));
        }
    }

}