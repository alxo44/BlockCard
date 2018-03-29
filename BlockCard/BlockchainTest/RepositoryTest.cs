using Blockchain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlockchainTest
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void Bitcoin_Success()
        {
            var repository = new Repository(@"https://api.github.com/repos/bitcoin/bitcoin");
            Assert.IsNotNull(repository.Name);
            Assert.IsNotNull(repository.Description);
            Assert.IsNotNull(repository.OrganizationAvatarUrl);
            Assert.IsNotNull(repository.Language);
            Assert.IsNotNull(repository.OpenIssues);
            Assert.IsNotNull(repository.Forks);
            Assert.IsNotNull(repository.Homepage);
        }

        [TestMethod]
        public void Ethereum_Success()
        {
            var repository = new Repository(@"https://api.github.com/repos/ethereum/go-ethereum");
            Assert.IsNotNull(repository.Name);
            Assert.IsNotNull(repository.Description);
            Assert.IsNotNull(repository.OrganizationAvatarUrl);
            Assert.IsNotNull(repository.Language);
            Assert.IsNotNull(repository.OpenIssues);
            Assert.IsNotNull(repository.Forks);
            Assert.IsNotNull(repository.Homepage);
        }

        [TestMethod]
        public void Ripple_Success()
        {
            var repository = new Repository(@"https://api.github.com/repos/ripple/rippled");
            Assert.IsNotNull(repository.Name);
            Assert.IsNotNull(repository.Description);
            Assert.IsNotNull(repository.OrganizationAvatarUrl);
            Assert.IsNotNull(repository.Language);
            Assert.IsNotNull(repository.OpenIssues);
            Assert.IsNotNull(repository.Forks);
            Assert.IsNotNull(repository.Homepage);
        }

        [TestMethod]
        public void Litecoin_Success()
        {
            var repository = new Repository(@"https://api.github.com/repos/litecoin-project/litecoin");
            Assert.IsNotNull(repository.Name);
            Assert.IsNotNull(repository.Description);
            Assert.IsNotNull(repository.OrganizationAvatarUrl);
            Assert.IsNotNull(repository.Language);
            Assert.IsNotNull(repository.OpenIssues);
            Assert.IsNotNull(repository.Forks);
            Assert.IsNotNull(repository.Homepage);
        }

        [TestMethod]
        public void EOS_Success()
        {
            var repository = new Repository(@"https://api.github.com/repos/EOSIO/eos");
            Assert.IsNotNull(repository.Name);
            Assert.IsNotNull(repository.Description);
            Assert.IsNotNull(repository.OrganizationAvatarUrl);
            Assert.IsNotNull(repository.Language);
            Assert.IsNotNull(repository.OpenIssues);
            Assert.IsNotNull(repository.Forks);
            Assert.IsNotNull(repository.Homepage);
        }

        [TestMethod]
        public void Cardano_Success()
        {
            var repository = new Repository(@"https://api.github.com/repos/input-output-hk/cardano-sl");
            Assert.IsNotNull(repository.Name);
            Assert.IsNotNull(repository.Description);
            Assert.IsNotNull(repository.OrganizationAvatarUrl);
            Assert.IsNotNull(repository.Language);
            Assert.IsNotNull(repository.OpenIssues);
            Assert.IsNotNull(repository.Forks);
            Assert.IsNotNull(repository.Homepage);
        }

        [TestMethod]
        public void Stellar_Success()
        {
            var repository = new Repository(@"https://api.github.com/repos/stellar/stellar-core");
            Assert.IsNotNull(repository.Name);
            Assert.IsNotNull(repository.Description);
            Assert.IsNotNull(repository.OrganizationAvatarUrl);
            Assert.IsNotNull(repository.Language);
            Assert.IsNotNull(repository.OpenIssues);
            Assert.IsNotNull(repository.Forks);
            Assert.IsNotNull(repository.Homepage);
        }

        [TestMethod]
        public void Neo_Success()
        {
            var repository = new Repository(@"https://api.github.com/repos/neo-project/neo");
            Assert.IsNotNull(repository.Name);
            Assert.IsNotNull(repository.Description);
            Assert.IsNotNull(repository.OrganizationAvatarUrl);
            Assert.IsNotNull(repository.Language);
            Assert.IsNotNull(repository.OpenIssues);
            Assert.IsNotNull(repository.Forks);
            Assert.IsNotNull(repository.Homepage);
        }
    }
}
