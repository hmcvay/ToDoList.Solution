using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Item> Items { get; set; }
  

    public Category(string categoryName)
    {
      Name = categoryName;
      _instances.Add(this);
      Id = _instances.Count;
      Items = new List<Item>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Category> GetAll()
    {
      return _instances;
    }

    public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddItem(Item item)
    {
      Items.Add(item);
    }
  }
}

// public string Name { get; set; }

//  public Category(string name)
//     {
//       Name = name;

//       Category myCategory = new Category("Dishes");

//       Category.Name

//       myCategory.name; 
//       @Model.Name

//       view(catergory // Category(2)
//       home
//       Work
//       category = "Work"
//       Work
//       -do work
//       -pretend to do work
//       "Work"
//       Model.Name
//       @Model.name;