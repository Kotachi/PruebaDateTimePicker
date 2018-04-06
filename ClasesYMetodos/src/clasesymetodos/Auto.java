/*
 */
package clasesymetodos;

import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.Date;

/**
 *
 * @author hp
 */
public class Auto {
    String color,patente,modelo,marca;
    int a_o;
    boolean pinito;
    public Auto(){
        color=null;
        patente=null;
        modelo=null;
        marca=null;
        pinito=false;
        a_o=0;
    }
    public void AgregaDatos(String C, String P, String Mo, String Ma, int a, boolean f){
        color = C;
        patente = P;
        modelo= Mo;
        marca = Ma;
        a_o = a;
        pinito = f;
    }
    public void mostrar(){
        System.out.println("Marca " + marca + " patente "+patente+" modelo "+modelo+" marca "+marca + " año "+a_o+ " tiene pinito? "+pinito);
        //Calendar año = new GregorianCalendar.getInstance();
        //System.out.println("El auto tiene "+(this.));
        Date anno = new Date();
        long fecha = anno.getYear();
        System.out.println(fecha);
       // System.out.println("El auto tiene "+(fecha-a_o)+" años");
    }
    
}
