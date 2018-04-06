/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package inheritance;


public class Student extends Person {
    
    private int[] testScores;
    
    public Student (String firstName, String lastName, int identification, int [] scores){
        super(firstName,  lastName,  identification);
        testScores = scores;
    }
    
     public char calculate (){
        int result = 0,prom;
        for(int i=0;i<testScores.length;i++){
            result += testScores[i];
        }
        prom = result/testScores.length;
        
        if (prom>=90 && prom<=100){
            return 'O';
        }
        else
        {
             if (prom>=80 && prom<90){
             return 'E';
        }
             else{
                 if (prom>=70 && prom<90){
                 return 'A';
        }
                 else{
                      if (prom>=55 && prom<70){
                      return 'P';
        }
                      else{
                           if (prom>=40 && prom<55){
                           return 'D';
        }
                           else{
                                
                                return 'T';
        }
                           
            
        }
            
        }
            
        }
            
        }   
            
        }
    
     }
    

