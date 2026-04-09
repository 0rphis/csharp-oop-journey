namespace Contribuidores
{
    abstract class TaxPayes
    {
        public string Name { get; set; }
        public double Anualncome { get; set; }

        public TaxPayes() { }

        public TaxPayes(string name, double anualncome)
        {
            Name = name;
            Anualncome = anualncome;
        }

        public abstract double Tax();
    }
}
