/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hackerrank1;


import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class HackerRank1 {

    
    public static void main(String[] args) {
     
        int i = 4;
        double d = 4.0;
        String s = "HackerRank ";
		
        Scanner scan = new Scanner(System.in);
        
        
        String cadena = scan.nextLine();
        //scan.next();
        int numEntero = scan.nextInt();
        //scan.nextLine();
        double numReal = scan.nextDouble();
        
        
        
        double result = 0;
        
        result = numReal + d;
        
    System.out.println("El resultado es: " + (i+numEntero));
    System.out.printf("El resultado es: %.2f%n",result ); 
    System.out.println("La cadena es: " + s + cadena);
    
    scan.close();
    }
    
}
