using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Form[] array = new Form[5];
            //array[0] = new ClientManager();
            //array[1] = new ProviderManager();
            //array[2] = new Bookmaker();

            //int k = 3;
            //for (int i = 0; i < k; i++)
            //{
            //    Application.Run(array[i]);
            //}

            Application.Run(new ClientManager());
            Application.Run(new ProviderManager());
            Application.Run(new Bookmaker());
            Application.Run(new StoreKeeper());
            Application.Run(new Courier());


        }
    }
}
