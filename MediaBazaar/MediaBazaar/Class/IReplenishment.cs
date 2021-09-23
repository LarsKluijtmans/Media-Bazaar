using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    interface IReplenishment
    {
        void Requested(Product p);
        void Replenish(Product p);
    }
}
