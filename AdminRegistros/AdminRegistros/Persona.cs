using System;

namespace AdminRegistros
{

    public class Persona

    {
        String nombre, apellido, rut, domicilio;
        int edad,DV; int[] rutInt;

        public Persona()
        {
            String nombre="", apellido="", rut="", domicilio="";
            int edad;
            int[] rutInt;
        }
        public void setNombre(String nombre1)
        {
            this.nombre = nombre1;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setRut(String rut)
        {
            //Declaracion de variables y,i son contadores rutProvStr es un string rpovisional y un array int para el rut final.
            int y = 0;

            String rutProvStr = "";
            this.rut = rut;
            for (int i = 0; i < rut.Length-1; i++)
            {
                if (rut[i] != '.' || rut[i] != '-')
                {
                    rutProvStr=Convert.ToString(rut[i]);
                    y++;
                }
            }
            rutInt = new int[y + 1];
            for (int i = 0; i < rutProvStr.Length; i++)
            {
                rutInt[i] = Convert.ToInt32(Convert.ToString(rutProvStr[i]));
            }
            int x = 2,suma=0;
            for (int i = rutInt.Length - 1; i <= 0; i--)
            {
                if (x > 7)
                {
                    x = 2;
                }
                suma += (rutInt[i] * x);
                x++;
            }
            DV = suma % 11;
            DV=DV-11;
        }
        public void setEdad(String edad)
        {
            this.edad = Convert.ToInt32(edad);
        }
        public void setDomicilio(String domicilio)
        {
            this.domicilio = domicilio;
        }
        public String getNombre()
        {
            return nombre;
        }
        public String getApellido()
        {
            return apellido;
        }
        public String getDomicilio()
        {
            return domicilio;
        }
        public int getEdad()
        {
            return edad;
        }
        public int  getRut()
        {
            return DV;
        }


    }
}