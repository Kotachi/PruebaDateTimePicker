package cine;

import java.util.Scanner;

public class modificarSala {
    
    int opcion;
    Scanner teclado = new Scanner(System.in);
    int[][] matriz;
    
    public void indicarCantidadAsientos() {
        teclado = new Scanner(System.in);
        System.out.print("Cuántas fila tiene la sala: ");
        int filas = teclado.nextInt();
        System.out.print("Cuántas columnas tiene la sala: ");
        int columnas = teclado.nextInt();
        matriz = new int[filas][columnas];

        for(int f = 0; f < matriz.length; f++) {
            for(int c = 0; c < matriz.length;c++) {
                matriz[f][c] = 0;
            }
        }
    }
    
    public void reservarAsiento() {
        System.out.print("Ingrese fila: ");
        int posxOcupar = this.teclado.nextInt();
        System.out.print("Ingrese columna: ");
        int posyOcupar = this.teclado.nextInt();
        int valorOcupar = 1;
        matriz[posxOcupar - 1][posyOcupar - 1] = valorOcupar;
    }
    
    public void liberarAsiento() {
        System.out.print("Ingrese fila: ");
        int posxLiberar = teclado.nextInt();
        System.out.print("Ingrese columna: ");
        int posyLiberar = teclado.nextInt();
        int valorLiberar = 0;
        matriz[posxLiberar - 1][posyLiberar - 1] = valorLiberar;
    }
    
    public void mostrarEstadoSala() {
        System.out.println("Mostrar estado de la sala: ");
        for (int f = 0; f < matriz.length; f++) {
            for (int c = 0; c < matriz[0].length; c++) {
                System.out.print(matriz[f][c]);
            }
            System.out.println();
        }
    }
    
}
