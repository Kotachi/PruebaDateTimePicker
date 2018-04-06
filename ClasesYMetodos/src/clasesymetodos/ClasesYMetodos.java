/*
 */
package clasesymetodos;

/**
 *
 * @author hp
 */
import java.util.Scanner;
public class ClasesYMetodos {

    public static void main(String[] args) {
        String color,patente,modelo,marca,nombre,apellido;
        int a_o;
        boolean pinito,asignarAuto;
        Auto auto = new Auto();
        Persona alguien = new Persona();
        Scanner teclado = new Scanner(System.in);
        System.out.println("Ingrese color del auto: ");
        color = teclado.nextLine();
        System.out.println("Ingrese patente del auto: ");
        patente = teclado.nextLine();
        System.out.println("Ingrese modelo del auto: ");
        modelo = teclado.nextLine();
        System.out.println("Ingrese marca del auto: ");
        marca = teclado.nextLine();
        System.out.println("Ingrese año del auto: ");
        a_o = teclado.nextInt();
        System.out.println("Ingrese si el auto tiene pinito: ");
        pinito = teclado.nextBoolean();
        System.out.println("Desea asignar este auto a alguien ");
        asignarAuto = teclado.nextBoolean();
        System.out.println("El nombre es: ");
        nombre = teclado.nextLine();
        System.out.println("El apellido es: ");
        apellido = teclado.nextLine();
        alguien.IngresaIdPersona(nombre, apellido, asignarAuto);
        auto.AgregaDatos(color, patente, modelo, marca, a_o, pinito);
        alguien.MostrarPersona();
        
        
       
    }
    
}
