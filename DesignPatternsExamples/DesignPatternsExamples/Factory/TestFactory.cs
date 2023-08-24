using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Factory;

public static class TestFactory
{
    public static void test()
    {
        List<IShape> shapes = new List<IShape>();

        shapes.Add(ShapeFactory.GetShape("Square"));
        shapes.Add(ShapeFactory.GetShape("Rectangle"));
        shapes.Add(ShapeFactory.GetShape("Triangle"));

        shapes.ForEach(s => s.draw());
    }
}
