using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public class UVector
    {

        public UnknownUnit[] _vector;
        public int GetVectorSize => _vector.Length;


        public UVector(params UnknownUnit[] x)
        {
            //Check same type
            TypeCheck(x);

            _vector = x;
        }

        public static void TypeCheck(UnknownUnit[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[0].UnitCheck(x[i]);
            }
        }

        public void SameTypeAs(UVector v1)
        {
            //Same units
            v1._vector[0].UnitCheck(_vector[0]);

            //Same size
            if (v1.GetVectorSize != GetVectorSize)            
                throw new Exception("Vectors are not the same dimensional.");
            

        }

        public static UVector operator +(UVector v1, UVector v2)
        {
            UnknownUnit[] localvector = new UnknownUnit[v1.GetVectorSize];

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
            UnknownUnit[] localvector = new UnknownUnit[v1.GetVectorSize];

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
            UnknownUnit[] localvector = new UnknownUnit[v1.GetVectorSize];

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
            if (v1.GetVectorSize != 3) throw new Exception("Vector v1 must be 3 dimensional.");

            if (v2.GetVectorSize != 3) throw new Exception("Vector v2 must be 3 dimensional.");



            decimal x = v1._vector[1].SI * v2._vector[2].SI - v1._vector[2].SI * v2._vector[1].SI;
            decimal y = v1._vector[2].SI * v2._vector[0].SI - v1._vector[0].SI * v2._vector[2].SI;
            decimal z = v1._vector[0].SI * v2._vector[1].SI - v1._vector[1].SI * v2._vector[0].SI;

            UnknownUnit X = new UnknownUnit(x, v1._vector[0].Unit.GetSIUnitsystem());
            UnknownUnit Y = new UnknownUnit(y, v1._vector[0].Unit.GetSIUnitsystem());
            UnknownUnit Z = new UnknownUnit(z, v1._vector[0].Unit.GetSIUnitsystem());

            return new UVector(X,Y,Z);
        }



    }
}
