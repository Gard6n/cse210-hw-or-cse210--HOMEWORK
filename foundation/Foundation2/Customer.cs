namespace Foundation2;

public class Customer
{
    private string _customername;
    private Address _address;

    public Customer(Address address, string customername)
    {
        _address = address;
        _customername = customername;
    }

    public string Name()
    {
        return _customername;
    }

    public string Address()
    {
        string addy =_address.Display();
        return addy;
    }
    
    public bool USAddress()
    {
        bool residences;
        if (!_address.US())
        {
            residences = false;
        }
        else
        {
            residences = true;
        }
        return residences;
    }


}