using System;
using System.Collections.Generic;
public class KodePos
{
    private static Dictionary<string, string> tabel = new Dictionary<string, string>
    {
        {"Batununggal", "40266" },{"Kujangsari", "40287"}, {"Mengger", "40267"}, {"Wates", "40256"}, {"Cijaura", "40287"}, 
        {"Jatisari", "40286"}, {"Margasari", "40286"}, {"Sekejati", "40286"}, {"Kebonwaru","40272"},{"Maleer","40274"}
    };

    public static string getKodePos(string kelurahan)
    {
        if (tabel.ContainsKey(kelurahan))
        {
            return tabel[kelurahan];
        }
        else
        {
            return "Data tidak ditemukan";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input Kelurahan : ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine($"Kelurahan : {kelurahan}, Kode Pos : {KodePos.getKodePos(kelurahan)}");
    }
}
