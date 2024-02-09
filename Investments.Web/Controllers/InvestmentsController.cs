using Investments.Core;
using Investments.DB;
using Microsoft.AspNetCore.Mvc;

namespace Investments.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvestmentsController : ControllerBase
    {

        private IInvestmentsServices _investmentsServices;
        public InvestmentsController(IInvestmentsServices investmentsServices)
        {
            _investmentsServices = investmentsServices;
        }

        [HttpGet]
        public IActionResult GetInvestments()
        {
            return Ok(_investmentsServices.GetInvestments());
        }

        [HttpGet("{id}", Name = "GetInvestment")]
        public IActionResult GetInvestment(int id)
        {
            return Ok(_investmentsServices.GetInvestment(id));
        }

        [HttpPost]
        public IActionResult CreateInvestment(DB.Investment investment)
        {
            var val = _investmentsServices.CreateInvestment(investment);
            return CreatedAtRoute("GetInvestment", new { val.Id }, val);
        }

        [HttpDelete]
        public IActionResult DeleteInvestment(Investment investment)
        {
            _investmentsServices.DeleteInvestment(investment);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditInvestment(int id)
        {
            return Ok(_investmentsServices.EditInvestment(id));
        }

    }
}
