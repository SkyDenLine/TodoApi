using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoContex : DbContext
    {
        public TodoContex(DbContextOptions<TodoContex> options ) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }

        
    }
}
