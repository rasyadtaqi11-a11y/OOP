


// using System;

public class HelloWorld

{
    String halo = "halo";



    //variabel global
        int angkaSatu;

        int angkaDua;

    public void fungsiDalamKelas()
    {
        string haloJuga = "haloooo";
        Console.WriteLine(haloJuga);
    }   

    
    public void operasiTambah(int angkaSatuPar, int angkaDuaPar)
    {

        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine(angkaSatuPar + angkaDuaPar);

    }


     public void operasiKurang(int angkaSatuPar, int angkaDuaPar)
    {

        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine(angkaSatuPar - angkaDuaPar);

    }


     public void operasiBagi(int angkaSatuPar, int angkaDuaPar)
    {

        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine(angkaSatuPar / angkaDuaPar);

    }
     


      public void operasiKali(int angkaSatuPar, int angkaDuaPar)
    {

        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine(angkaSatuPar * angkaDuaPar);

    }


    public static void Main()
    {
        Console.WriteLine("Merdeka");
        HelloWorld inisiasiHello = new HelloWorld();

        Console.WriteLine(inisiasiHello.halo);

        inisiasiHello.fungsiDalamKelas();

        inisiasiHello.operasiTambah(2,1);
        inisiasiHello.operasiKurang(5,3);
        inisiasiHello.operasiBagi(7,6);
        inisiasiHello.operasiKali(10,16);


    }



}

