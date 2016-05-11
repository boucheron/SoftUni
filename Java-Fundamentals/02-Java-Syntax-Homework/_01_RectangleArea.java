package com.company;

import java.util.Scanner;

public class _01_RectangleArea {

    public static void main(String[] args) {

        Scanner sides = new Scanner(System.in);
        int sideA = sides.nextInt();
        int sideB = sides.nextInt();

        long rectangleArea = sideA * sideB;

        System.out.println(rectangleArea);

    }
}