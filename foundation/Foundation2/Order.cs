namespace Foundation2;

public class Order
{
    Customer _customercon;
    Product _productcon;
    private Tuple<string,int> _product;
    private string _customer;
    private string _label;

    public Order(Customer customer, Product Pro)
    {
        _productcon = Pro;
        _customercon = customer;
        _customer += customer.Name();
        _product = _productcon.productstuff();
    }

    public double tax()
    {
        double sum = _productcon.totalPrice();
        if (!_customercon.USAddress())
        {
             sum += 35;
        }
        else
        {
            sum += 5;
        }
        return sum;
    }

    public void package()
    {
        _label += String.Join("\n",$"Product: {_product.Item1}" ,$"Id: {_product.Item2}");
    }
    
    public string Display()
    {
        package();
        string name = _customer;
        string addy = _customercon.Address();
        _label += String.Join("\n", "\n", name, addy);
        return _label;
    }
        
}