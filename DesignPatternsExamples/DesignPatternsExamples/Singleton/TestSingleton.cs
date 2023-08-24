using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Singleton;

public static class TestSingleton
{
    public static void test()
    {
        DatabaseInstance instance = DatabaseInstance.getInstance();
        Console.WriteLine(instance.GetHashCode());

        DatabaseInstance instance2 = DatabaseInstance.getInstance();
        Console.WriteLine(instance2.GetHashCode());

    }
}
