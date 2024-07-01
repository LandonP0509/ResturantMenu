using System;
using System.Collections.Generic;

public class MenuItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public bool IsNew { get; set; }

    public MenuItem(string name, decimal price, string description, string category, bool isNew)
    {
        Name = name;
        Price = price;
        Description = description;
        Category = category;
        IsNew = isNew;
    }

    public override string ToString()
    {
        return $"{Name} ({Category}) - {Price:C}\n{Description}\n{(IsNew ? "New!" : "")}\n";
    }
}

public class Menu
{
    public List<MenuItem> Items { get; set; }
    public DateTime LastUpdated { get; private set; }

    public Menu()
    {
        Items = new List<MenuItem>();
        LastUpdated = DateTime.Now;
    }

    public void AddMenuItem(MenuItem item)
    {
        Items.Add(item);
        LastUpdated = DateTime.Now;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        foreach (var item in Items)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Recently Updated: {LastUpdated}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        MenuItem item1 = new MenuItem("Onion Bloom", 6.99m, "Onion sliced down the middle and fried with a mayo-based sauce on the side. ", "Appetizer", false);
        MenuItem item2 = new MenuItem("Classic Cheese Burger", 11.99m, "Fresh beef patty on a honey-wheat bun, topped with cheddar cheese, mustard and pickles.", "Main Course", true);
        MenuItem item3 = new MenuItem("Pecan Pie", 9.99m, "A warm and rich buttery crust, filled with a gooey and sugary interior, topped with pecan nuts.", "Dessert", true);

        menu.AddMenuItem(item1);
        menu.AddMenuItem(item2);
        menu.AddMenuItem(item3);

        menu.DisplayMenu();
    }
}
