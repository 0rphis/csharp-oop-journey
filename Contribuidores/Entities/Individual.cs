namespace Contribuidores
{
    class Individual : TaxPayes
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double anualncome, double healthExpenditures)
            : base(name, anualncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (Anualncome < 20000.00)
            {
                return Anualncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return Anualncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
