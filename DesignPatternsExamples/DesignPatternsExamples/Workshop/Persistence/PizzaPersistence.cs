using DesignPatternsExamples.Workshop.Models.Pizzas;
using DesignPatternsExamples.Workshop.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Persistence;

public class PizzaPersistence
{
    private List<PizzaMaker> sellPizzas;

    private static PizzaPersistence? instance = null;
    private PizzaPersistence()
    {
        sellPizzas = new List<PizzaMaker>();
    }

    public static PizzaPersistence getInstance()
    {
        if (instance == null)
        {
            instance = new PizzaPersistence();
        }
        return instance;
    }

    public void SetPizza(PizzaMaker pizza)
    {
        sellPizzas.Add(pizza);
    }
}
