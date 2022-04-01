using Newtonsoft.Json;

namespace tpmodul6_kelompok_5;

public class KuliahMahasiswa_1302204035
{
    public void ReadJSON()
    {
        //read json file
        string jsonFile = File.ReadAllText(@"D:\Telyuuu\.Semester 4\Github\KPL\tpmodul6_kelompok_5\tp6_2_1302204035.json");
        //convert json to array
        dynamic data = JsonConvert.DeserializeObject(jsonFile);
        //print data
        int i = 1;
        Console.WriteLine("Daftar mata kuliah yang diambil:");
        foreach (var item in data)
        {
            Console.WriteLine("MK {0} {1}", i, item.kode_matkul + "-" + item.nama_matkul);
            i++;
        }
    }
}