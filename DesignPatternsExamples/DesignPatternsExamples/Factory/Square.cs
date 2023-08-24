﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Factory;

public class Square : IShape
{
    public void draw()
    {
        Console.WriteLine("Square |__| ");
    }
}
