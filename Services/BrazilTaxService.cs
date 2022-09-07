namespace ex01_no_interfaces.Services
{
    internal class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            return amount * 0.15;
        }
    }
}
