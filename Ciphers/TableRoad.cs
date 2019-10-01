using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciphers
{
    class TableRoad
    {
        public T[,] HorisontalFill<T>(T[] arr, int height)
        {
            T[,] buff = new T[arr.Length / 5, 5];

            int i = 0;
            for (int y = 0; y < buff.GetLength(1); y++)
                for (int x = 0; x < buff.GetLength(0); x++)
                    buff[x, y] = arr[i++];

            return buff;
        }

        public  T[] VerticalRead<T>(T[,] buff)
        {
            T[] arr = new T[buff.Length];

            int i = 0;
            for (int x = 0; x < buff.GetLength(0); x++)
                for (int y = 0; y < buff.GetLength(1); y++)
                    arr[i++] = buff[x, y];

            return arr;
        }

        public string Encrypt(string word, object key)
        {
            int i = 0;
            while (word.Length % 5 != 0) {
                word += word[i];
                i++;
            }

            char[,] table = HorisontalFill(word.ToCharArray(), 5);

            return new string(VerticalRead(table));
        }
    }
}
