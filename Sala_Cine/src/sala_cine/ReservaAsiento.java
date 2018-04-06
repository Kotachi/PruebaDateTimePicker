/*

 */
package sala_cine;
import java.util.Scanner;
import javax.swing.JOptionPane;

/**
 * @author hp
 */
public class ReservaAsiento extends TSalas{
    protected int f,c,numSala,opcion;
   Scanner teclado = new Scanner (System.in);
    protected int cantSillas [][] = new int [5][5];
    protected TSalas Asientos;
    public void EscogerAsiento(){
        do{
            opcion=Integer.parseInt(JOptionPane.showInputDialog("Ingresa opcion para asientos: \n1) Escoger Asiento. \n2)Ver Asiento."));
            switch(opcion){
                case (1):
                        
                        
                        System.out.println("\nIngrese el asiento donde desea sentarse. ");
                        f=teclado.nextInt();
                        c=teclado.nextInt();
                        cantSillas[f-1][c-1]=1;
                        break;
                case (2):
            for (int[] cantSilla : cantSillas) {
                System.out.println("\n");
                for (int j = 0; j<cantSillas.length; j++) {
                    System.out.print(cantSilla[j] + " ");
                }
            }
            break;
            
            
            }
        opcion=Integer.parseInt(JOptionPane.showInputDialog("desea salir"));
        }while (opcion==0);
    }
  
    
}
