package com.company;

import java.util.Scanner;
import java.util.TreeSet;

public class _08_ExtractAllUniqueWords {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String[] totalWords = input.nextLine().split("\\W+");
        TreeSet<String> uniqueWords = new TreeSet<>();

        for (String s : totalWords) {
            uniqueWords.add(s.toLowerCase());
        }

        for (String s : uniqueWords) {
            System.out.print(s + " ");
        }

    }
}