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

public class DoorMachine
{
    enum State { Terkunci, Terbuka };
    public void Run()
    {
        State state = State.Terkunci;
        Console.WriteLine("Pintu Terkunci");
        bool programRunning = true;
        while (programRunning)
        {
            Console.Write("Input Perintah : (buka / kunci / exit) : ");
            string command = Console.ReadLine();
            if (command == "exit")
            {
                break;
            }
            switch (state)
            {
                case State.Terkunci:
                    if (command == "buka")
                    {
                        state = State.Terbuka;
                        Console.WriteLine("Pintu tidak dikunci");
                    }
                    else
                    {
                        state = State.Terkunci;
                    }
                    break;

                case State.Terbuka:
                    if (command == "kunci")
                    {
                        state = State.Terbuka;
                        Console.WriteLine("Pintu terkunci");
                    }
                    else
                    {
                        state = State.Terbuka;
                    }
                    break;
            }
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

        Console.WriteLine("\nDOOR MACHINE");
        DoorMachine door=new DoorMachine();
        door.Run();
    }
}
