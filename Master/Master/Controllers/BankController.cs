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

        [Route("add/{money}")]
        [HttpGet]
        public void Add(double money)
        {
            Vault.TheBank.AddMoney(money);
        }

        [Route("remove/{money}")]
        [HttpGet]
        public void Remove(double money)
        {
            Vault.TheBank.RemoveMoney(money);
        }

    }
    public static class Vault
    {
        public static Bankas TheBank = new Bankas();
    }
}
