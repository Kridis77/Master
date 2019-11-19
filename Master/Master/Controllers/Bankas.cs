namespace Master.Controllers
{
    public class Bankas
    {
        public Bankas()
        {
            Mokesciai = 0.02;
            DraugiskesniMokesciai = 0.005;
            ArSumoketa = true;
        }
        private double Mokesciai { get; set; }
        private double DraugiskesniMokesciai { get; set; }
        private double Pinigai { get; set; }
        private bool ArSumoketa { get; set; }

        public void AddMoney(double money)
        {
            var mokestis = money * Mokesciai;
            if (!ArSumoketa)
            {
                return;
            }
            Pinigai += money;
            Pinigai -= mokestis;
        }
        public void RemoveMoney(double money)
        {
            var geriMokesciai = money * DraugiskesniMokesciai;
            if (Pinigai > money)
            {
                Pinigai -= geriMokesciai;
                Pinigai -= money;
            }
           
        }

        public double GetBalance()
        {
            return Pinigai;
        }
    }
}