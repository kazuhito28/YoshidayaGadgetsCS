using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoshidayaGadgetsCS
{

    internal static class Program
    {

        public static formGadgets formGadgetsInstance;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formGadgets());

            formGadgetsInstance = new formGadgets();
            Application.Run(formGadgetsInstance);

        }
    }
}
