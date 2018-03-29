namespace Blockchain
{
    public class EOS : IBlockchain
    {
        public EOS() : base() { }

        public override int Rank => 6;

        protected override void Load()
        {
            Initialize("a", "b", "c", "d", "e", "f", "g");
        }
    }
}
