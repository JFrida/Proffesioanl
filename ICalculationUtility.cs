﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface ICalculationUtility<T>
    {
        void Addition();
        void Division();
        void Multiplication();
        void Subtraction();
    }

}
