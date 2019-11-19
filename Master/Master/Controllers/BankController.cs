using Microsoft.AspNetCore.Mvc;

namespace Master.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankController : ControllerBase
    {
        [Route("balance")]
        [HttpGet]
        public double Balance()
        {
            return Vault.TheBank.GetBalance();
        }

        [Route("add")]
        [HttpPost]
        public void Add([FromBody] double money)
        {
            Vault.TheBank.AddMoney(money);
        }

        [Route("remove")]
        [HttpPost]
        public void Remove([FromBody] double money)
        {
            Vault.TheBank.RemoveMoney(money);
        }

    }
}
