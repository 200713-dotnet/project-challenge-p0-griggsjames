using PizzaBox.Domain.Models;
using System.Collections.Generic;
using Xunit;


namespace PizzaStore.Testing.Tests
{
  public class OrderTest
  {
    [Theory]
    [InlineData("N","S","C","t",10.00)]
    public void Test_AddPizza(string n, string c, string s, string  t, double p )
    {
      
      var sut = new Order();
      string size = s;
      string crust = c;
      string name = n;
      double price =p;
      List<string> toppings = new List<string>{t};

      sut.AddPizza(name, crust, size, toppings, price );
      Assert.True(sut.Pizzas.Count > 0);
    }
  }
}
