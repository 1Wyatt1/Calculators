package com.bruh.calc;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// Whoever at Oracle though system.out.print is a good idea to print to console can suck my left nut.
        Scanner scan = new Scanner(System.in);
        double ans;

        System.out.print("Please enter an operator to use (+.-.*,/): ");
        char op = scan.next().charAt(0);
        System.out.print("Please enter the first character.");

        int onenum = scan.nextInt();
        System.out.print("Please enter the second character.");
        int twonum = scan.nextInt();

        switch(op) {
            case '+': ans = onenum + twonum;
                System.out.print(ans);
                break;
            case '-': ans = onenum - twonum;
                System.out.print(ans);
                break;
            case '*': ans = onenum * twonum;
                System.out.print(ans);
                break;
            case '/': ans = onenum / twonum;
                System.out.print(ans);
                break;
        }


    }
}