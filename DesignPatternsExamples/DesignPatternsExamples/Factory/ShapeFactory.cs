using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Factory;

public static class ShapeFactory
{
    public static IShape GetShape(string shapeName)
    {
        return shapeName switch
        {
            "Rectangle" => new Rectangle(),
            "Square" => new Square(),
            "Triangle" => new Triangle(),
            _ => throw new NotImplementedException()
        };
    }   
}
