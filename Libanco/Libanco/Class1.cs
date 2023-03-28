using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libanco
{
    public class Class1
    {
        public static String use(String a)
        {
            if (a.Length < 6)
            {
                return "Este campo deve tener almenos 6 caracteres";
            }
            else
            {
                return "";
            }
            
        }
        public static String pasw(String a)
        {
            if (a.Length < 6)
            {
                return "Este campo deve tener almenos 6 caracteres";
            }
            else
            {
                return "";
            }
        }
        public static String nom(String a)
        {
            if (a.Length <3)
            {
                return "Este campo deve tener almenos 3 caracteres";
            }
            else
            {
                return "";
            }
        }
        public static String apellidos(String a)
        {
            if (a.Length < 6)
            {
                return "Este campo deve tener almenos 6 caracteres";
            }
            else
            {
                return "";
            }
        }
        public static String email(String a)
        {
            if (a.Length < 6)
            {
                return "verifica los datos";
            }
            else
            {
                return "";
            }
        }
        public static String cuenta(String a)
        {
            if (a.Length < 20)
            {
                return "Este campo deve tener  20 caracteres";
            }
            else
            {
                return "";
            }
        }
    }
}
