package PilaEnClase;

public class PilaEnClase {
    
    class persona{
        String nombre;
        String rut;
        int peso;
        persona Siguiente;
    }
    persona primero;
    
    public PilaEnClase(){
        primero = null;
    }
    
    public void Insertar(String n, String r, int p){
        persona tmp = new persona();
        
        tmp.nombre = n;
        tmp.rut = r;
        tmp.peso = p;
        
        if(primero == null){//Si pila esta vacia
            tmp.Siguiente = null;
            primero = tmp;
        }else{//si pila tiene datos
            tmp.Siguiente = primero;
            primero = tmp;
        }
    }
    
    public void Imprime(){
        persona tmp = primero;
        
        while(tmp!=null){
            System.out.println("Rut: "+tmp.rut);
            System.out.println("\tNombre: "+tmp.nombre);
            System.out.println("\tPeso: "+tmp.peso);
            tmp = tmp.Siguiente;
        }
    }
    
    public void total(){
        persona Aux =primero;
        int cont= 0;
        
        while(Aux!=null){
            cont++;
            Aux = Aux.Siguiente;
        }
        
        System.out.println("Existen "+cont+" personas en la lista");
    }
    
    public void Mas_pesado(){
        persona Aux= primero;
        persona Gordo=primero;
        
        while(Aux!=null){
            if(Aux.peso>Gordo.peso){
                Gordo = Aux;
            }
            Aux =Aux.Siguiente;
        }
        System.out.println("El peso mayor es: "+Gordo.peso+
                " y corresponde a "+Gordo.nombre);
    }
    
    public Boolean Buscar_Rut(String rut){
        persona tmp = primero;
        Boolean var=false;
        while (tmp != null) {
            if (tmp.rut.equals(rut)) {
                System.out.println("El rut corresponde a \n"+tmp.nombre);
                System.out.println(tmp.rut);
                System.out.println(tmp.peso);
                var=true;
                break;
                
            } else {
                //System.out.println("Rut no encontrado");
                tmp=tmp.Siguiente;
                var= false;
            }

        }
        return var;
    }
    
    public void Borrar(){
        primero = primero.Siguiente;
    }
    
    public void VaciarPila(){
    persona tmp= primero;
        while(tmp!=null){
        Borrar();
        tmp=tmp.Siguiente;
        }
        System.out.println("Vacia");
    }
    
    public void Vacio(String rut){
        persona tmp = primero;
        while(tmp!=null){
        if(Buscar_Rut(rut)==true){
            Borrar();
        }
        tmp=tmp.Siguiente;
        }
    }
    
    public void ActualizarPersona(String rut, String nuevoRut, String nombre,int p){
        persona tmp = primero;
        String rutProv ="";
        while(tmp!=null){
            rutProv = tmp.rut;
            if(tmp.rut.equals(rut)){
                tmp.nombre=nombre;
                tmp.rut=nuevoRut;
                tmp.peso=p;
                //Insertar(nuevoRut,nombre,p);
                break;
            }
            tmp=tmp.Siguiente;
        }
    }
    
    public static void main(String[] args) {
        PilaEnClase Lista_clase = new PilaEnClase();
        
        Lista_clase.Insertar("Melissa", "123456", 45);
        Lista_clase.Insertar("Felipe", "35436", 160);
        Lista_clase.Insertar("ruth", "9859385", 40);
        Lista_clase.Insertar("benja", "9459348", 100);
        
        Lista_clase.Imprime();
        Lista_clase.total();
        Lista_clase.Mas_pesado();
        
        Lista_clase.Buscar_Rut("9859385");
        
        //Lista_clase.Borrar();
        Lista_clase.ActualizarPersona("9859385", "240891425", "julian",31);
        Lista_clase.Imprime();
        Lista_clase.VaciarPila();
        System.out.println("\n");
        Lista_clase.Imprime();
        
    }
}
