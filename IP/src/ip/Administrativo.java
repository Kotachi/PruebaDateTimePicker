package ip;

public class Administrativo extends Persona {
    String cargo;
    
    public void setCargo(String c){
        this.cargo = c;
    }
    public String getCargo(){
        return(this.cargo);
    }
}
