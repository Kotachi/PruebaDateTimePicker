/*
 */
package clasesymetodos;

public class Persona {
    String nombre=null,apellido=null,color=null,patente=null,modelo=null,marca=null;
    Boolean tieneAuto=null,pinito;
    int a_o;
    Auto tipoAuto = new Auto();
    public void IngresaIdPersona(String n,String a, Boolean tA){
        
        nombre= n;
        apellido=a;
        tieneAuto=tA;
         
    }
    public void MostrarPersona (){
        System.out.println("El nombre y apellido es "+nombre+" "+apellido);
        
        if (tieneAuto == true)
         
        tipoAuto.mostrar();
    }
    
}
