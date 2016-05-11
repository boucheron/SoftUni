package com.company;

import java.util.Scanner;

public class _05_ConvertFromDecimalToBase7 {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int decimalNum = input.nextInt();
        String base7Num = Integer.toString(decimalNum, 7);

        System.out.println(base7Num);

    }
}