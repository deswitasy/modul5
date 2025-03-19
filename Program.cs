// See https://aka.ms/new-console-template for more information
class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T input, T input2, T input3)
    {
        dynamic temp1 = (dynamic) input;
        dynamic temp2 = (dynamic)input2;
        dynamic temp3 = (dynamic)input3;

        dynamic? Largest = temp1;
        if (Largest <= temp2)
        {
            Largest = temp2;
        } else if (Largest < temp3)
        {
            Largest = temp3;
        }
        return Largest;
    }
}


class SimpleDataBase <T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData<T>(T data) {
        dynamic? temp1 = data;
        storedData.Add(temp1);
        inputDates.Add(DateTime.Now);    
    }

    public void PrintAllData()
    {
        for(int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + ( i + 1 ) + "berisi " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
    
}
class Program
{
    static void Main(String[] args)
    {
        PemrosesData data = new PemrosesData();
        double x = data.DapatkanNilaiTerbesar(10, 30, 22);
        Console.WriteLine(x);
  

        SimpleDataBase<int> Data = new SimpleDataBase<int>();
        Data.AddNewData(10);
        Data.AddNewData(30);
        Data.AddNewData(22);

        Data.PrintAllData();
    }
}
