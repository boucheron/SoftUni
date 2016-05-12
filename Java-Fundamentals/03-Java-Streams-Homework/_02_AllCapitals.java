package com.company;

import java.io.*;

public class _02_AllCapitals {

    public static void main(String[] args) {

        File text = new File("resources/lines.txt");

        try (BufferedReader bReader = new BufferedReader(new FileReader(text))) {

            StringBuilder newText = new StringBuilder();
            String line = "";

            while ((line = bReader.readLine()) != null) {
                newText.append(line.toUpperCase() + "\r\n");
            }

            PrintWriter pw = new PrintWriter(new BufferedWriter(new FileWriter(text)));
            pw.write(newText.toString());
            pw.flush();
            pw.close();
        } catch (FileNotFoundException ex) {
            System.err.println("The file is missing!");
        } catch (IOException e) {
            e.printStackTrace();
        }

    }
}