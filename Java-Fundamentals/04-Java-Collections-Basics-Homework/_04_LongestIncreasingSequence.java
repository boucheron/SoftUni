package com.company;

import java.util.Scanner;

public class _04_LongestIncreasingSequence {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String[] line = input.nextLine().split(" ");
        StringBuilder longestSeq = new StringBuilder();
        StringBuilder currentSeq = new StringBuilder();

        longestSeq.append(line[0]);

        for (int i = 0; i < line.length; i++) {

            currentSeq.append(line[i]);

            for (int j = i + 1; j < line.length; j++) {
                if (Integer.parseInt(line[i]) < Integer.parseInt(line[j])) {
                    currentSeq.append(" " + line[j]);
                    i = j;

                    if (longestSeq.toString().split(" ").length < currentSeq.toString().split(" ").length) {
                        longestSeq.setLength(0);
                        longestSeq.append(currentSeq);
                    }
                } else {
                    System.out.println(currentSeq);
                    currentSeq.setLength(0);
                    break;
                }
            }
        }

        System.out.println(currentSeq);
        System.out.println("Longest: " + longestSeq);

    }
}