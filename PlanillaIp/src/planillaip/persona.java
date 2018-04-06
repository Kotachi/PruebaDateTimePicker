/*
 LA SUPER CLASE contiene la mayor cantidad de atributos para las demas clases
 */
package planillaip;

/**
 *
 * @author hp
 */

import java.time.*;
import java.time.format.DateTimeFormatter;
import javax.swing.JOptionPane;
public class persona extends DatosIP{

    /**
     *
     */
    protected LocalDate anaci;
    protected String nombre,apellido,RUT,DV,aNacimiento,edad []=new String [3];
    protected int telefono,mult [],DV1,Val,c=2,x;
    public void IngresarDatos(){
        this.nombre = JOptionPane.showInputDialog("Ingrese nombre: ");
        this.apellido = JOptionPane.showInputDialog("Ingrese apellido: ");
       this.RUT = JOptionPane.showInputDialog("Ingrese rut sin digito verificador: ");
       this.DV = JOptionPane.showInputDialog("Ingrese Digito verificador");
       ValidarRut();
       Edad();
       this.telefono = Integer.parseInt(JOptionPane.showInputDialog("Ingrese telefono"));
        
}
    
    public void Edad(){
        aNacimiento = JOptionPane.showInputDialog("Ingrese año y mes de nacimiento. Formato (AAAA-MM-DD)");
        anaci = LocalDate.parse(aNacimiento, DateTimeFormatter.ISO_DATE);
        Period anos = Period.between(anaci,LocalDate.now());
        System.out.printf("Tiene %s años, %s meses, %s dias: ",anos.getYears(),anos.getMonths(),anos.getDays());}
      
        public void ValidarRut (){
        mult  = new int [RUT.length()];
        int r = RUT.length();
          int j=0;
            for (int i=r;i>0;i--){
                x=Integer.parseInt(String.valueOf(RUT.charAt(i-1)));
                if(c>7){c=2;}
                mult [j]=x*c; 
                c++;
                j++;
                }
            for (j=0;j<mult.length;j++){
                Val+=mult[j];
                }
            Val=Val%11;
            Val=11-Val;
            DV1=Integer.parseInt(DV);
            if(Val<12){
                if (Val==DV1){
                    System.out.println("RUT valido "+Val+" "+DV );}
                else{
                if (Val==10){
                    System.out.println("RUT valido "+Val+" "+DV );}
                else{
                if (Val==11){
                    System.out.println("RUT valido "+Val+" "+DV );}
                else{System.out.println("Rut invalido");}}
                }
            }
            else{
                 System.out.println("RUT invalido"+Val+" "+DV);
                 }
    }
    public void MostrarDatos(){
        System.out.println("\nla persona inscrita es "+nombre+" "+apellido+" "+RUT);
      
    }
    
    
    
    
}
