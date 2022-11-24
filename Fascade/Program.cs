namespace Fascade;


public class Product
{
    public void GetProductDetails()
    {
        Console.WriteLine("Fetching the Product Details");
    }
}

public class Payment
{
    public void MakePayment()
    {
        Console.WriteLine("Payment Done Successfully");
    }
}

public class Invoice
{
    public void SendInvoice()
    {
        Console.WriteLine("Invoice Send Successfully");
    }
}


public class Order
{
    public void PlaceOrder()
    {
        Product product = new Product(); 
        Payment payment = new Payment();
        Invoice invoice = new Invoice();

        Console.WriteLine("Place Order Started");

        product.GetProductDetails();
        payment.MakePayment();
        invoice.SendInvoice();

        Console.WriteLine("Order Placed Successfully");
    }
}



class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        order.PlaceOrder();
    }
}