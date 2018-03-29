using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Blockchain;
using Microsoft.AspNetCore.Mvc;

namespace BlockCard.Controllers
{
    [Route("api/[controller]")]
    public class BlockchainController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<IBlockchain> All()
        {
            var blockchains = new List<IBlockchain>();
            Parallel.ForEach(Assembly.GetAssembly(typeof(IBlockchain)).GetTypes()
                .Where(blockchain => blockchain.IsSubclassOf(typeof(IBlockchain))),
                blockchain => blockchains.Add((IBlockchain)Activator.CreateInstance(blockchain)));
            return blockchains.OrderBy(blockchain => blockchain.Rank);
        }
    }
}
