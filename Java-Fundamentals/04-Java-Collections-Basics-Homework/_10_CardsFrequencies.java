package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class _10_CardsFrequencies {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String[] playingCards = input.nextLine().split("[♥♠♦♣]");
        LinkedHashMap<String, Integer> cardFrequency = new LinkedHashMap<>();

        for (String s : playingCards) {
            String card = s.trim();
            if (cardFrequency.containsKey(card)) {
                cardFrequency.put(card, cardFrequency.get(card) + 1);
            } else {
                cardFrequency.put(card, 1);
            }
        }

        for (Map.Entry<String, Integer> entry : cardFrequency.entrySet()) {
            double cardAppearances = (entry.getValue() / (double) playingCards.length) * 100;
            System.out.printf("%s -> %.2f%%%n", entry.getKey(), cardAppearances);
        }

    }
}