/*

 */
package hroperadores;

import static java.lang.Math.round;
import static java.lang.Math.round;
import java.util.Scanner;
/*Given an integer, , perform the following conditional actions:

If  is odd, print Weird
If n is even and in the inclusive range of 2 to 5, print Not Weird
If n is even and in the inclusive range of 6 to 20, print Weird
If n is even and greater than 20 , print Not Weird*/

/**
 *
 * @author hp
 */
class persona {
    int  age;
    persona (int initialAge){
        if (initialAge>0){
        this.age = initialAge;
        }else{
            age=0;
            System.out.println("Age is not valid, setting age to 0.");
        }
    }
    public void yearPasses(){
        age++;
    }
    public String amIOld(int age){
        
        String yearsOld="";
        if (age<13){
            yearsOld ="you are young";
        }else{
            if(age>=13 && age<18){
                yearsOld="You are a teenager";
            }else{
                yearsOld="You are old";
            }
        }
        return yearsOld;
    }
}
public class HRoperadores {

    
    public static void main(String[] args) {
        
        int numTestCase,indexEsp=0;
        String S;
        char [] cadena;
        
        
            Scanner in = new Scanner(System.in);
            
            System.out.println("Ingrese numero de casos");

            numTestCase = in.nextInt();
            
            for(int i=0;i<numTestCase;i++){
                System.out.println("\nIngrese cadena ");
                S=in.next();
                cadena = new char [S.length()];
                for(int z=0;z<S.length();z++){
                    cadena[z]=S.charAt(z);
                }
                
                for(int y=S.length();y>=0;y--){
                    if(y%2==0){
                        System.out.print(cadena[y]);
                    }
                }
                
                System.out.print("\t\t");
                
                for(int x=0; x<S.length();x++){
                    if(x%2!=0){
                        System.out.print(cadena[x]);
                    }
                }
                
            }
            
        
           /*Scanner in = new Scanner(System.in);
           double meal_cost = in.nextDouble();
           int tip_percent = in.nextInt();
           int tax_percent = in.nextInt();
           
           double total_cost,tip,tax;
           in.close();
           
          
           
           
           tip = (meal_cost * (double)tip_percent/100);
           tax = meal_cost * ((double)tax_percent/100);
                              
           total_cost = (meal_cost + tip + tax);
                      
           System.out.println("The total meal cost is "+ round(total_cost)+" dollars.");*/
           
            /*Scanner scan = new Scanner(System.in);
            int n = scan.nextInt(); 
            scan.close();
            String ans="";
           
            if(n%2==1)
            {
         ans = "Weird";
            }
      else
            {
                if (n%2==0 && n>=2 && n<=5)
                {
                    System.out.println("Not Weird");
                }
                else
                {
                    if (n%2==0 && n>=6 && n<=20)
                    {
                        System.out.println("Weird");
                    }
                    else
                    {
                        if (n%2==0 && n>20)
                            System.out.println("Not Weird");
                    }
                }
          
            }
      System.out.println(ans);*/
         
           
    }
    
}
