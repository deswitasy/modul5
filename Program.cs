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

class Program
{
    static void Main(String[] args)
    {
        PemrosesData data = new PemrosesData();
        double x = data.DapatkanNilaiTerbesar(10, 30, 22);
        Console.WriteLine(x);
    }
}