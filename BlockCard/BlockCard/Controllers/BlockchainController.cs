using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlockCard.Controllers
{
    [Route("api/[controller]")]
    public class BlockchainController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Blockchain> All() => Assembly.GetAssembly(typeof(Blockchain)).GetTypes()
                .Where(blockchain => blockchain.IsSubclassOf(typeof(Blockchain)))
                .Select(blockchain => (Blockchain)Activator.CreateInstance(blockchain));

        public abstract class Blockchain
        {
            public string Name { get; private set; }
            public string Description { get; private set; }
            public string OrganizationAvatarUrl { get; private set; }
            public string Language { get; private set; }
            public string OpenIssues { get; private set; }
            public string Forks { get; private set; }
            public string Homepage { get; private set; }

            public Blockchain() => Load();

            protected abstract void Load();

            protected void Initialize(string name, string description, string organizationAvatarUrl,
                string language, string openIssues, string forks, string homepage)
            {
                Name = name;
                Description = description;
                OrganizationAvatarUrl = organizationAvatarUrl;
                Language = language;
                OpenIssues = openIssues;
                Forks = forks;
                Homepage = homepage;
            }
        }

        public class Bitcoin : Blockchain
        {
            public Bitcoin() : base() { }

            protected override void Load()
            {
                Initialize("a", "b", "c", "d", "e", "f", "g");
            }
        }
    }
}
