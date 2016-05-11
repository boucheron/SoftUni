package com.company;

import java.util.Scanner;

public class _05_GhettoNumeralSystem {
    public static void main(String[] args){

        Scanner input = new Scanner(System.in);
        String number = input.nextLine();
        String ghettoNumber = "";

        for (int i = 0; i < number.length(); i++) {

            char currentDigit = number.charAt(i);

            switch (currentDigit){
                case '1': ghettoNumber += "Bro"; break;
                case '2': ghettoNumber += "Zuz"; break;
                case '3': ghettoNumber += "Ma"; break;
                case '4': ghettoNumber += "Duh"; break;
                case '5': ghettoNumber += "Yo"; break;
                case '6': ghettoNumber += "Dis"; break;
                case '7': ghettoNumber += "Hood"; break;
                case '8': ghettoNumber += "Jam"; break;
                case '9': ghettoNumber += "Mack"; break;
                default: ghettoNumber += "Gee"; break;
            }
        }

        System.out.println(ghettoNumber);

    }
}