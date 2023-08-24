using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Models.Pizzas;

public abstract class PizzaMaker
{
    public void PreparePizza()
    {
        Kneading();
        AddIngredients();
        Bake();
    }

    abstract public void Kneading();
    abstract public void AddIngredients();
    abstract public void Bake();
}