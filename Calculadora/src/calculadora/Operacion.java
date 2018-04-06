package calculadora;

public class Operacion {
    protected int valor1;
    protected int valor2;
    protected int Resultado;
    
    public void setValor1(int x){
        this.valor1 = x;
    }
    public void setValor2(int x){
        this.valor2 = x;
    }
    public void setResultado(int x){
        this.Resultado = x;
    }
    public int getValor1(){
        return(this.valor1);
    }
    public int getValor2(){
        return(this.valor2);
    }
    public int getResultado(){
        return(this.Resultado);
    }
}
