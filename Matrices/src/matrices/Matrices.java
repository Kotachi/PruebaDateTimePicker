/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package matrices;
import java.util.Scanner;
public class Matrices {
    
    public static void main(String[] args) {
     Scanner teclado = new Scanner (System.in);
        int [][] Matriz = new int [3][3];
     for (int f=0;f<3;f++){
         for(int c=0;c<3;c++){
             System.out.println("Ingrese valor de fila ["+(f+1)+"] y columna ["+(c+1)+"]");
             Matriz [f][c]= teclado.nextInt();
         }
     }
          for (int f=0;f<3;f++){
              System.out.println("");
         for(int c=0;c<3;c++){
             System.out.print(Matriz[f][c]+" ");
         }
     }
    }
    
}
