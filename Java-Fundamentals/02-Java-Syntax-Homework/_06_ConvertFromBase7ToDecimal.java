package com.company;

import java.util.Scanner;

public class _06_ConvertFromBase7ToDecimal {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int base7Num = input.useRadix(7).nextInt();
        String decimalNum = Integer.toString(base7Num, 10);

        System.out.println(decimalNum);

    }
}