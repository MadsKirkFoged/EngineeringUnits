using System;

namespace EngineeringUnits;

public class UVector
{

    public BaseUnit[] _vector;
    public int GetVectorSize => _vector.Length;

    public UVector(params BaseUnit[] x)
    {
        //Check same type
        TypeCheck(x);

        _vector = x;
    }

    public static void TypeCheck(BaseUnit[] x)
    {
        for (var i = 0; i < x.Length; i++)
        {
            GuardAgainst.DifferentUnits(x[0], x[i]);
        }
    }

    public void SameTypeAs(UVector v1)
    {
        //Same units
        GuardAgainst.DifferentUnits(v1._vector[0], _vector[0]);

        //Same size
        if (v1.GetVectorSize != GetVectorSize)
            throw new Exception("Vectors are not the same dimensional.");

    }

    public static UVector operator +(UVector v1, UVector v2)
    {
        var localvector = new BaseUnit[v1.GetVectorSize];

        //Check same kind of vectors
        v1.SameTypeAs(v2);

        //Add vectors
        for (var i = 0; i < v1.GetVectorSize; i++)
        {
            localvector[i] = v1._vector[i] + v2._vector[i];
        }

        return new UVector(localvector);
    }

    public static UVector operator -(UVector v1, UVector v2)
    {
        var localvector = new BaseUnit[v1.GetVectorSize];

        //Check same kind of vectors
        v1.SameTypeAs(v2);

        //Add vectors
        for (var i = 0; i < v1.GetVectorSize; i++)
        {
            localvector[i] = v1._vector[i] - v2._vector[i];
        }

        return new UVector(localvector);
    }

    public static UVector operator *(UVector v1, double v2)
    {
        var localvector = new BaseUnit[v1.GetVectorSize];

        //Check same kind of vectors
        //v1.SameTypeAs(v2);

        //Add vectors
        for (var i = 0; i < v1.GetVectorSize; i++)
        {
            localvector[i] = v1._vector[i] * v2;
        }

        return new UVector(localvector);
    }

    public static UnknownUnit DotProduct(UVector v1, UVector v2)
    {
        decimal localDotProduct = 0;

        //Check same kind of vectors
        v1.SameTypeAs(v2);

        //Add vectors
        for (var i = 0; i < v1.GetVectorSize; i++)
        {
            localDotProduct += v1._vector[i].SI * v2._vector[i].SI;
        }

        return new UnknownUnit(localDotProduct, v1._vector[0].Unit.GetSIUnitsystem());
    }

    public static UVector CrossProduct(UVector v1, UVector v2)
    {
        if (v1.GetVectorSize != 3)
            throw new Exception("Vector v1 must be 3 dimensional.");

        if (v2.GetVectorSize != 3)
            throw new Exception("Vector v2 must be 3 dimensional.");

        var x = (v1._vector[1].SI * v2._vector[2].SI) - (v1._vector[2].SI * v2._vector[1].SI);
        var y = (v1._vector[2].SI * v2._vector[0].SI) - (v1._vector[0].SI * v2._vector[2].SI);
        var z = (v1._vector[0].SI * v2._vector[1].SI) - (v1._vector[1].SI * v2._vector[0].SI);

        var X = new UnknownUnit(x, v1._vector[0].Unit.GetSIUnitsystem());
        var Y = new UnknownUnit(y, v1._vector[0].Unit.GetSIUnitsystem());
        var Z = new UnknownUnit(z, v1._vector[0].Unit.GetSIUnitsystem());

        return new UVector(X, Y, Z);
    }
}
