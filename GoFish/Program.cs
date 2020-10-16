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
            SerializeCard();
        }

        private static void SerializeCard()
        {
            Card three_c = new Card(Suits.Clubs, Values.Three);
            using (Stream output = File.Create("three-c.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, three_c);
            }

            Card six_h = new Card(Suits.Hearts, Values.Six);
            using (Stream output = File.Create("six-h.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, six_h);
            }

            byte[] firstFile = File.ReadAllBytes("three-c.dat");
            byte[] secondFile = File.ReadAllBytes("six-h.dat");
            for (int i = 0; i < firstFile.Length; i++)
                if (firstFile[i] != secondFile[i])
                    System.Diagnostics.Debug.WriteLine("Byte #{0}: {1} versus {2}", i, firstFile[i], secondFile[i]);


            firstFile[227] = (byte)Suits.Spades;        // returns Byte #227: 1 versus 3 - replace it with Spades
            firstFile[268] = (byte)Values.King;         // returns Byte #268: 3 versus 6 - replace it with King
            File.Delete("king-s.dat");
            File.WriteAllBytes("king-s.dat", firstFile);
            using (Stream input = File.OpenRead("king-s.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Card card = (Card)bf.Deserialize(input);
                MessageBox.Show(card.Name);
            }
        }
    }
}
    