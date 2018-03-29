﻿using Blockchain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlockchainTest
{
    [TestClass]
    public class LitecoinTest
    {
        [TestMethod]
        public void Litecoin_Success()
        {
            var blockchain = new Litecoin();
            Assert.AreNotEqual(0, blockchain.Rank);
            Assert.IsNotNull(blockchain.Name);
            Assert.IsNotNull(blockchain.Description);
            Assert.IsNotNull(blockchain.OrganizationAvatarUrl);
            Assert.IsNotNull(blockchain.Language);
            Assert.IsNotNull(blockchain.OpenIssues);
            Assert.IsNotNull(blockchain.Forks);
            Assert.IsNotNull(blockchain.Homepage);
        }
    }
}
