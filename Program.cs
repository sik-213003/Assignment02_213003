using System;

abstract class Telephone
{
    protected string phonetype;

    public abstract void Ring();
}

class ElectronicPhone : Telephone
{
    public ElectronicPhone()
    {
        phonetype = "Digital";
    }

    public void Run()
    {
        Ring();
    }

    public override void Ring()
    {
        Console.WriteLine("Electronic phone is ringing.");
    }
}

class DigitalPhone : Telephone
{
    public DigitalPhone()
    {
        phonetype = "Digital";
    }

    public override void Ring()
    {
        Console.WriteLine("Digital phone is ringing.");
    }
}

class TalkingPhone : Telephone
{
    public TalkingPhone()
    {
        phonetype = "Talking";
    }

    public override void Ring()
    {
        Console.WriteLine("Talking phone is ringing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ElectronicPhone electronicPhone = new ElectronicPhone();
        Telephone digitalPhone = new DigitalPhone();
        Telephone talkingPhone = new TalkingPhone();

        electronicPhone.Run();
        digitalPhone.Ring();
        talkingPhone.Ring();
    }
}
