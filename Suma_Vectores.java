/*
 Cargar dos vectores de 6 elementos y sumar su valores indice a indice, guardar resultado en un tercer vector.
 */
package suma_vectores;

import static java.lang.Integer.parseInt;
import javax.swing.JOptionPane;
public class Suma_Vectores {

   
    public static void main(String[] args) {
        //DECLARACION DE VARIABLES
        int [] vector1;
        int [] vector2;
        int [] vector3;
        int l=6;
        // SE DEFINE EL TAMAÑO DE LOS ARRAY
        vector1 = new int [l];
        vector2 = new int [l];
        vector3 = new int [l];
        
            // LOS CICLOS FOR SE UTILIZAN PARA INGRESAR LOS DATOS AL ARRAY
            for (int i=0;i<l;i++)
            {
                vector1 [i] = parseInt(JOptionPane.showInputDialog(null,"Ingrese valor " + (i+1) + " para Array1","Vector 1",JOptionPane.PLAIN_MESSAGE));
               //System.out.println(vector1 [i] );
            }
            for (int i=0;i<l;i++)
            {
                vector2 [i] = parseInt(JOptionPane.showInputDialog(null,"Ingrese valor " + (i+1) + " para Array2","Vector 2",JOptionPane.PLAIN_MESSAGE));
                //System.out.println(vector2 [i] );
            }
            // SE USA PARA REALIZAR LA SUMA DE LOS VECTORES INDICE POR INDICE Y GUARDAR LOS RESULTADOS EN "VECTOR3"
            for (int i=0;i<l;i++)
            {
                vector3 [i] = vector1 [i] + vector2 [i];   
            }
            //ESTE CICLO ES PARA MOSTRAR POR PANTALLA LOS VALORES ALMACENADOS EN "VECTOR3"
            for (int i=0;i<vector3.length;i++)
            {
                JOptionPane.showMessageDialog(null,"La suma de los vectores son: Indice " + i + "= " + vector3 [i],"Total vectores",JOptionPane.PLAIN_MESSAGE);
                              
            }
           
    }
    
}
