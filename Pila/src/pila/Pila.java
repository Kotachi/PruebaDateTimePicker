

package pila;



public class Pila {
    
    class Persona {
       String nombre;
       String rut;
       int peso;
       Persona siguiente;
    }

    Persona primero;
    
    public Pila (){
        primero=null;
    }
    
    /**
     * @param persona
     */
    public void insertar (String n,String r,int p){
        Persona tmp = new Persona();
        tmp.nombre=n;
        tmp.rut=r;
        tmp.peso=p;
        if(primero != null){
            tmp.siguiente=null;
            primero=tmp;
        }
        else{
            tmp.siguiente=primero;
            primero=tmp;
            
        }
    }
    
    public void imprime (){
        Persona tmp = primero;
        while(tmp.siguiente != null){
            System.out.println("Rut "+ tmp.rut+" nombre "+tmp.nombre+" peso "+tmp.peso);
            tmp = tmp.siguiente;
    }
    }
    
    public static void main(String[] args) {
        
    }
    
}
