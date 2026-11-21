
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.IsInUSA())
        {
            total += 5.00;
        }
        else
        {
            total += 35.00;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";

        foreach (Product product in _products)
        {
            label += product.GetProductInfo() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return "SHIPPING LABEL\n" + _customer.GetShippingLabel();
    }

    public string GetOrderInfo()
    {
        string info = "ORDER INFORMATION\n";

        foreach (Product product in _products)
        {
            info += product.GetProductInfo() + "\n";
        }

        info += $"Total cost (including shipping): ${CalculateTotalCost():F2}";

        return info;
    }
}
