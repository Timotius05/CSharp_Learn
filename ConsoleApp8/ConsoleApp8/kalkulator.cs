using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public interface kalkulator
    {
        double add(double x, double y);
        double min(double x, double y);
        double cross(double x, double y);
        double devide(double x, double y);
    }
    class hitung : kalkulator
    {
        double add(double x, double y)
        {
           return x+y;
        }

        double min(double x, double y)
        {
            return x - y;
        }

        double cross(double x, double y)
        {
            return x / y;
        }

        double devide(double x, double y)
        {
            return x * y;
        }
    }

    }

