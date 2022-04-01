// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
    
namespace tpmodul6_kelompok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DataMahasiswa1302204035 data = new DataMahasiswa1302204035();
            data.ReadJSON();
        }
    }
} 