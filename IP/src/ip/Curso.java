/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ip;

/**
 *
 * @author Marcelo
 */
public class Curso {
    
   private int  Seccion;
   private String Carrera;
   
    public Curso(){
        this.Seccion=0;
        this.Carrera=null;
        
    }

    /**
     * @return the Seccion
     */
    public int getSeccion() {
        return Seccion;
    }

    /**
     * @param Seccion the Seccion to set
     */
    public void setSeccion(int Seccion) {
        this.Seccion = Seccion;
    }

    /**
     * @return the Carrera
     */
    public String getCarrera() {
        return Carrera;
    }

    /**
     * @param Carrera the Carrera to set
     */
    public void setCarrera(String Carrera) {
        this.Carrera = Carrera;
    }
    
}
