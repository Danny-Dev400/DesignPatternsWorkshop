using DesignPatternsExamples.Workshop.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Services;

public interface IResgister
{
    void RegisterUser(IUser user);
}
