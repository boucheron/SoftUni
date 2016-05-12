package com.company;

import java.util.*;

public class _09_MostFrequentWord {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String[] totalWords = input.nextLine().split("\\W+");
        TreeMap<String, Integer> frequencyOfWords = new TreeMap<>(String.CASE_INSENSITIVE_ORDER);

        for (String word : totalWords) {
            Integer counter = frequencyOfWords.get(word);
            if (counter == null) {
                counter = 0;
            }
            frequencyOfWords.put(word.toLowerCase(), counter + 1);
        }

        int maxCounter = Collections.max(frequencyOfWords.values());

        for (Map.Entry<String, Integer> entry : frequencyOfWords.entrySet()) {
            if (entry.getValue() == maxCounter) {
                System.out.println(entry.getKey() + " -> " + entry.getValue() + " times");
            }
        }

    }
}