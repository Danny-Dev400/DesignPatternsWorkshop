﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Workshop.Utils;

public interface IBuilder<T>
{
    public T build();
}
