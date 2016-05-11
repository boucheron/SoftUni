package com.company;

public class _06_GetAverage {
    public static void main(String[] args) {

        GetAverageOfThreeNumbers(1.5, 2.5, 3.8);
        GetAverageOfThreeNumbers(12, 13, 25);
        GetAverageOfThreeNumbers(0.005, 0.5, 0.55);
        GetAverageOfThreeNumbers(0, 0, 2);

    }

    public static void GetAverageOfThreeNumbers(double a, double b, double c){

        double average = (a + b + c) / 3;

        System.out.printf("%.2f", average);
        System.out.println();

    }
}