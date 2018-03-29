namespace Blockchain
{
    public class BitcoinCash : IBlockchain
    {
        public BitcoinCash() : base() { }

        public override int Rank => 4;

        protected override void Load()
        {
            Initialize("a", "b", "c", "d", "e", "f", "g");
        }
    }
}
