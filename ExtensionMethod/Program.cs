//Extension:- we have to make the method as static 
using System;
public class Order
{
    public void PlaceOrder()
    {
        Console.WriteLine("Order Placed");
    }
    public void OrderStatus()
    {
        Console.WriteLine("Bhopal");
    }
    public void OrderCancled()
    {
        Console.WriteLine("Order cancled");
    }



}
public static class Cutomer
{
    public static void CreateOrder(this Order ord)
    {
        Console.WriteLine("Order Created");
    }
}
public class Product
{
    public static void Main()
    {
        Order ord = new Order();
        ord.CreateOrder();
        string name = "Raja";
        name.VerifiedBySonam();

    }
}// extension method allow u to new method in exesiting class and without modifing the source code
//extension method is just like the method that allow as to create new method with exsisting class without modifing the source code
//when we have to reused the class inside the other class that time we are used extension  method.
public static class Test
{
    public static void VerifiedBySonam(this string str)
    {
    }
}


