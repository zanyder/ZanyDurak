/* Group1
 Authors: Alyxander Byfield, Bernie Warren, Eric Thompson, Jung Hwa Hyun
 Creation Date: 2024/03/04
 Revision Date: 2024/03/20
 Description: DurakClientMain, main entry point for the application 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DurakLibrary;

namespace DurakClient
{
    class DurakClientMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
        }
    }
}
