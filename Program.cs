using System;

namespace Tugas1PBOPR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ban ban1 = new Michelin();
            Ban ban2 = new Bridgestone();
            Mobil mobil1 = new Agya(ban1);
            Console.WriteLine("Merk Ban Mobil Tipe " + mobil1 + ": " + ban1);
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();
            Console.WriteLine("================");
            Mobil mobil2 = new Avanza(ban2);
            mobil2.NyalakanMesin();
            mobil2.MatikanMesin();
            ((Avanza)mobil2).NyalakanLampu();
            Console.WriteLine("================");
            Mobil civic1 = new Civic(ban2);
            civic1.NyalakanMesin();
            civic1.MatikanMesin();
            ((Civic)civic1).VtecKickedIn();
            Console.WriteLine("================");
        }
    }
}

class Ban
{
    public string merk;
    public Ban(string merk)
    {
        this.merk = merk;
    }

}

class Michelin : Ban
{
    public Michelin() : base("Michelin")
    {
        merk = "Michelin";
    }
}

class Bridgestone : Ban
{
    public Bridgestone() : base("Bridgestone")
    {
        merk = "Bridgestone";
    }
}

class Mobil
{
    public string Merk, Tipe;
    public Ban ban;

    public Mobil(string merk, string tipe, Ban ban)
    {
        this.Merk = merk;
        this.Tipe = tipe;
        this.ban = ban;
    }

    public void NyalakanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.Merk} bertipe {this.Tipe} menyala");
    }

    public void MatikanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.Merk} bertipe {this.Tipe} mati");
    }
}

class Toyota : Mobil
{
        public Toyota(string tipe, Ban ban) : base("Toyota", tipe, ban)
        {
        }

}

class Daihatsu : Mobil
{
        public Daihatsu(string tipe, Ban ban) : base("Daihatsu", tipe, ban)
        {
        }

}

class Honda : Mobil
{
        public Honda(string tipe, Ban ban) : base("Honda", tipe, ban)
        {
        }

}

class Agya : Toyota
{
    public Agya(Ban ban) : base("Agya", ban)
    {
    }
}

class Innova : Toyota
{
    public Innova(Ban ban) : base("Innova", ban)
    {
    }
}

class Avanza : Toyota
{
    public Avanza(Ban ban) : base("Avanza", ban)
    {
    }
    public void NyalakanLampu()
    {
        Console.WriteLine($"Lampu mobil {this.Merk} bertipe {this.Tipe} menyala");
    }
}

class Ayla : Daihatsu
{
    public Ayla(Ban ban) : base("Ayla", ban)
    {
    }
}

class Xenia : Daihatsu
{
    public Xenia(Ban ban) : base("Xenia", ban)
    {
    }
}

class Brio : Honda
{
    public Brio(Ban ban) : base("Brio", ban)
    {
    }
}

class Civic : Honda
{
    public Civic(Ban ban) : base("Civic", ban)
    {
    }
    public void VtecKickedIn()
    {
        Console.WriteLine($"Ngeeeng Wooosh!");
    }
}