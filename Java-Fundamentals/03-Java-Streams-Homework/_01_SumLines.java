package com.company;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class _01_SumLines {

    public static void main(String[] args) {

        try (BufferedReader bfr = new BufferedReader(new FileReader("resources/lines-src/lines.txt"))) {
            String line = "";

            while ((line = bfr.readLine()) != null) {
                int symbolsSum = 0;
                for (int i = 0; i < line.length(); i++) {
                    symbolsSum += line.charAt(i);
                }
                System.out.println(symbolsSum);
            }
        } catch (FileNotFoundException e) {
            System.err.println("The file is missing!");
        } catch (IOException e) {
            System.err.println("Can't read the file!");
        } catch (Exception ex) {
            ex.printStackTrace();
        }

    }
}