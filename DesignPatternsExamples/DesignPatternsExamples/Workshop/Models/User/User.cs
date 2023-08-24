using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Models.User;

public class User
{
    public string name { get; set; }
    public int id { get; set; }
    public string? email { get; set; }
    public string? birthDate { get; set; }
    public int? phoneNumber { get; set; }
}
