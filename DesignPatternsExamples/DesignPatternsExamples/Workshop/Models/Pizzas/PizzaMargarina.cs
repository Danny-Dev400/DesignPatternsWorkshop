using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Models.Pizzas;

public class PizzaMargarina : PizzaMaker
{
    public override void AddIngredients()
    {
        throw new NotImplementedException();
    }

    public override void Bake()
    {
        throw new NotImplementedException();
    }

    public override void Kneading()
    {
        throw new NotImplementedException();
    }
}
