package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _01_Royalism {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String[] names = input.nextLine().split(" ");

        List<String> royalists = new ArrayList<>();
        List<String> nonRoyalists = new ArrayList<>();

        for (String name : names) {
            int sum = 0;
            for (int i = 0; i < name.length(); i++) {
                sum += name.charAt(i);
                if (sum > 26) {
                    while (sum > 26) {
                        sum -= 26;
                    }
                }
            }

            if (sum == 18) {
                royalists.add(name);
            } else {
                nonRoyalists.add(name);
            }

        }

        if (royalists.size() >= nonRoyalists.size()) {
            System.out.println("Royalists - " + royalists.size());
            for (String name : royalists) {
                System.out.println(name);
            }
            System.out.println("All hail Royal!");
        } else {
            for (String name : nonRoyalists) {
                System.out.println(name);
            }
            System.out.println("Royalism, Declined!");
        }

    }
}