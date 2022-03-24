using System;

namespace HadiTaxi
{
  public class taxi
  {
    public string nama {get;set;}
    public bool duty {get;set;}
    public int penumpang {get;set;}

    public void taxiinfo()
    {
      Console.WriteLine("Driver Name : {0}", nama);
      if (duty == true)
      {
        Console.WriteLine("On Duty : Yes");
      }
      Console.WriteLine("Number of Passenger : {0}", penumpang);
      Console.WriteLine();
    }

    public void jemput()
    {
      Console.WriteLine("{0} sedang menjemput penumpang", nama);
    }

    public void antar()
    {
      Console.WriteLine("{0} selesai mengantar penumpang", nama);
    }
  }
  class program
  {
    static void Main(string[] args)
    {
      taxi mobil = new taxi();

      Console.WriteLine();

      mobil.nama = "Jono";
      mobil.duty = true;
      mobil.penumpang = 10;

      mobil.taxiinfo();
      mobil.jemput();
      mobil.antar();

      Console.ReadKey();
    }
  }
}
