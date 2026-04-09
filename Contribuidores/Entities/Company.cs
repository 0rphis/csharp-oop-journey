namespace Contribuidores
{
    class Company : TaxPayes
    {
        public int NumberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double anualncome, int numberOfEmployees)
            : base(name, anualncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return Anualncome * 0.14;
            }
            else
            {
                return Anualncome * 0.16;
            }
        }
    }
}
