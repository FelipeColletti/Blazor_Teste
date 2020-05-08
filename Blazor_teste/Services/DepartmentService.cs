using Blazor_teste.Data;
using Blazor_teste.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_teste.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            List<Department> department = await _context.Department.OrderBy(x => x.Name).ToListAsync();
            return department;
        }
    }
}
