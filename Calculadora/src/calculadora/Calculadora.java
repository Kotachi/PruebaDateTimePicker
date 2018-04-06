package calculadora;

public class Calculadora {

    public static void main(String[] args) {
        Suma suma = new Suma();
        
        suma.setValor1(10);
        suma.setValor2(20);
        suma.operar();
        System.out.println("Resultado: "+suma.getResultado());
    }
    
}
