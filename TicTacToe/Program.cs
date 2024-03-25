using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    /** ************************************************************************
    * \brief Entry point of the application.
    * \details This main function of the application.
    * \author Thiago Sérvulo Guimarães - thiagoservulog@gmail.com
    * \date 25/03/2024
    * \version v1.1.0
    ***************************************************************************/
    static class Program
    {
        /** ************************************************************************
        * \brief Main entry point of the application.
        * \details This method initializes the application and runs the main form.
        ***************************************************************************/
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TicTacToe());
        }
    }
}
