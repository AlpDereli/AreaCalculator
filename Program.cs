// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
giris menu = new giris();
parameters length = new parameters();
int shape = menu.menu1();
int operation = menu.menu2();
if (shape == 1)
{
    double r = length.radiustake();
    if (operation == 1)
    {
        double area2 = 3.14f * (Math.Pow(r,2));
        Console.WriteLine("Area: " + area2);
    }
    if (operation == 2)
    {
        double perimeter2 = 2 * 3.14f * r;
        Console.WriteLine("Perimeter: " + perimeter2);
    }
}
if (shape == 2)
{
    double w = length.widthtake();
    if (operation == 1)
    {
        double area = w * w;
        Console.WriteLine("Area: " + area);
    }
    if (operation==2)
    {
        double perimeter = w * 4;
        Console.WriteLine("Perimeter: " + perimeter);
    }
}
if (shape == 3)
{
    if (operation ==1)
    {
        double w = length.widthtake();
        double h = length.heighttake();
        double area3 = (w * h) / 2;
        Console.WriteLine("Area: " + area3);
    }
    if (operation == 2)
    {
        Console.WriteLine("Please enter the length of an edge: ");
        double l = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the lenght of the other edge: ");
        double l1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the edge of the last edge: ");
        double l2 = double.Parse(Console.ReadLine());
        double t = l + l1 + l2;
        Console.WriteLine("Perimeter: " + t);
    }
    
}
if (shape == 4)
{
    double h = length.heighttake();
    double w = length.widthtake();
    if (operation == 1)
    {
        double area1 = h * w;
        Console.WriteLine("Area: " + area1);
    }
    if (operation == 2)
    {
        double perimeter1 = (h * 2) + (w * 2);
        Console.WriteLine("Perimeter: " + perimeter1);
    }
}




class giris
{
    public int menu1()
    {
        Console.WriteLine("Please select the geometric shape: ");
        Console.WriteLine("(1) Sphere");
        Console.WriteLine("(2) Square");
        Console.WriteLine("(3) Triangle");
        Console.WriteLine("(4) Rectengular");
        int selection = int.Parse(Console.ReadLine());
        return selection;
    }
    public int menu2()
    {
        Console.WriteLine("Please select the operation: ");
        Console.WriteLine("(1) Area Calculation");
        Console.WriteLine("(2) Perimeter Calculation");
        int selection = int.Parse(Console.ReadLine());
        return selection;
    }
}

class parameters
{
    public double heighttake()
    {
        Console.WriteLine("Please enter the height: ");
        double height = double.Parse(Console.ReadLine());
        return height;
    }
    public double widthtake()
    {
        Console.WriteLine("Please enter the width: ");
        double width = double.Parse(Console.ReadLine());
        return width;
    }
    public double radiustake()
    {
        Console.WriteLine("Please enter the radius: ");
        double radius = double.Parse(Console.ReadLine());
        return radius;
    }
}

