package com.company;

import java.util.Scanner;

public class _04_CountAllWords {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String[] line = input.nextLine().split("[^a-zA-Z]+");

        System.out.println(line.length);
    }
}