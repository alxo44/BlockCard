namespace Blockchain
{
    public class Litecoin : IBlockchain
    {
        public Litecoin() : base() { }

        public override int Rank => 5;

        protected override void Load()
        {
            Initialize("a", "b", "c", "d", "e", "f", "g");
        }
    }
}
