using Newtonsoft.Json;

namespace tpmodul6_kelompok_5;

public class DataMahasiswa1302204035
{
    public void ReadJSON()
    {
        //read json file
        string jsonFile = File.ReadAllText(@"D:\Telyuuu\.Semester 4\Github\KPL\tpmodul6_kelompok_5\tp6_1_1302204035.json");
        //convert json to array
        dynamic data = JsonConvert.DeserializeObject(jsonFile);
        //print data
        Console.WriteLine("Nama "+data[0]["nama_depan"]+" "+data[0]["nama_belakang"]+" dengan NIM "+data[0]["nim"]+" dari fakultas "+data[0]["fakultas"]);
    }
}