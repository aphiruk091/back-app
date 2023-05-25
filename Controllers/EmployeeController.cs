using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using back_app.Models;
namespace back_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly OraDbContext _context;

        public EmployeeController(OraDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetEmployee")]
        public async Task<IActionResult> Get()
        {
            var result = await _context.Employees.ToListAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _context.Employees.FindAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        [Route("AddEmp")]
        public async Task<Employee> AddEmployee(Employee objEmployee)
        {
            _context.Employees.Add(objEmployee);
            await _context.SaveChangesAsync();
            return objEmployee;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, Employee objEmployee)
        {
            if (objEmployee.Id != id)
            {
                return NotFound();
            }
            _context.Entry(objEmployee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var updatedEmployee = _context.Employees.FindAsync(id);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DelEmployee(int id)
        {
            var entity = await _context.Employees.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}