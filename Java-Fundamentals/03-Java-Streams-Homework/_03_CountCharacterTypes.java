package com.company;

import java.io.*;

public class _03_CountCharacterTypes {

    public static void main(String[] args) {

        File words = new File("resources/words.txt");
        File countChars = new File("resources/count-chars.txt");

        try (BufferedReader bReader = new BufferedReader(new FileReader(words));
             BufferedWriter bWriter = new BufferedWriter(new FileWriter(countChars))) {

            int vowels = 0;
            int consonants = 0;
            int punctuation = 0;
            int currentChar = 0;
            String vowelsChars = "aeiou";
            String punctuationChars = "!,.?";

            while ((currentChar = bReader.read()) != -1) {

                if (vowelsChars.contains((char) currentChar + "")) {
                    vowels++;
                } else if (punctuationChars.contains((char) currentChar + "")) {
                    punctuation++;
                } else if (Character.isLetter((char) currentChar)) {
                    consonants++;
                }
            }

            bWriter.write("Vowels: " + vowels);
            bWriter.newLine();
            bWriter.write("Consonants: " + consonants);
            bWriter.newLine();
            bWriter.write("Punctuation: " + punctuation);

        } catch (FileNotFoundException e) {
            System.err.println("The file is missing!");
        } catch (IOException e) {
            e.printStackTrace();
        }

    }
}