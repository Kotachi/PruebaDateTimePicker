package cine;

import java.util.Scanner;

public class Sala extends modificarSala {
    
    public void menuSalas() {
    
        do{
            System.out.println("#####Opciones#####");
            System.out.println("(1) Indicar cantidad de asiento en sala: ");
            System.out.println("(2) Ocupar Asiento ");
            System.out.println("(3) Desocupar Asiento ");
            System.out.println("(4) Mostrar Sala");
            System.out.println("(0) Salir");
            System.out.print("Ingrese su opcion: ");
            this.opcion = this.teclado.nextInt();

            switch(this.opcion){
                case 1:
                    indicarCantidadAsientos();
                    break;
                case 2:
                    reservarAsiento();
                    break;

                case 3:
                    liberarAsiento();
                    break;

                case 4:
                    mostrarEstadoSala();
                    break;
                    
                case 0:
                    System.out.println("Salida de sistema.");
                    break;
                    
                default:
                    System.out.println("Opción no válida");
                    break;
            }

        }while(this.opcion != 0);
    }
}
