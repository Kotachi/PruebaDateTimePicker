/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sala_cine;

/**
 *
 * @author hp
 */

import javax.swing.JOptionPane;
public class TSalas {
    protected int f=0,c=0,opcion,sala,rSala;
    protected int nSala []=new int [7];
    protected int cSillas [][];
    
    
    public int EscojaSala(int sala){
                
                do{
                opcion=Integer.parseInt(JOptionPane.showInputDialog("Ingrese opcion para salas. \n1)Ver salas. \n2)Seleccionar sala."));
                switch (opcion){
                    case (1):
                            System.out.println("Ver salas disponibles: \n");
                            for (int i=0;i<nSala.length;i++){
                                System.out.print(nSala [i]+ " ");
                            }
                            break;
                    case (2):
                            System.out.println("Seleccionar sala: ");
                            sala=Integer.parseInt(JOptionPane.showInputDialog("Ingrese numero sala: "));
                            if (sala<8 && sala>0){
                                    nSala[sala-1]=1;
                                    System.out.println("La sala escogida es " + (sala));}
                                    else{
                                    JOptionPane.showMessageDialog(null,"Sala no existente.","Error",JOptionPane.ERROR_MESSAGE);
                                    }
                            break;
                }
                    opcion=Integer.parseInt(JOptionPane.showInputDialog("desea salir"));
                }while (opcion==0);
                return sala;
                                         
}
    
}
