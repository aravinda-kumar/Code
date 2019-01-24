﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_28
{
    using System;

    class EntityBase
    {
        public virtual void Method<T>(T t)
            where T : IComparable<T>
        {
            // ...
        }
    }

    class Order : EntityBase
    {
        public override void Method<T>(T t)
        //    Constraints may not be repeated on overriding
        //    members
        //    where T : IComparable<T>
        {
            // ...
        }
    }
}