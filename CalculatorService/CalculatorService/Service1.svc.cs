﻿using System.Security.Policy;

public class CalculatorService : ICalculatorService
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }
}

