using FrameworkEntity.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace FrameworkEntity.CodeFirst
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Initializer.Build();
            using (var _context = new AppDbContext())
            {
                var products = await _context.Products.ToListAsync();

                products.ForEach(p =>
                    Console.WriteLine($" p = {p.Name} : {p.Price}")
                );
            }



        }
    }
}
