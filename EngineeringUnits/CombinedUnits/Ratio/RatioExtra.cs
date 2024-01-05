using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public partial class Ratio : BaseUnit
{

    public static implicit operator Ratio(int Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }

    public static implicit operator Ratio(decimal Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }

    public static implicit operator Ratio(double Unit)
    {
        return new Ratio(Unit, RatioUnit.DecimalFraction);
    }

    public static UnknownUnit operator -(int left, Ratio right)     => (Ratio)left - right;
    public static UnknownUnit operator -(Ratio left, int right)     => left - (Ratio)right;
    public static UnknownUnit operator -(Ratio left, double right)  => left - (Ratio)right;
    public static UnknownUnit operator -(double left, Ratio right)  => (Ratio)left - right;
    public static UnknownUnit operator -(Ratio left, decimal right) => left - (Ratio)right;
    public static UnknownUnit operator -(decimal left, Ratio right) => (Ratio)left - right;



    public static UnknownUnit operator +(int left, Ratio right)     => (Ratio)left + right;
    public static UnknownUnit operator +(Ratio left, int right)     => left + (Ratio)right;
    public static UnknownUnit operator +(Ratio left, double right)  => left + (Ratio)right;
    public static UnknownUnit operator +(double left, Ratio right)  => (Ratio)left + right;
    public static UnknownUnit operator +(Ratio left, decimal right) => left + (Ratio)right;
    public static UnknownUnit operator +(decimal left, Ratio right) => (Ratio)left + right;


    public static UnknownUnit operator *(int left, Ratio right)     => (Ratio)left * right;
    public static UnknownUnit operator *(Ratio left, int right)     => left * (Ratio)right;
    public static UnknownUnit operator *(Ratio left, double right)  => left * (Ratio)right;
    public static UnknownUnit operator *(double left, Ratio right)  => (Ratio)left * right;
    public static UnknownUnit operator *(Ratio left, decimal right) => left * (Ratio)right;
    public static UnknownUnit operator *(decimal left, Ratio right) => (Ratio)left * right;

    public static UnknownUnit operator /(int left, Ratio right)     => (Ratio)left / right;
    public static UnknownUnit operator /(Ratio left, int right)     => left / (Ratio)right;
    public static UnknownUnit operator /(Ratio left, double right)  => left / (Ratio)right;
    public static UnknownUnit operator /(double left, Ratio right)  => (Ratio)left / right;
    public static UnknownUnit operator /(Ratio left, decimal right) => left / (Ratio)right;
    public static UnknownUnit operator /(decimal left, Ratio right) => (Ratio)left / right;
}
