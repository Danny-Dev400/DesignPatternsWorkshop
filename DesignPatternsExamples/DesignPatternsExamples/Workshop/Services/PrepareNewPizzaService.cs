using DesignPatternsExamples.Workshop.Models.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Services;

public class PrepareNewPizzaService
{
    public PizzaMaker Prepare(string pizzaType)
    {
        return PizzaFactory.GetPizza(pizzaType);
    }
}