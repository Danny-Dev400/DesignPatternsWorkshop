using DesignPatternsExamples.Workshop.Models.User;
using DesignPatternsExamples.Workshop.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Services;

public class RegisterUserService : IResgister
{
    public void RegisterUser(IUser user)
    {
        UsersPersistence p = UsersPersistence.getInstance();
        p.SetUser(user);
    }
}
