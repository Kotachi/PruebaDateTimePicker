/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package palindromos;

import java.util.Arrays;
import javax.swing.JOptionPane;

/**
 *
 * @author hp
 */
public class PALINDROMOS {

    public static void main(String[] args) {
        
       int a[]={4, 2, 3, 1, 5 ,3};
       int cont=0;
       
       for (int i=0;i<a.length-2;i++){
           if ((a[i]>a[i+1])&&(a[i+1]<a[i+2])||(a[i]<a[i+1])&&(a[i+1]>a[i+2])){
                cont+=2;
           }
           
       }
       
        System.out.println(cont);
    }    
}
