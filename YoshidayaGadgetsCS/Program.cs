using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoshidayaGadgetsCS
{

    internal static class Program
    {

        public static formGadgets formGadgetsInstance = null;
        public static FormCustom formCustomInstance = null;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formGadgets());

            new formGadgets();
            Application.Run();

        }
    }
}
