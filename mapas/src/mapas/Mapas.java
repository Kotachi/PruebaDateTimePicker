/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mapas;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Scanner;


/**
 *
 * @author hp
 */

public class Mapas {
    
    public static void main(String[] args) {
        String cadena;
        List numBinario = new ArrayList();
        Scanner in = new Scanner(System.in);
        int remainder,cont = 0,cons = 0;
        int n= in.nextInt();
        while (n>0){
            remainder=n%2;
            n=n/2;
            numBinario.add(remainder);
        }
        System.out.println(numBinario+"\n");
        for(int i=0;i<numBinario.size();i++){
            if(Integer.valueOf((int)numBinario.get(i))==1){
                  cont++;
                  
            }
            else{
                if(cons<cont){
                    cons=cont;
                    cont=0;
                }
                else{
                    cont=0;
                }
            }
        }
        if(cons>cont){
        System.out.println(cons);
        }
        else{
            System.out.println(cont);
        }
        /*Map<String,String> phonebook = new HashMap<String,String>();
        int n = in.nextInt();
        for(int i = 0; i < n; i++){
            String name = in.next();
            int phone = in.nextInt();
            cadena = String.valueOf(phone);
            phonebook.put(name, cadena);
            
        }
        while(in.hasNext()){
            String s = in.next();
            if(phonebook.containsKey(s)){
                System.out.println(phonebook.get(s));
            }
            else{
                System.out.println("Not found");
            }
        }*/
        
        
        in.close();
    }
    
}
