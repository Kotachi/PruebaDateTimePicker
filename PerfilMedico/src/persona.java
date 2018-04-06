/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author hp
 */
import java.util.Date;

public class persona {

    String nombre1, nombre2, apellido1, apellido2, rut,rutPro[];
    int edad, alturaCm,rutInt [],y=2,suma,DV,DV1;
    char sexo;
    float pesoKg;
    Date fechaNac;

    public persona(String Rut, String nombre1, String nombre2, String apellido1, String apellido2, int edad, int alturaCm, char sexo, float pesoKg, Date fechaNac) {
        this.nombre1 = nombre1;
        this.nombre2 = nombre2;
        this.apellido1 = apellido1;
        this.apellido2 = apellido2;
        this.edad = edad;
        this.alturaCm = alturaCm;
        this.sexo = sexo;
        this.pesoKg = pesoKg;
        this.fechaNac = fechaNac;
        this.rut = Rut;
    }

    persona() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    /* public Date edadActual (Date edad){
        Date edadAc;
        
        return edadAc;
}*/
    public int validarRut() {
        int x=0;
        String [] rutProv=new String [rut.length()];
        for (int i=0;i<rut.length();i++){
            if(rut.charAt(i)!='.' || rut.charAt(i)!='-'){
                rutProv[x]=String.valueOf(rut.charAt(i));
                x++;
            }
        }
        for (int i=rutProv.length-1;i>=0;i--){
            
            if(y>7){
                y=2;
            }
            suma+=Integer.parseInt(rutProv[i])*y;
            y++;
        }
        System.out.println("la suma del rut es "+ suma);
        //int [] multRut = new int [x];
        return suma;
        
    }

    public String getNombre1() {
        return nombre1;
    }

    public void setNombre1(String nombre1) {
        this.nombre1 = nombre1;
    }

    public String getNombre2() {
        return nombre2;
    }

    public void setNombre2(String nombre2) {
        this.nombre2 = nombre2;
    }

    public String getApellido1() {
        return apellido1;
    }

    public void setApellido1(String apellido1) {
        this.apellido1 = apellido1;
    }

    public String getApellido2() {
        return apellido2;
    }

    public void setApellido2(String apellido2) {
        this.apellido2 = apellido2;
    }

}
