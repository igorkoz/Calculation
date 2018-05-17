using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculations.Controllers
{
    [Produces("application/json")]
    [Route("api/calculation")]
    public class CalculationController : Controller
    {
        private IRepository repository;

        public CalculationController(IRepository repo)
        {
            repository = repo;
        }

        // GET: api/Calculation
        [HttpGet]
        public IEnumerable<CalculationResult> Get() => repository.Results;

        // GET: api/Calculation/5
        [HttpGet("{id}", Name = "Get")]
        public CalculationResult Get(int id) => repository[id];

        // POST: api/Calculation
        [HttpPost]
        public int Post(CalculationResult result)
        {
            return repository.AddResult(new CalculationResult { OperationName = result.OperationName,
                Result = Operation.ExecuteOperation(result.OperationName, result.num1, result.num2),
                num1 = result.num1,
                num2 = result.num2 }
            );
        }

        // DELETE: api/Calculation/5
        [HttpDelete("{id}")]
        public void Delete(int id) => repository.DeleteResult(id);
    }
}
