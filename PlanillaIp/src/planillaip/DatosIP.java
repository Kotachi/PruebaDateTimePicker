/*
 Aqui se guardaran los datos que se ingresen para cada clase
 */
package planillaip;

/**
 *
 * @author Julian Palacios
 */
import javax.swing.JOptionPane;
public class DatosIP {
    
    
     Alumnos [] alumn  = new Alumnos [100];
     Profesores [] prof = new Profesores [100];
     Administrativos [] admin = new Administrativos[100];
     Cursos curso [][] = new Cursos[1][4];
    int indG=0,indM=0,j=0,i=0,opcion;
    
    
      public Alumnos guardaAlumno(){
          alumn [this.indG]= new Alumnos();
          alumn [this.indG].IngresarDatos();
          alumn [this.indG].IngresarAlumnos();
          this.indG++;
          return alumn[indG];
      }
    public Alumnos mostrarAlumnos(){
          this.indM=(indM=Integer.parseInt(JOptionPane.showInputDialog("Numero de alumno que desea mostrar")))-1;
          alumn[this.indM].MostrarAlumno();
          alumn[this.indM].Promedio();
          return alumn[indM];
      }
    
    public Profesores guardaProfesores(){
          prof [this.indG]= new Profesores();
          prof [this.indG].IngresarDatos();
          prof [this.indG].IngresarProfesor();
          this.indG++;
          return prof[indG];
      }
    
    public Profesores mostrarProfesores(){
          this.indM=(indM=Integer.parseInt(JOptionPane.showInputDialog("Numero de profesor que desea mostrar")))-1;
          //alumn[indM].MostrarDatos();
          prof[this.indM].MostrarProfesor();
          return prof[indM];
      }
    
    public void guardaAdmins(){
           admin [this.indG]= new Administrativos();
          
          admin [this.indG].IngresarDatos();
          admin [this.indG].IngresarAdministrativo();
         
          this.indG++;
      }
    public void mostrarAdmins(){
          this.indM=(indM=Integer.parseInt(JOptionPane.showInputDialog("Numero de alumno que desea mostrar")))-1;
          admin[this.indM].MostrarAdministrativo();
          }
    
    public void CrearCurso(){
        curso [this.indG][this.indM]= new Cursos();
       
            JOptionPane.showMessageDialog(null,"Ingrese profesor");
            curso [0][this.indM].prof[0].MostrarProfesor();
            
            do{
               JOptionPane.showMessageDialog(null,"ingrese alumno");
            curso [indG][this.indM].guardaAlumno();
            
                this.indM=indM+1;
                opcion=Integer.parseInt(JOptionPane.showInputDialog("Si desea ingresar otro alumno presione 0"));
            }while(opcion==0 || j<5);
            this.indG=indG+1;
       }
    
    
    public void MostrarCurso(){
        this.j=(Integer.parseInt(JOptionPane.showInputDialog("Ingrese curso que desea ver")))-1;
        curso[this.j][this.i].mostrarProfesores();
        for (i=0;i<curso.length;i++){
            curso[this.j][this.i].mostrarAlumnos();
        }
    }
    
}
