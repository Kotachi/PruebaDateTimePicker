/*
SUbclase de persona y solicita los datos para los alumnos
 */
package planillaip;

import javax.swing.JOptionPane;

/**
 *
 * @author Julian Palacios
 */
public class Alumnos extends persona {
    
    protected String carrera;
    protected float notas[]=new float[3];
    float promedio=0;
    int i;
     public void IngresarAlumnos(){
        this.i=Integer.parseInt(JOptionPane.showInputDialog("Ingresar carrera del alumno: 1)analista \n 2)psicologia \n 3)finanzas"));
        switch(i){
            case 1: carrera="Analista";break;
            case 2:carrera="Psicologia";break;
            case 3:carrera="finanzas";break;
        }
        for (this.i=0;i<notas.length;i++){
        notas [this.i] = Float.parseFloat(JOptionPane.showInputDialog(null,"Ingrese nota "+(i+1)+" del alumno","Notas Alumno",JOptionPane.PLAIN_MESSAGE));
        }
    }
     
    public void MostrarAlumno(){
        System.out.println("\nEl alumno insccrito es \n"+nombre+" "+apellido+" Rut: "+RUT+"\n"+carrera+"\nTel "+telefono+"\n"+promedio);
        }
    
    public void Promedio(){
        for (this.i=0;i<notas.length;i++){
            
            promedio+=notas[this.i];
        }
        promedio=promedio/notas.length;
        System.out.printf("\nEl promedio del alumno es: "+ "%.2f",promedio);
        System.out.println();
    }
    
}
