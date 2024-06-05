using ShoppingCart.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public ICategoryRepository Category { get; set; }
        public IProductRepository Product { get; set; }
        //public ICartRepository Cart { get; set; }
        //public IApplicationUserRepository ApplicationUser { get; set; }
        //public IOrderDetailRepository OrderDetail { get; set; }
        //public IOrderHeaderRepository OrderHeader { get; set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(context);
            Product = new ProductRepository(context);
            //Cart = new CartRepository(context);
            //ApplicationUser = new ApplicationUserRepository(context);
            //OrderDetail = new OrderDetailRepository(context);
            //OrderHeader = new OrderHeaderRepository(context);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
