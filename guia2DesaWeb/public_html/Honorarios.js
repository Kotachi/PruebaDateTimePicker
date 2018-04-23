/*
 * Punto3.js
 * desarrolo del punto tres de la guia numero dos
 */

// Declaracion de variables
var honorarios;
var a;
var valorBruto;
var valorLiquido;
var retencion;
// se ingresa los honorarios
honorarios = parseFloat(prompt("Ingrese valor de honorarios"));
// se define si el valor ingresado es liquido o bruto
a = parseInt(prompt ("Ingrese 1 si honorarios son liquidos o ingrese 2 si el valor es bruto"));


if (a===1 || a===2)
{
    // se realiza la operacion para el sueldo liquido
    if ( a === 1 )
    { retencion = honorarios * 0.1;
      valorBruto = honorarios + retencion;
      
      alert("el valor bruto es: " + valorBruto + " el valor liquido es: " + honorarios + " la retencion es: " + retencion);
      document.write("el valor bruto es: " + valorBruto + " el valor liquido es: " + honorarios + " la retencion es: " + retencion);
    }
    //se realiza la operacion para el sueldo bruto
    if (a === 2)
       {retencion = honorarios * 0.1;
        valorLiquido = honorarios - retencion;
        alert("el valor bruto es : " + honorarios + " el valor liquido es: " + valorLiquido + " la retencion es. " + retencion);
        document.write("el valor bruto es : " + honorarios + " el valor liquido es: " + valorLiquido + " la retencion es. " + retencion);
       }    
}
// si la opcion de sueldo bruto o liquido no corresponde
else
alert("Ingreso un opcion incorrecta");



