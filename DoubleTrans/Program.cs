using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleTrans
{
    public class BaseTrans
    {
        public Dictionary<char, int> alphabet = new Dictionary<char, int>
        {
                    { 'А', 1 },
                    { 'Б', 2 },
                    { 'В', 3 },
                    { 'Г', 4 },
                    { 'Д', 5 },
                    { 'Е', 6 },
                    { 'Ё', 7 },
                    { 'Ж', 8 },
                    { 'З', 9 },
                    { 'И', 10 },
                    { 'Й', 11 },
                    { 'К', 12 },
                    { 'Л', 13 },
                    { 'М', 14 },
                    { 'Н', 15 },
                    { 'О', 16 },
                    { 'П', 17 },
                    { 'Р', 18 },
                    { 'С', 19 },
                    { 'Т', 20 },
                    { 'У', 21 },
                    { 'Ф', 22 },
                    { 'Х', 23 },
                    { 'Ц', 24 },
                    { 'Ч', 25 },
                    { 'Ш', 26 },
                    { 'Щ', 27 },
                    { 'Ъ', 28 },
                    { 'Ы', 29 },
                    { 'Ь', 30 },
                    { 'Э', 31 },
                    { 'Ю', 32 },
                    { 'Я', 33 }
        };


        /// Метод StringToArrayNumberPos(string _stringchar) преобразует 
        /// строку в массив позиций ее литералов в алфавите

        public int[] StringToArrayNumberPos(string _stringchar)
        {

            int[] resarray = new int[_stringchar.Length];
            uint count = 0;
            try
            {
                foreach (char literal in _stringchar.ToUpperInvariant())
                    resarray[count++] = alphabet[literal];
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return resarray;
        }


        /// Метод CheckRepeat(string _checkedstr) проверяет строку на повторы элементов

        public bool CheckRepeat(string _checkedstr)
        {
            uint count = 0;
            foreach (char later in _checkedstr)
            {
                count = (uint)_checkedstr.Where(x => x == later).Count();
                if (count > 1) return true;
            }

            return false;
        }
    }
    class DoubleTrans : BaseTrans
    {
        private int[] cryptKeyOne; // Первый ключ(столбцы)
        private int[] cryptKeyTwo; // Второй ключ(строки)
        string originalStr; // исходнная срока

        public DoubleTrans(string _originalstr, string _kriptkeyone, string _kriptkeytwo)
        {
            try
            {

                if (_kriptkeyone.Length != _kriptkeytwo.Length) throw new Exception("Keys is not equal");

                if (_kriptkeyone.Length * _kriptkeytwo.Length < _originalstr.Length) throw new Exception("String is biggger than table size");

                if (CheckRepeat(_kriptkeyone) | CheckRepeat(_kriptkeytwo)) throw new Exception("The key contains duplicates");

                /***********
                преобразуем ключи-сторки в массив порядковых 
                номеров литералов в алфавите
                ***********/
                cryptKeyOne = StringToArrayNumberPos(_kriptkeyone);
                cryptKeyTwo = StringToArrayNumberPos(_kriptkeytwo);

            }
            catch (Exception ex) { throw ex; }


            originalStr = _originalstr;
        }

        public string EncryptDecrypt()
        {

            /**********
            сортируем численые ключи-массивы по возрастанию
            **********/
            int[] assortKeyOne = cryptKeyOne.OrderBy(x => x).ToArray();
            int[] assortKeyTwo = cryptKeyTwo.OrderBy(x => x).ToArray();


            char[,] encryptStr = new char[assortKeyOne.Length, assortKeyTwo.Length]; // зашифрованная строка
            char[,] originalStrArray = new char[assortKeyOne.Length, assortKeyTwo.Length]; // массив элементов шифруемой строки(шифруемая строка)

            // преобразуем шифруемую строку в массив
            int count = 0;
            for (int i = 0; i < assortKeyOne.Length; i++)
                for (int j = 0; j < assortKeyTwo.Length; j++)
                {

                    originalStrArray[i, j] = originalStr.ToString().Length <= count ? '*' : originalStr[count];
                    count++;
                }

            // шифрование
            for (int i = 0; i < assortKeyOne.Length; i++)
                for (int j = 0; j < assortKeyTwo.Length; j++)
                {
                    /***********************
                     берем номер нужной нам строки/столбца и ищем его индекс в несортированном ключе
                     полученые индексы строки и стобца будут позицией элмента 
                     необходимого для записи в зашифрованную строку
                    ***********************/
                    int rownumber = Array.IndexOf(cryptKeyTwo, assortKeyTwo[i]);
                    int columnumber = Array.IndexOf(cryptKeyOne, assortKeyOne[j]);

                    encryptStr[i, j] = originalStrArray[rownumber, columnumber]; //
                }

            StringBuilder rezultStr = new StringBuilder(assortKeyOne.Length * assortKeyTwo.Length);
            for (int i = 0; i < assortKeyOne.Length; i++)
                for (int j = 0; j < assortKeyTwo.Length; j++)
                {

                    rezultStr.Append(encryptStr[i, j]);
                }
            Console.WriteLine(rezultStr);
            return rezultStr.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DoubleTrans doubletr = new DoubleTrans("Там немає бомби", "ВБГА", "БАВГ");//4213 = ВБГА(3241)
            doubletr.EncryptDecrypt();
            Console.ReadKey();

        }
    }
}
