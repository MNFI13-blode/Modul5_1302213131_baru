internal class Program
{
    public class penjumlahan
    {
        public static void Main(string[] args)
        {
            penjumlahan.JumlahTigaAngka<float>(13, 45, 67);
        }
        static void JumlahTigaAngka<T>(T nomor, T nomor2, T nomor3)
        {
            Console.WriteLine((dynamic)nomor+(dynamic)nomor2+(dynamic)nomor3);
        }
    }
}