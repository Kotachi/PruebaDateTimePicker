/*
SUbclase de persona y solicita los datos para los administrativos
 */
package planillaip;

import javax.swing.JOptionPane;

/**
 *
 * @author Julian Palacios
 */
public class Administrativos extends persona {
    String cargo;
    public Administrativos(){
        super();
    }
    public void IngresarAdministrativo(){
        cargo=JOptionPane.showInputDialog("Ingrese cargo: ");
    }
    public void MostrarAdministrativo(){
        System.out.println("\nEl administrativo insccrito es \n"+nombre+" "+apellido+" Rut "+RUT+"\n"+cargo+"\n");
    }
    
}
