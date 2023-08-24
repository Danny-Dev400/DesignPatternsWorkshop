using DesignPatternsExamples.Singleton;
using DesignPatternsExamples.Workshop.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Persistence;

public class UsersPersistence
{
    private List<IUser> usersDB;

    private static UsersPersistence? instance = null;
    private UsersPersistence()
    {
        usersDB = new List<User>();
    }

    public static UsersPersistence getInstance()
    {
        if (instance == null)
        {
            instance = new UsersPersistence();
        }
        return instance;
    }

    public void SetUser(IUser user)
    {
        this.usersDB.Add(user);
    }

    public List<User> getUsers()
    {
        return this.usersDB;
    }
}
