package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class _01_FilterArray {

    public static void main(String[] args) {

        Arrays.stream(new Scanner(System.in).nextLine().split(" "))
                .filter(n -> n.length() > 3)
                .forEach(str -> System.out.print(str + " "));

    }
}