package com.company;

import java.util.Scanner;

public class _04_CalculateExpression {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        double a = input.nextDouble();
        double b = input.nextDouble();
        double c = input.nextDouble();

        double formula1 = Math.pow((a * a + b * b) / (a * a - b * b), (a + b + c) / Math.sqrt(c));
        double formula2 = Math.pow((a * a + b * b - Math.pow(c, 3)), a - b);
        double averageOfNumbers = (a + b + c) / 3;
        double averageOfFormulas = (formula1 + formula2) / 2;
        double differenceOfAvg = Math.abs(averageOfNumbers - averageOfFormulas);

        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", formula1, formula2, differenceOfAvg);

    }
}