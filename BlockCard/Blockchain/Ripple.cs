namespace Blockchain
{
    public class Ripple : IBlockchain
    {
        public Ripple() : base() { }

        public override int Rank => 3;

        protected override void Load()
        {
            Initialize("a", "b", "c", "d", "e", "f", "g");
        }
    }
}
