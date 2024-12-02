namespace Foundation2;

class Program
{
    static void Main(string[] args)
    {
        bool keepgoing = true;
        int change = 0;
        while (keepgoing)
        {
            var stuff1 = (name: "Bleach", id: 34, price: 12.50, quantity: 5);
            if (change == 1)
            {
                stuff1 = (name: "Dog Food", id: 123, price: 20.42, quantity: 10);
            }
            
            Address ad = new Address("252 apple st","Westway","Newyork","USA");
            Customer customer1 = new Customer(ad, "John Doe");
            Product prod = new Product(stuff1.name, stuff1.id, stuff1.price, stuff1.quantity);
            Order Neworder = new Order(customer1, prod);
            Console.WriteLine(Neworder.Display());

            if (change == 1)        
            {
                keepgoing = false;
            }
            else
            {
                change++;
            }
        }
    }
}