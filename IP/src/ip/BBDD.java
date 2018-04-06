package ip;


import java.util.Scanner;

public class BBDD {
    Scanner teclado = new Scanner(System.in);
    Alumno[] BDAl= new Alumno[100];
    Docente[] BDDo= new Docente[100];
    Administrativo[] BDAd= new Administrativo[100];
    Curso[] BDCur =new Curso[100];
    int conAl = 0;
    int conDo = 0;
    int conAd = 0;
    int conCur = 0;
    
    public void GuardaAlumno(){
        BDAl[conAl] = new Alumno();
        System.out.print("Ingrese Nombre: ");
        BDAl[conAl].setNombre(teclado.next());
        System.out.print("Ingrese Sexo: ");
        BDAl[conAl].setSexo(teclado.next());
        System.out.print("Ingrese Rut ej: 16187256 sin digito verificador : ");
        BDAl[conAl].setRun(teclado.next());
        System.out.print("Ingrese el año de nacimiento con el siguiente formato 1986 : ");
        BDAl[conAl].setAno_nac(teclado.nextInt());
        System.out.print("Ingrese Matricula: ");
        BDAl[conAl].setMatricula(teclado.nextInt());
        teclado.nextLine();
        conAl++;
    }
    
        public void GuardarCurso(){
            
        BDDo[conDo] = new Docente();
        BDCur[conCur] = new Curso();
        BDAl[conAl] = new Alumno();
         
        Scanner tecla = new Scanner(System.in);
       
        
        System.out.print("Ingrese Carrera: ");
        BDCur[conCur].setCarrera(tecla.next());
        
        System.out.print("Ingrese Seccion(solo numeros) :");
        BDCur[conCur].setSeccion(tecla.nextInt());
         //teclado.nextLine();
        System.out.print("\n:");
        
        System.out.print("Ingrese Nombre Docente: ");
        BDDo[conDo].setNombre(tecla.next());
        System.out.print("Ingrese Sexo Docente: ");
        BDDo[conDo].setSexo(tecla.next());
        System.out.print("Ingrese Profesion Docente: ");
        BDDo[conDo].setProfesion(tecla.next());
        //teclado.nextLine();
       
        
       
        System.out.print("Ingrese Nombre Alumno: ");
        BDAl[conAl].setNombre(tecla.next());
        System.out.print("Ingrese Sexo Alumno: ");
        BDAl[conAl].setSexo(tecla.next());
        System.out.print("Ingrese Rut  Alumno ej: 16187256 sin digito verificador : ");
        BDAl[conAl].setRun(tecla.next());
        System.out.print("Ingrese el año de nacimiento Alumno con el siguiente formato 1986 : ");
        BDAl[conAl].setAno_nac(tecla.nextInt());
        System.out.print("Ingrese Matricula Alumno : ");
        BDAl[conAl].setMatricula(tecla.nextInt());
       // teclado.nextLine();
        conAl++;
        conCur++;
        conDo++;
        
    }
    
    public void GuardaDocente(){
        BDDo[conDo] = new Docente();
        System.out.print("Ingrese Nombre: ");
        BDDo[conDo].setNombre(teclado.nextLine());
        System.out.print("Ingrese Sexo: ");
        BDDo[conDo].setSexo(teclado.nextLine());
        System.out.print("Ingrese Profesion: ");
        BDDo[conDo].setProfesion(teclado.nextLine());
        teclado.nextLine();
        conDo++;
    }
    
    public void GuardaAdministrativo(){
        BDAd[conAd] = new Administrativo();
        System.out.print("Ingrese Nombre: ");
        BDAd[conAd].setNombre(teclado.nextLine());
        System.out.print("Ingrese Sexo: ");
        BDAd[conAd].setSexo(teclado.nextLine());
        System.out.print("Ingrese Cargo: ");
        BDAd[conAd].setCargo(teclado.nextLine());
        teclado.nextLine();
        conAd++;
    }
    
    public String retornaDv(String run){
        
        int rut = Integer.parseInt(run);
        
        int digito, suma, resto, resultado, factor;
        
        for (factor = 2, suma = 0; rut > 0; factor++) {
            digito = rut % 10;
            rut /= 10;
            suma += digito * factor;

            if (factor >= 7) {
                factor = 1; 
            }
        }


        resto = suma % 11;
        resultado = 11 - resto;
        
        if (resultado < 10) {
     
            String res = String.valueOf(resultado);
            return res;
            
        } else if (resultado == 10) {
         
            return "K";
        } else {
             return "0";
        }

        
    }
    
    public void Listar(){
        
       
        if(conAl != 0 ){

            System.out.println("Alumnos:");

           
          
            for(int i=0;i<conAl;i++ ){//daba error porque el largo esta definido de 100 cuando pasa al segundo caga porque esta nulo
           
                System.out.println("'\tNombre:"+BDAl[i].getNombre());
                 String var =     this.retornaDv(BDAl[i].getRun());
                System.out.println("'\t\tRut:"+BDAl[i].getRun()+" dv calculado="+var);
                System.out.println("'\t\tSexo:"+BDAl[i].getSexo());
               int ano =2017;
               int ano_nac = BDAl[i].getAno_nac();
               int edad =2017 -ano_nac;
               System.out.println("'\t\tEdad:" +edad);
               System.out.println("'\t\tMatricula:"+BDAl[i].getMatricula());
                
            }
          }
        
  
}
    
        public void ListarCurso(){
        
       
        if(conCur != 0 ){
            System.out.println("Curso:");
            for(int i=0;i<conCur;i++ ){     
                System.out.println("'\t Carrera:"+BDCur[i].getCarrera());
                System.out.println("'\t\tSeccion:"+BDCur[i].getSeccion());
                
            }
          }

         
           if(conDo != 0){
            System.out.println("Docentes:");
            for(int i=0;i<conDo;i++ ){
                System.out.println("'\t Nombre:"+BDDo[i].getNombre());
                System.out.println("'\t\t Sexo:"+BDDo[i].getSexo());
                System.out.println("'\t\t Profesion:"+BDDo[i].getProfesion());
            }
        }
       if(conAl != 0 ){

            System.out.println("Alumnos:");
    
            for(int i=0;i<conAl;i++ ){
           
                System.out.println("'\tNombre:"+BDAl[i].getNombre());
                System.out.println("'\t\tSexo:"+BDAl[i].getSexo());
                 String var =     this.retornaDv(BDAl[i].getRun());
                System.out.println("'\t\tRut:"+BDAl[i].getRun()+" dv calculado="+var);
                int ano =2017;
                int ano_nac = BDAl[i].getAno_nac();
                int edad =2017 -ano_nac;
                System.out.println("'\t\tEdad:" +edad);
                System.out.println("'\t\tMatricula:"+BDAl[i].getMatricula());
                
            }
          }
         
        }
    
}
