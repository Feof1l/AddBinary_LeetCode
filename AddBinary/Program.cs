using System.Security.Cryptography;

internal class Program

{
    public static void AddResult (ref string result,ref char Bit, bool curr)
    {
        if (!curr)
        {
            result = Bit + result;
            Bit = '0';
        }
        else
        {
            if (Bit == '1')
                result = '0' + result;
            else
            {
                result = '1' + result;
                Bit = '0';
            }

        }
    } 
    public static string BinSum(string a, string b)
    {
        string result = "";
        string t;
        char Bit = '0';
        if (b.Length > a.Length)
        {
            t = a;
            a = b;
            b = t;
        }
        for (int i = a.Length - 1; i >= 0; i--)
        {
            int ind =  i - (a.Length - b.Length);
            if (ind < 0)
            {
                AddResult(ref result, ref Bit, !(a[i] == '0'));
            }
            else
            {
                AddResult(ref result, ref Bit, !(a[i] == b[ind]));
                if (a[i] == '1' && b[ind] == '1')
                    Bit = '1';
            }
         };
       if (Bit == '1')
        {
            result = '1' + result;
        }
        return result;
    }
    private static void Main(string[] args)
    {
        char povtor;
        do
        {
            Console.WriteLine("Введите 2 числа для сложения в 2 системе счисления");
            Console.WriteLine("Введите первое число");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            string b = Convert.ToString(Console.ReadLine());
            string otvet = BinSum(a, b);
            Console.WriteLine(a + '+' + b + '=' + otvet);
            Console.WriteLine("Результат: " + otvet);
            Console.WriteLine("Если хотите повотрить выполнение программы,введите y, иначе n");
             povtor = Convert.ToChar(Console.ReadLine());
        }
        while (povtor == 'y');
    }
}