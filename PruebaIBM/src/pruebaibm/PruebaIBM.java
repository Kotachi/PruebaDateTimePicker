/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebaibm;

/**
 *
 * @author hp
 */
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import static java.lang.Math.pow;
import java.nio.charset.StandardCharsets;


public class PruebaIBM {

    
    public static void main(String[] args) throws IOException {
        
    InputStreamReader reader = new InputStreamReader(System.in, StandardCharsets.UTF_8);
    BufferedReader in = new BufferedReader(reader);
    String line="";
    int num=0,var=1;
    line = in.readLine();
    if (Integer.parseInt(line) !=0)
    for (int i=0;i<Integer.parseInt(line);i++){
      
        num+=var;
        var=num-var;
        
         System.out.print(" " + num);
    }else
    {
        System.out.println(0);
    }
       
    }
    }
