
package hourglasses;

import java.util.Scanner;
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;




public class HourGlasses {

    
    public static void main(String[] args) {
        int limx = 4,limy = 4, sumTotal=-63,sumArray=0;
        Scanner in = new Scanner(System.in);
        /*int arr[][] = new int[6][6];
        for(int i=0; i < 6; i++){
            for(int j=0; j < 6; j++){
                arr[i][j] = in.nextInt();
            }
        }*/
        int arr [][] ={{0,-4,-6,0,-7,-6},{-1,-2,-6,-8,-3,-1},{-8,-4,-2,-8,-8,-6},{-3,-1,-2,-5,-7,-4},{-3,-5,-3,-6,-6,-6},{-3,-6,0,-8,-6,-7}};
     
        for (int x = 0; x< limx && limx<8;x++)
        {
            for (int y = 0; y< limy ;y++)
            {
                sumArray = arr[x][y]+arr[x][y+1]+arr[x][y+2];
                sumArray += arr[x+1][y+1];
                sumArray += arr[x+2][y]+arr[x+2][y+1]+arr[x+2][y+2];
                
                 if (sumArray > sumTotal )
                {
                    sumTotal = sumArray;
                }
            }
               limx++;
        }
        System.out.println(sumTotal);
       
        
        
    }
}


  
            /*if(limx < 7 && limy < 7){
                limx++;
                limy++;
            }
            else{
                limx=x;
                limy=y;
            }*/
            /*limy++;
            y++;*/