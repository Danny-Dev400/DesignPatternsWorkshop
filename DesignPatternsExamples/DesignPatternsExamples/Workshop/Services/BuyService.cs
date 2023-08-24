using DesignPatternsExamples.Workshop.Models.Pizzas;
using DesignPatternsExamples.Workshop.Models.User;
using DesignPatternsExamples.Workshop.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Services;

public class BuyService
{
    private PizzaPersistence pizzaPersistence = PizzaPersistence.getInstance();
    public BuyService(IUser user, string pizzaType)
    {
        RegisterUserService ruser = new RegisterUserService();
        ruser.RegisterUser(user);
        pizzaPersistence.SetPizza(PizzaFactory.GetPizza(pizzaType));

    }
}
