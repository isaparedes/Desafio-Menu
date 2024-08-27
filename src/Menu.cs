namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();

    public void AddDish(Dish dish)
    {
        if (dish != null && !dishes.Contains(dish))
        {
            dishes.Add(dish);
        }
    }
    public void RemoveDish(Dish dish)
    {
        if (dish != null && dishes.Contains(dish))
        {
            dishes.Remove(dish);
        }
    }
    public Dish GetDishByName(string name)
    {
        for (int i = 0; i < dishes.Count; i++)
        {
            Dish actualDish = (Dish)dishes[i];
            if (actualDish.Name == name)
            {
                return actualDish;
            }
        }
        return null;
    }
}