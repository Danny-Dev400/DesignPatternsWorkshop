using DesignPatternsExamples.Workshop.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Models.User;

public class UserBuilder : IUser, IBuilder<User>
{
    private string name { get; set; }
    private int id { get; set; }
    private string? email { get; set; }
    private string? birthDate { get; set; }
    private int? phoneNumber { get; set; }

    public UserBuilder(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public UserBuilder FillEmail(string email)
    {
        this.email = email;
        return this;
    }

    public UserBuilder FillPhoneNumber(int number)
    {
        this.phoneNumber = number;
        return this;
    }

    public UserBuilder FillBirthDate(string date)
    {
        this.birthDate= date;
        return this;
    }

    public User build()
    {
        return new User()
        {
            name = name,
            id = id,
            email = email,
            birthDate = birthDate,
            phoneNumber = phoneNumber
        };
    }
}
