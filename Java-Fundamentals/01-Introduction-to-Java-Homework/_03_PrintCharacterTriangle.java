package com.company;

import java.util.Scanner;

public class _03_PrintCharacterTriangle {

    public  static void main(String[] args){

        Scanner input = new Scanner(System.in);
        int number = Integer.parseInt(input.nextLine());

        for (int i = 0; i <= number; i++) {
            for (char j = 'a'; j < 97 + i; j++) {
                System.out.print(j + " ");
            }
            System.out.println();
        }

        for (int i = number - 1; i > 0; i--) {
            for (char j = 'a'; j < 97 + i; j++) {
                System.out.print(j + " ");
            }
            System.out.println();
        }

    }
}