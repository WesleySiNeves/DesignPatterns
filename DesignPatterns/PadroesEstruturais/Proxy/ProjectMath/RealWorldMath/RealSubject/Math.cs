﻿using RealWorldMath.SubjectInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldMath.RealSubject
{
    public class Math : IMath
    {
        public double Add(double x, double y)
        { 
            return x + y; 
        }
        public double Sub(double x, double y)
        { 
            return x - y;
        }
        public double Mul(double x, double y) 
        { 
            return x * y; 
        }
        public double Div(double x, double y)
        { 
            return x / y; 
        }
    }
}
