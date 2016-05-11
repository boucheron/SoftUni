package com.company;

import java.util.Scanner;

public class _03_FormattingNumbers {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int a = input.nextInt();
        double b = input.nextDouble();
        double c = input.nextDouble();

        String binary = Integer.toBinaryString(a);

        System.out.printf("|%-10S|%010d|%10.2f|%-10.3f|", Integer.toHexString(a), Integer.parseInt(binary), b, c);

    }
}