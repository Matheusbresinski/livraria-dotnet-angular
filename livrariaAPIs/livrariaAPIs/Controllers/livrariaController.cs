using livraria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class livrariaController : ControllerBase
    {
        private readonly ToDoContext _context;
        public livrariaController(ToDoContext context)
        {
            _context = context;
            _context.todosProducts.Add(new Product { Id = "1", Name = "Os hérois do Olimpo", Price = 24.0, Quantity = 1, Category = "Aventura", Img = "Img1" });
            _context.todosProducts.Add(new Product { Id = "2", Name = "As Aventura de boby", Price = 14.0, Quantity = 1, Category = "Aventura", Img = "Img1" });
            _context.todosProducts.Add(new Product { Id = "3", Name = "Animais selvagem", Price = 5.0, Quantity = 1, Category = "Infantil", Img = "Img1" });
            _context.todosProducts.Add(new Product { Id = "4", Name = "Biblia", Price = 100.0, Quantity = 1, Category = "Religião", Img = "Img1" });

            _context.SaveChangesAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduto(Product produto)
        {
            _context.todosProducts.Add(produto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetItem), new { id = produto.Id }, produto);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProdutos()
        {
            return await _context.todosProducts.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetItem(int id)
        {
            var item = await _context.todosProducts.FindAsync(id.ToString());

            if (item == null)
                 return NotFound();

            return item;          
        }



    }
}
