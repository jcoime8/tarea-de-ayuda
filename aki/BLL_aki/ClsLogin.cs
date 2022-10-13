using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_aki
{
    public class ClsLogin
    {
        public string usr = "jcoime";
        public string pwd = "profepongame10";
        public bool nuevo(string usuario, string contraseña)
        {
            bool resultado = false;
            if (usuario == usr && contraseña == pwd)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
