package com.company;

import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.Scanner;

public class _02_RoyalNonStop {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String[] matrixSize = input.nextLine().split(" ");
        int matrixRow = Integer.parseInt(matrixSize[0]);
        int matrixCol = Integer.parseInt(matrixSize[1]);

        String[] productsPrices = input.nextLine().split(" ");
        double lukankaPrice = Double.parseDouble(productsPrices[0]);
        double rakijaPrice = Double.parseDouble(productsPrices[1]);

        BigDecimal moneyEarned = BigDecimal.ZERO;
        double currentPrice = 0.0;
        int customers = 0;

        String command = input.nextLine();
        while (!command.equals("Royal Close")) {
            String[] data = command.split(" ");
            int row = Integer.parseInt(data[0]);
            int col = Integer.parseInt(data[1]);

            if (row < col) {
                for (int i = row; i >= 0; i--) {
                    if (i % 2 == 0) {
                        currentPrice = lukankaPrice;
                    } else {
                        currentPrice = rakijaPrice;
                    }

                    moneyEarned = moneyEarned.add(new BigDecimal((currentPrice) * (i + 1) * (col + 1)));
                }

                for (int i = col - 1; i >= 1; i--) {
                    moneyEarned = moneyEarned.add(new BigDecimal((currentPrice) * (i + 1)));
                }
            } else {
                if (row % 2 == 0) {
                    currentPrice = lukankaPrice;
                } else {
                    currentPrice = rakijaPrice;
                }

                for (int i = col; i >= 0; i--) {
                    moneyEarned = moneyEarned.add(new BigDecimal((currentPrice) * (i + 1) * (row + 1)));
                }

                for (int i = row - 1; i >= 1; i--) {
                    if (i % 2 == 0) {
                        currentPrice = lukankaPrice;
                    } else {
                        currentPrice = rakijaPrice;
                    }

                    moneyEarned = moneyEarned.add(new BigDecimal((currentPrice) * (i + 1)));
                }
            }

            customers++;
            command = input.nextLine();
        }

        System.out.printf("%s\n%d", moneyEarned.setScale(6, RoundingMode.HALF_UP), customers);
    }
}