/*
Crear un programa en java que permita a través de un menú de opciones hacer lo siguiente:

1.- ingresar matriz de 2x3 por teclado.
2.- mostrar matriz ingresada.
3.- mostrar matriz transpuesta.
4.- salir del programa.

 */
package matriz.transpuesta;

/**
 * @author Julian Palacios Seccion 61
 */
import java.util.Scanner;
public class MatrizTranspuesta {

    
    public static void main(String[] args) {
        //declaracion de variables
        int [][] matriz1,matriz2;
        int opcion;
        int out=1, validador=0;
        matriz1 = new int[2][3];
        matriz2 = new int [3][2];
        Scanner datos = new Scanner(System.in);
        
         while (out!=0){// bucle para continuar el programa
             System.out.println("Presione 1 para ingresar datos a la matriz.\nPresione 2 para ver los datos de la matriz.\nPresione 3 para ver la matriz transpuesta.\n");
             opcion = datos.nextInt();
        switch (opcion){// 
            case (1):
                validador=1;// para verificar si se entra a esta opcion antes que a otra
                for (int i=0;i<2;i++){
                    for (int j=0;j<3;j++){
                        System.out.println("Ingrese datos posicion [" + (i+1) + "] y [" + (j+1) + "] del vector" );
                        matriz1 [i][j] = datos.nextInt();
                    }
                }
            break;
            
            case (2):
                if (validador==1){// verificar el validador
                for (int i=0;i<2;i++){
                    System.out.println("");
                    for (int j=0;j<3;j++){
                        System.out.print(matriz1 [i][j] + "\t");
                    }
                }}else
                {System.out.println("Debe ingresar primero a la opcion 1");}
            break;   
            
            case (3):
                if (validador==1){//verifica el validador
                for (int i=0;i<3;i++){// matriz transpuesta
                    for (int j=0;j<2;j++){
                          matriz2[i][j]=matriz1[j][i];
                    }
                }
                for (int i=0;i<3;i++){// mostrar matriz transpuesta
                    System.out.println("");
                    for (int j=0;j<2;j++){
                        System.out.print(matriz2 [i][j]+"\t");
                    }
                }}
                else
                {System.out.println("Debe ingresar primero a la opcion 1");}
                break;             
            }
        System.out.println("\nSi desea salir presione 0 u otra tecla para continuar: ");
        out = datos.nextInt();
        
        }
    }
}
