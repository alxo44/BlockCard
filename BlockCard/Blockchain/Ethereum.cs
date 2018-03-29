namespace Blockchain
{
    public class Ethereum : IBlockchain
    {
        public Ethereum() : base() { }

        public override int Rank => 2;

        protected override void Load()
        {
            Initialize("a", "b", "c", "d", "e", "f", "g");
        }
    }
}
