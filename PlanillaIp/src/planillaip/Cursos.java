/*
 En esta clase se crearan
 */
package planillaip;


import javax.swing.JOptionPane;

/**
 *
 * @author Julian Palacios
 */
public class Cursos extends DatosIP {
   
    
    Profesores profe1 = new Profesores();
    Alumnos alumn3 = new Alumnos();
    Alumnos temp;
    
    DatosIP cursoP[][] = new DatosIP[1][4];
    DatosIP cursoA = new DatosIP();
    String car="";
    int c=0;
   
    
    
    public void CrearCursos (int o, Alumnos alumn4, Profesores profesor){
  //  cursoP [this.i]= new DatosIP();
  //  cursoA [this.i]= new DatosIP();
        
       // opcion=Integer.parseInt(JOptionPane.showInputDialog("Ingrese 1 para profesor . 2 para ingresar alumno"));
       // while(opcion==1 || opcion==2){
       //Arrays.fill(curso1, null);
        this.profe1=profesor;
        this.alumn3=alumn4;
       i=Integer.parseInt(JOptionPane.showInputDialog("Ingresar curso : 1)analista \n 2)psicologia \n 3)finanzas"));
                    switch(i){
                             case 1: this.car="Analista";break;
                             case 2: this.car="Psicologia";break;
                             case 3: this.car="finanzas";break;}
                   // for(i=0;i<cursoP.length;i++){
                   System.out.println("\n"+car+" "+alumn3.alumn[i].carrera);
                   cursoP[0][0]=profe1;
                        for(j=1,i=0;j<4;j++){
                            System.out.println("prueba");
                           if (car.equalsIgnoreCase(alumn3.alumn[(j-1)].carrera)){
                               
                           temp=alumn3.alumn[(j-1)];
                           cursoP[i][j]=temp;
                           //cursoP[i][j].mostrarAlumnos();
                            c++;
                               System.out.println(String.valueOf(cursoP[i][j])+"    "+c);
                          
                           } 
                           else{System.out.println("error");
                        }
                        }
                   // }
      
       
        switch(o){
            case 1:
                
                    break;
            case 2:
                    
                    //cursoP[0][1]=alumn3;
                   cursoP[0][0].mostrarProfesores();
                   for(j=1;j<4;j++){
                   cursoP[0][j].mostrarAlumnos();System.out.println(" x ");}
                    break;
       // }
        }
    }
                        
                        
    public void mostrarCursos(){
        
        this.i=(Integer.parseInt(JOptionPane.showInputDialog("Ingrese curso que desea ver: ")));
            cursoP[0][0].mostrarProfesores();
            for (this.j=1;j<cursoP.length;j++){
            cursoP[0][j].mostrarAlumnos();
        }
    }
    
    
}
