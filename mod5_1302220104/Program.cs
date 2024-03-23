// See https://aka.ms/new-console-template for more information


using System.Numerics;

class Penjumlahan
{
   
    public static T JumlahTigaAngka <T> (T angka1,T angka2,T angka3) where T : IAdditionOperators<T,T,T> 
    {
        dynamic A = angka1;
        dynamic B = angka2;
        dynamic C = angka3;


        return A + B + C;

        

    }
}

class simpleDataBase<T>
{
    public List<T> storeData;
    public List<DateTime> inputDates;

    public void AddnewData(T data)
    { 
        this.storeData.Add(data);
        this.inputDates.Add(DateTime.Now);

    }
    public void printAllData()
    {
        for (int i = 0; i < this.storeData.Count; i++)
        {
            Console.WriteLine("Data" + i + "berisi" + this.storeData[1] + "yang disimpan pada waktu UTC:3/10/2022 5:32:01 AM");   
        }

    }


}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("masukan nim:");
        string nim = Console.ReadLine();

        Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13,02,22));


        simpleDataBase<double> Data = new simpleDataBase<double>();
        Data.printAllData();
    }
}

