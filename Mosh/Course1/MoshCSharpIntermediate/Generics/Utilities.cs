using System;

namespace Generics
{



    /*
    The different kinds of constraints are:
    
    where T : IComparable

    where T : Product // meaning the type must be a specific class
    
    where T : struct // meaning T should be a value type

    where T : class // meaning T has to be a reference type

    where T : new() // meaning T is an object that has a default constructor
    
     */


    // where T : IComparable
    public class Utilities<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    // where T is a class
    public class DiscountCaluculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    // where T is a value type
    public class Nullable<T> where T : struct
    {

        private object _value;
        // in C#, value types can not be null

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }
            return default(T);
        }
    }

}
