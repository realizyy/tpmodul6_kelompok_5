// See https://aka.ms/new-console-template for more information

namespace tpmodul6_kelompok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DataMahasiswa1302204035 datamhs = new DataMahasiswa1302204035();
            datamhs.ReadJSON();
            KuliahMahasiswa_1302204035 datamk = new KuliahMahasiswa_1302204035();
            datamk.ReadJSON();
        }
    }
} 