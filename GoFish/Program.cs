using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            // SerializeCard();
        }

        private static void SerializeCard()
        {
            Card three_c = new Card(Suits.Clubs, Values.Three);
            using (Stream output = File.Create("three_c.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, three_c);
            }

            Card six_h = new Card(Suits.Hearts, Values.Six);
            using (Stream output = File.Create("six_h.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, six_h);
            }
        }
    }
}
    