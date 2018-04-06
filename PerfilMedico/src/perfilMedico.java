
import java.util.Date;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author hp
 */
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author hp
 */
public class perfilMedico extends persona {

    public perfilMedico(String rut,String nombre1, String nombre2, String apellido1, String apellido2, int edad, int alturaCm, char sexo, float pesoKg, Date fechaNac) {
        super(rut,nombre1, nombre2, apellido1, apellido2, edad, alturaCm, sexo, pesoKg, fechaNac);
    }
    
    public float imc (int pesoKG, int alturaCm){
        float imc,alturaM;
        alturaM = alturaCm/100;
                imc=pesoKG/(alturaM*alturaM);
        return imc;
    }
    
}