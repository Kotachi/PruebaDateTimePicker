
package suma_matrices;
import java.util.Scanner;
public class Suma_Matrices {

    public static void main(String[] args) {
        Scanner teclado = new Scanner (System.in);
        int lf,lc;
        System.out.println("Ingrese numero de filas y columnas de las matrices: ");
        lf=teclado.nextInt();
        lc=teclado.nextInt();
        int [][] matriz1=new int [lf][lc],matriz2=new int [lf][lc],matriz3=new int [lf][lc],matriz4= new int [lf][lc];
       //ingresan los valores en las matrices
        for (int f=0;f<lf;f++){
            for(int c=0;c<lc;c++){
                System.out.println("Ingrese valor de filas "+(f+1)+" y columna "+(c+1));
                matriz1 [f][c]=teclado.nextInt();
                //matriz2 [f][c]=teclado.nextInt();          
            }
        }System.out.println("\nmatriz 1 ");
        //se muestran los valores de la matriz 1
         for (int f=0;f<lf;f++){
             System.out.println("");
            for(int c=0;c<lc;c++){
               System.out.print(matriz1[f][c]+"\t");
                
            }
        }System.out.println("\n\nmatriz 2");
         //se muestran los valores de la matriz 2
         /*for (int f=0;f<lf;f++){
             System.out.println("");
            for(int c=0;c<lc;c++){
               System.out.print(matriz2[f][c]+"\t");
                
            }
        }
         // se suman y restan la matriz uno con la matriz dos y se almacenan en matriz 3 y matriz 4
       for (int f=0;f<lf;f++){
            for(int c=0;c<lc;c++){
               matriz3 [f][c]= matriz1[f][c]+matriz2[f][c];
               matriz4 [f][c]= matriz1[f][c]-matriz2[f][c];
            }
        }
       // se muestra el resultado de la suma
        System.out.println("\n\nEl resultado de la suma es: ");
       for (int f=0;f<lf;f++){
           System.out.println("");
            for(int c=0;c<lc;c++){
                System.out.print(matriz3[f][c]+"\t");
               
            }
        }
       //El resultado de la resta
       System.out.println("\n\nEl resultado de la resta es: ");
       for (int f=0;f<lf;f++){
           System.out.println("");
            for(int c=0;c<lc;c++){
                System.out.print(matriz4[f][c]+"\t");
               
            }
        }**/
    }
    
}
