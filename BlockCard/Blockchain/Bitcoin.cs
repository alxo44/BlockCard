namespace Blockchain
{
    public class Bitcoin : IBlockchain
    {
        public Bitcoin() : base() { }

        public override int Rank => 1;

        protected override void Load()
        {
            Initialize("a", "b", "c", "d", "e", "f", "g");
        }
    }
}
