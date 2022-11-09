using System.Text;

namespace Exercise3._3
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(bool huntsInPack, string name, decimal weight, decimal age) : base(huntsInPack, name, weight, age)
        {
        }
        public void Talk()
        {
            Console.WriteLine($"Wolfman talks!");
        }
        public override string Stats()
        {
            return Extensions.makeStringofProperties(this);

        }
    }
}
