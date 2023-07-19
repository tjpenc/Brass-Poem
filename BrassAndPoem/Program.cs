﻿using System.Xml.Serialization;
using System.Linq;
using System.Linq.Expressions;
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>
{
    new Product
    {
        Name = "Brass",
        Price = 5.00M,
        ProductTypeId = 1,
    },
    new Product
    {
        Name = "Poem",
        Price = 10.00M,
        ProductTypeId = 2,
    },
    new Product
    {
        Name = "Brass Cat",
        Price = 15.00M,
        ProductTypeId = 1,
    },
    new Product
    {
        Name = "Sad Poem",
        Price = 20.00M,
        ProductTypeId = 2,
    },
    new Product
    {
        Name = "Cool Brass Insect",
        Price = 25.00M,
        ProductTypeId = 1,
    },
};
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>
{
    new ProductType
    {
        Title = "Brass",
        Id = 1,
    },
    new ProductType
    {
        Title = "Poem",
        Id = 2,
    },
};
//put your greeting here
Console.Clear();
Console.WriteLine("Welcome to Brass and Poem!");
//implement your loop here
string choice = null;
while (choice != "5")
{
    Console.WriteLine(@"Please choose an option:
1. Display All Products
2. Delete Product
3. Add Product
4. Update Product Properties
5. Exit");
    choice = Console.ReadLine();
    if (choice == "1")
    {
        DisplayAllProducts(products, productTypes);
    }
    else if (choice == "2")
    {
        DeleteProduct(products, productTypes);
    }
    else if (choice == "3")
    {
        AddProduct(products, productTypes);
    }
    else if (choice == "4")
    {
        UpdateProduct(products, productTypes);
    }
    else if (choice == "5")
    {
        Console.WriteLine("Goodbye");
    }
    else
    {
        Console.WriteLine("Please Choose a viable option");
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    Console.Clear();
}
void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.Clear();
    Console.WriteLine("Available Items:");
    for (int i = 0; i < products.Count; i++)
    {
        Product product = products[i];
        ProductType productTypeQuery = productTypes.First(productType => product.ProductTypeId == productType.Id);
        Console.WriteLine($"{i + 1}. {productTypeQuery.Title}: {product.Name} is ${product.Price}");
    };
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }