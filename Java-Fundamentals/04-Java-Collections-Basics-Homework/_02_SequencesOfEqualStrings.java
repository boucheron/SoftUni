package com.company;

import java.util.Scanner;

public class _02_SequencesOfEqualStrings {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] line = input.nextLine().split(" ");
        StringBuilder sequence = new StringBuilder();

        for (int i = 0; i < line.length; i++) {
            sequence.append(line[i]);

            for (int j = i + 1; j < line.length; j++) {
                if (line[i].equals(line[j])) {
                    sequence.append(" " + line[j]);
                    i = j;
                } else {
                    break;
                }
            }

            System.out.println(sequence);
            sequence.setLength(0);
        }

    }
}