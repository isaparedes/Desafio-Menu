namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private int number;
    public int Number
    {
        get { return number; }
        set { number = value; }
    }
    private bool isOccupied;
    public bool IsOccupied
    {
        get {return isOccupied;}
        set { isOccupied = value; }
    }
    private ArrayList order = new ArrayList();
    public ArrayList Order
    {
        get { return order; }
    }
    public Table(int number)
    {
        Number = number;
    }
    public void Occupy()
    {
        IsOccupied = true;
    }
    public void Free()
    {
        IsOccupied = false;
        order.Clear();
    }
    public void AddToOrder(Dish dish)
    {
        if (dish != null && !order.Contains(dish))
        {
            order.Add(dish);
        }
    }
    public bool HasOrders()
    {
        return order.Count > 0;
    }
    public double GetTotal()
    {
        double total = 0.0;
        for (int i = 0; i < order.Count; i++)
        {
            Dish oneDish = (Dish)order[i];
            total += oneDish.Price;
        }
        return total;
    }
}