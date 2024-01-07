using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        var iphone = new Iphone("81999992233", "Iphone", "123456789101112", 128);
        var nokia = new Nokia("81999994455", "Nokia", "123456789101112", 128);

        iphone.InstalarAplicativo("Youtube");
        nokia.InstalarAplicativo("Dio");
    }
}