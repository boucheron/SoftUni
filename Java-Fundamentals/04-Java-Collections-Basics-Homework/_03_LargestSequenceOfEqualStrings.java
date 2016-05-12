package com.company;

import java.util.Scanner;

public class _03_LargestSequenceOfEqualStrings {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String[] line = input.nextLine().split(" ");

        StringBuilder largestSeq = new StringBuilder();
        largestSeq.append(line[0]);
        StringBuilder currentSeq = new StringBuilder();

        for (int i = 0; i < line.length; i++) {

            currentSeq.append(line[i]);

            for (int j = i + 1; j < line.length; j++) {
                if (line[i].equals(line[j])) {
                    currentSeq.append(" " + line[j]);
                    i = j;
                } else {
                    break;
                }
            }

            if (largestSeq.toString().split(" ").length < currentSeq.toString().split(" ").length) {
                largestSeq.setLength(0);
                largestSeq.append(currentSeq);
            }

            currentSeq.setLength(0);
        }

        System.out.println(largestSeq);

    }
}