using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe025__Abstract_Class_
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo. - fica sempre executando = classe static | nao precisa ser instanciada porque esta sempre ativa
        /// o statusMenu é para ver quantas vezes para abrir o menu foi clicado 
        /// essa variavel é vista por todos os formularios -> variavel global 
        /// </summary>
        public static string statusMenu;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());
        }
    }
}
