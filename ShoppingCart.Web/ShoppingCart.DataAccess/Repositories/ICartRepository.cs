﻿using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public interface ICartRepository : IRepository<Cart>
    {
        void Update(Cart cart);
    }
}
