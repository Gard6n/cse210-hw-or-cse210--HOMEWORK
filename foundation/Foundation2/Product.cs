namespace Foundation2;

public class Product
{
    private string _productname;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string productname, int productId, double price, int quantity)
    {
        _productname = productname;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double totalPrice()
    {
        double sum = _price * _quantity;
        return sum;
    }

    public Tuple<string,int> productstuff()
    {
        Tuple<string,int> products = new Tuple<string,int>(_productname, _productId);
       
        return products;
    }


}  