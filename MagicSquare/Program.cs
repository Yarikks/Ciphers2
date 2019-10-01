using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquare
{
    public class MagicSquare
    { 
    public int[,] defaultSquare = new int[4, 4] { { 16, 3, 2, 13 }, { 5, 10, 11, 8 }, { 9, 6, 7, 12 }, { 4, 15, 14, 1 } };

    public char[,] EncryptionMagicSquare(string text)
    {
        int index = 0;
        char[,] encryptedText = new char[4, 4] { { '*', '*', '*', '*' }, { '*', '*', '*', '*' }, { '*', '*', '*', '*' }, { '*', '*', '*', '*' } };
        while (index != text.Length)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((defaultSquare[i, j] == index + 1) && (index != text.Length))
                    {
                        encryptedText[i, j] = text[index];
                        index++;
                    }
                }
            }

        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(String.Format("{0,1}", encryptedText[i, j]));
                //Console.WriteLine();
            }
        }
        return encryptedText;
    }

}
class Program
{
    static void Main(string[] args)
    {
        MagicSquare mg = new MagicSquare();
        mg.EncryptionMagicSquare("Не йди туди");
        Console.ReadKey();
    }
}
}
