﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcretProduct();
        }
    }
}