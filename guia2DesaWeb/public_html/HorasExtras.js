/* 
 * Punto4.js
 * desarrollo punto cuatro de la guia dos
 */


//declaracion de variables
var sueldo;
var horaEx;
var valorHora;
var a;
//se ingresa el valor del sueldo
sueldo = parseFloat(prompt("Ingrese sueldo: "));
//se identifica si el sueldo ingresado es mensual o semanal
a = parseInt(prompt("Digite 1 si el sueldo ingresado es mensual o 2 si es semanal"));
// se filtra por si se ha ingresado una opcion erronea
    if(a===1 || a===2)
    {
        //si el sueldo es mensual realiza la operacion aqui
        if (a===1)
          {
              valorHora = (sueldo/4)/45;
              horaEx = (valorHora * 0.5)+ valorHora;
              alert("El valor de la hora extra es: " + horaEx);
              document.write("El valor de la hora extra es: " + horaEx);
          }
        //si el sueldo es semanal ingresa aca  
        if (a===2)
          {
           valorHora = sueldo / 45;
           horaEx = (valorHora * 0.5)+valorHora;
           alert("El valor de la hora extra es: " + horaEx);
           document.write("El valor de la hora extra es: " + horaEx);
          }
     }
     // si la opcion ingresada es diferente a 1 o 2 ingresa aca
     else
         alert("La opcion ingresada no corresponde");
     

