namespace Foundation2;

public class Address
{
    private string _streetaddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetaddress, string city, string state, string country)
    {
        _streetaddress = streetaddress;
        _city = city;
        _state = state;
        _country = country;
    }
    
    public bool US()
    {
        bool usa;
        if(_country.Equals("USA"))
        {
            usa = true;
        }
        else
        {
            usa = false;
        }
        return usa;
    }

    public string Display()
    {
       string customeraddress = "";

       customeraddress += String.Join("\n",_streetaddress,_city,_state,_country);

        return customeraddress;
    }

}
