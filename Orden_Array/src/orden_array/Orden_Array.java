/*
2)Cargar un vector de 10 elementos (String) y verificar posteriormente si el mismo está ordenado de menor a mayor.
*/
package orden_array;

import java.util.Arrays;
import javax.swing.JOptionPane;
public class Orden_Array {

 
    public static void main(String[] args) {
        String [] Array;
        int mayor,menor,com;
        
        
        Array = new String [10];
        
        for (int i=0;i<Array.length;i++)
        {
            Array [i] = JOptionPane.showInputDialog(null,"Ingrese dato " + (i+1) + ": ", "Ingreso de datos",JOptionPane.PLAIN_MESSAGE);
        }
        JOptionPane.showMessageDialog(null,"Los datos ingresados son: \n1) " +Array[0]+"\n2) "+Array[1]+"\n3) "+Array[2]+"\n4) "+Array[3]+"\n5) "+Array[4]+"\n6) "+Array[5]+"\n7) "+Array[6]+"\n8) "+Array[7]+"\n9) "+Array[8]+"\n10) "+Array[9]);
        
                  
        Arrays.sort(Array);
        
        for (int i=0;i<Array.length;i++)
        {
            System.out.println("indice " + i + " es: " + Array[i]);
        }
               
        JOptionPane.showMessageDialog(null,"Los datos ordenados son: \n1) " +Array[0]+"\n2) "+Array[1]+"\n3) "+Array[2]+"\n4) "+Array[3]+"\n5) "+Array[4]+"\n6) "+Array[5]+"\n7) "+Array[6]+"\n8) "+Array[7]+"\n9) "+Array[8]+"\n10) "+Array[9]);
    
    }
    
}
