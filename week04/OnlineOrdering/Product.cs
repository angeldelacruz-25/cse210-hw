
public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int qty)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = qty;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductInfo()
    {
        return $"{_name} ({_productId}) - " +
               $"${_price:F2} x {_quantity} = ${GetTotalCost():F2}";
    }
}
