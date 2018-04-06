package ip;
import java.util.Scanner;
public class IP {
        public static void main(String[] args) {
  
        
            
        int opcion = 0;
        Scanner tecla = new Scanner(System.in);
        BBDD ip = new BBDD();
        do{
            System.out.print("\n");
            System.out.println("Menu:");
            System.out.println("\t 1: Ingresar Alumno(para el calculo de edad y de digito verificador)");
            System.out.println("\t 2: Ingresar Profesor");
            System.out.println("\t 3: Ingresar Administrativo");
            System.out.println("\t 4: Crear Curso");
            System.out.println("\t 5: Listar alumno (para ve calculo de edad y de digito verificador)");
            System.out.println("\t 6: Listar Curso");
            System.out.println("\t 0: Salir");
            System.out.print("Ingrese Opcion: ");
            opcion = tecla.nextInt();
            
            switch(opcion){
                case 1:
                    ip.GuardaAlumno();
                    break;
                case 2:
                    ip.GuardaDocente();
                    break;
                case 3:
                    ip.GuardaAdministrativo();
                    break;
                case 4:
                    ip.GuardarCurso();
                    break;
                case 5:
                    ip.Listar();
                    break;
                case 6:
                    ip.ListarCurso();
                    break;   
                case 0:
                    System.out.println("Saliendo...");
                    break;
                default:
                    System.out.println("Opcion no valida");
                    break;
            }
            
            
        }while(opcion!=0);
    }
        
}