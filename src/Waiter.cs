using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private ArrayList assignedTables = new ArrayList();
    public Waiter(string name)
    {
        Name = name;
    }
    public void AssignTable(Table table)
    {
        if (table != null && !assignedTables.Contains(table) && table.Number <= 20)
        {
            assignedTables.Add(table);
        }
    }
    public void TakeOrder(Table table, Dish dish)
    {
        if (dish != null && !table.Order.Contains(dish) && table.Number <= 20)
        {
            table.AddToOrder(dish);
        }
    }
}