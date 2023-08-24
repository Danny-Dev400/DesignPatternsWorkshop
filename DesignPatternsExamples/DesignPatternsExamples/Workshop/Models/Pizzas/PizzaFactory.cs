using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Models.Pizzas;

public static class PizzaFactory
{
     public static PizzaMaker GetPizza(string pizzaType)
     {
        return pizzaType switch
        {
            "vegetales" => new PizzaVegetables(),
            "frutas" => new PizzaFruits(),
            "margarita" => new PizzaMargarina(),
            "nutella" => new PizzaNutella(),
            _ => throw new NotImplementedException(),
        };
     }
}
