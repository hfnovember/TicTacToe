using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTTNicos
{

    class Player {
        private string symbol;
        private int wins = 0;
        public void setSymbol(string c) { symbol = c; }
        public string getSymbol() { return symbol; }
        public void increaseWins() { wins++; }
    }

    static class Program {
        public const int gameSize = 9;
        public static Player human = new Player();
        public static Player computer = new Player();
        public static string[] gameArray = new string[gameSize];
        public static bool isHard = false;
        public static int roundNumber = 1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }//end Main()

        public static void InitializeArray(string[] gameArray) {
            for (int i = 0; i < gameSize; i++) gameArray[i] = " ";
        }//end InitializeArray()

    }

}
