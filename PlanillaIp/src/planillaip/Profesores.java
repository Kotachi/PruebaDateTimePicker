/*
SUbclase de persona y solicita los datos para los profesores
 */
package planillaip;

import javax.swing.JOptionPane;

/**
 *
 * @author Julian Palacios
 */
public class Profesores extends persona {
    protected String materia,jornada;
    public Profesores(){
        super();
    }
    public void IngresarProfesor(){
        materia=JOptionPane.showInputDialog("Ingrese materia que enseña el profesor: ");
        jornada=JOptionPane.showInputDialog("Ingrese jornada: ");
    }
    public void MostrarProfesor(){
        System.out.println("\nEl profesor insccrito es \n"+nombre+" "+apellido+" Rut "+RUT+"\n"+materia+"\n"+jornada);
    }
    
}
