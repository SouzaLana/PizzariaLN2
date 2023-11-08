using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaLN2
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Na program.cs ela chama o form1.cs e tem que mudar isso para Login, ou seja, quando iniciar vai aparecer a tela de login.
            Application.Run(new Login());
            //Criar outro método para o UsuarioDAO
            //if(dr.HasRows)
            //   return true;
        }
    }
}
