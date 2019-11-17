﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Chloe.Entity
{
    public class CollectionPropertyDefinition : PropertyDefinition
    {
        public CollectionPropertyDefinition(PropertyInfo property, IList<object> annotations) : base(property, annotations)
        {
            this.ElementType = property.PropertyType.GetGenericArguments().First();
        }
        public override TypeKind Kind { get { return TypeKind.Collection; } }
        public Type ElementType { get; private set; }
    }
}