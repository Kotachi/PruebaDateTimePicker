/*
 *Implementar un software que permita a travez de un menu de opciones
 *ingresar datos de alumnos, profesores,administrativos de ip los leones.
 */
package planillaip;

/**
  * @author Julian Palacios,marcelo martinez,ximena gonzalez,osmery ulloa
 */

import java.awt.Container;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
public class PlanillaIp extends PlanillaIPVisual{
   
  /** funcion para array  
   * static Alumnos [] alumn  = new Alumnos [100];
    static int indG=0,indM;
    
      public static void guardaAlumno(){
           alumn [indG]= new Alumnos();
          
          alumn [indG].IngresarDatos();
          alumn [indG].IngresarAlumnos();
         
          indG++;
      }
      public static void mostrarAlumno(){
          indM=(indM=Integer.parseInt(JOptionPane.showInputDialog("Numero de alumno que desea mostrar")))-1;
          alumn[indM].MostrarDatos();
          alumn[indM].MostrarAlumno();
      }
     * @param args
    **/
    public static void main(String[] args) {
       int opcion,menu=0,validador=0;
       Alumnos alumno1= new Alumnos();
       Profesores profesor = new Profesores();
       Administrativos admin = new Administrativos();
       Cursos curs = new Cursos();
       
       JFrame Ventana = new JFrame ("IP Los Leones");
       Container C = Ventana.getContentPane();
       
       Ventana.pack();
       Ventana.setVisible(true);
       
       opcion=Integer.parseInt(JOptionPane.showInputDialog("1) Para alumnos.\n2)Para profesor.\n3)Para administrativo\n4)Para cursos."));
          while(opcion<5 && opcion>0){
         if (opcion<5 && opcion > 0){  
           switch(opcion){
               case (1):
                   opcion=Integer.parseInt(JOptionPane.showInputDialog("1) Para ingresar alumno\n2) Para mostrar alumno"));
                   while(opcion==1 || opcion==2){
                   switch (opcion){
                       case (1):
                                validador=1;
                               //lineas omitidas para funcion del array
                                //guardaAlumno();
                               /** Los datos originales del programa
                                * alumno1.IngresarDatos();
                                alumno1.IngresarAlumnos();
                                menu++;---------------------------------**/
                                //alumno1.guardaAlumno();
                                alumno1.guardaAlumno();
                                break;
                       case (2):
                             if (validador==1){
                                 //lineas omitidas para funcion del array
                                 //menu=Integer.parseInt(JOptionPane.showInputDialog("Ingrese numero de alumno que desea ver. "));
                                 //mostrarAlumno();
                                /**Datos originales del programa
                                alumno1.MostrarAlumno();
                                alumno1.Promedio();----------------------**/
                                alumno1.mostrarAlumnos();
                                break;}
                             else{JOptionPane.showMessageDialog(null,"Debe haber ingresado antes un alumno","Error",JOptionPane.ERROR_MESSAGE);}
                   }
                   opcion=Integer.parseInt(JOptionPane.showInputDialog("1) Para ingresar alumno\n2) Para mostrar alumno"));
                   }
                   break;
                   
               case (2):   
                   opcion=Integer.parseInt(JOptionPane.showInputDialog("1) Para ingresar profesor\n2) Para mostrar profesor"));
                   while (opcion==1 || opcion==2){
                   switch(opcion){
                       case(1):
                           validador=1;
                           profesor.guardaProfesores();                           
                           break;
                        case(2):
                            if (validador==1){
                            profesor.mostrarProfesores();
                            break;}
                            else{JOptionPane.showMessageDialog(null,"Debe haber ingresado antes un alumno","Error",JOptionPane.ERROR_MESSAGE);}
                                }
                  // menu=Integer.parseInt(JOptionPane.showInputDialog("Presione 0 para continuar en el programa profesor."));
                  opcion=Integer.parseInt(JOptionPane.showInputDialog("1) Para ingresar profesor\n2) Para mostrar profesor"));
                   }
                   break;
                   
               case (3):
                   
                   opcion=Integer.parseInt(JOptionPane.showInputDialog("1) Para ingresar administrativo\n2) Para mostrar administrativo"));
                   while (opcion==1 || opcion==2){
                   switch(opcion){
                        case(1):
                            admin.guardaAdmins();
                            break;
                        case(2):
                            admin.mostrarAdmins();
                            break;
                                 }
                  // menu=Integer.parseInt(JOptionPane.showInputDialog("Presione 0 para continuar en el programa administrativo."));
                  opcion=Integer.parseInt(JOptionPane.showInputDialog("1) Para ingresar administrativo\n2) Para mostrar administrativo"));
                   }
                   break;
               case (4):
                   opcion=Integer.parseInt(JOptionPane.showInputDialog("1) Para crear curso\n2) Para mostrar curso"));
                   while (opcion==1 || opcion==2){
                   switch(opcion){
                        case(1):
                            int i=0,j=0,k;
                            k=Integer.parseInt(JOptionPane.showInputDialog("Ingrese 1 para profesor 2 para alumnos"));
                            curs.CrearCursos(k,alumno1,profesor);
                            i++;
                            j++;
                            break;
                        case(2):
                            curs.mostrarCursos();
                            break;
                                 }
                  // menu=Integer.parseInt(JOptionPane.showInputDialog("Presione 0 para continuar en el programa administrativo."));
                  opcion=Integer.parseInt(JOptionPane.showInputDialog("1) Para ingresar Cursos\n2) Para mostrar Cursos"));
                   }break;
           }
         }
         else{JOptionPane.showMessageDialog(null,"Opcion no valida","Error",JOptionPane.ERROR_MESSAGE);}
         opcion=Integer.parseInt(JOptionPane.showInputDialog("1) Para alumnos.\n2)Para profesor.\n3)Para administrativo\n4)Para cursos."));
           //menu=Integer.parseInt(JOptionPane.showInputDialog("Presione 0 para continuar en el programa."));
       }
          
    }
}
