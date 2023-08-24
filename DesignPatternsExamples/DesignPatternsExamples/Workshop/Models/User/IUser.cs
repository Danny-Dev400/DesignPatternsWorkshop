using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Models.User;

public interface IUser
{
    public UserBuilder FillEmail(string email);
    public UserBuilder FillPhoneNumber(int number);
    public UserBuilder FillBirthDate(string date);
}
