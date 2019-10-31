using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Alumno
    {
        #region PROPIEDADES
        private String nombre;
        private String apellido;
        private int nota;
        private String materias;
        #endregion

        #region METODOS

        //Metodos get set para las propiedades

        public String Materias
        {
            get
            {
                return materias;
            }
            set
            {
                materias = value;
            }
        }
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public String Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public int Nota
        {
            get
            {
                return nota;
            }
            set
            {
                nota = value;
            }
        }

        //Metodo para verificar que solo contenga letras
        //retorna true si encuetra caracteres que no sean letras y false sino encuentra

        public Boolean SoloLetras(String text)
        {
            Boolean nohayletras = false;
            string[] arreglo = text.ToUpper().Trim().Split();
            foreach (String aux in arreglo)
            {
                for (int i = 0; i < aux.Length; i++)
                {                    
                    if (!Char.IsLetter(aux,i))
                    {
                        nohayletras = true;
                        return nohayletras;
                    }
                }

            }
            return nohayletras;
        }
        #endregion
    }
}
