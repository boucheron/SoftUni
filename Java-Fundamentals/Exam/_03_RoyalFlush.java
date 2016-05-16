package com.company;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _03_RoyalFlush {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int lines = Integer.parseInt(input.nextLine());
        String data = "";
        for (int i = 0; i < lines; i++) {
            data += input.nextLine();
        }

        HashMap<String, String> cardsBySuit = new HashMap<>();
        Pattern regexCard = Pattern.compile("([\\dJQKA]+)([cdhs])");
        Matcher extractCard = regexCard.matcher(data);
        int flushFound = 0;

        while (extractCard.find()) {
            String cardFace = extractCard.group(1);
            String cardSuit = extractCard.group(2);

            if (!cardsBySuit.containsKey(cardSuit)) {
                cardsBySuit.put(cardSuit, cardFace);
            } else {
                cardsBySuit.put(cardSuit, cardsBySuit.get(cardSuit) + cardFace);
            }

            if (cardsBySuit.get(cardSuit).contains("10JQKA")) {
                String flushSuit = "";
                switch (cardSuit) {
                    case "c": flushSuit = "Clubs"; break;
                    case "d": flushSuit = "Diamonds"; break;
                    case "h": flushSuit = "Hearts"; break;
                    case "s": flushSuit = "Spades"; break;
                }

                System.out.println("Royal Flush Found - " + flushSuit);
                cardsBySuit.put(cardSuit, "");
                flushFound++;
            }
        }

        System.out.println("Royal's Royal Flushes - " + flushFound + ".");

    }
}