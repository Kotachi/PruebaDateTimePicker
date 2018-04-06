package ip;

public class Alumno extends Persona{
    int matricula;
    public Alumno(){
        this.matricula=0;
    }
    public void setMatricula(int m){
        this.matricula = m;
    }
    public int getMatricula(){
        return(this.matricula);
    }
}
