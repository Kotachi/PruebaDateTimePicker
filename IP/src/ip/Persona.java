package ip;



public class Persona {
   public String Nombre;
   public String run;
   public String Sexo;

    private int ano_nac;
    
    public Persona(){
        this.Nombre=null;
        this.Sexo=null;
        
    }
    public void setNombre(String n){
        this.Nombre = n;
    }

    public void setSexo(String s){
        this.Sexo = s;
    }
    public String getNombre(){
        return(this.Nombre);
    }

    public String getSexo(){
        return(this.Sexo);
    }

    /**
     * @return the ano_nac
     */
    public int getAno_nac() {
        return ano_nac;
    }

    /**
     * @param ano_nac the ano_nac to set
     */
    public void setAno_nac(int ano_nac) {
        this.ano_nac = ano_nac;
    }

    /**
     * @return the run
     */
    public String getRun() {
        return run;
    }

    /**
     * @param run the run to set
     */
    public void setRun(String run) {
        this.run = run;
    }


}
