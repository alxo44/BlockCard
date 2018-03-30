using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blockchain;
using Microsoft.AspNetCore.Mvc;

namespace BlockCard.Controllers
{
    [Route("api/[controller]")]
    public class RepositoryController : Controller
    {
        [HttpGet("[action]")]
        [ResponseCache(Duration = 3600)]
        public IEnumerable<Repository> All()
        {
            var apiFullNames = Properties.Resources.ResourceManager.GetString("ApiList").Split(';');
            var apiRoot = Properties.Resources.ResourceManager.GetString("ApiRoot");
            var repositories = new SortedDictionary<int, Repository>();
            Parallel.ForEach(apiFullNames, apiFullName => repositories.Add(Array.IndexOf(apiFullNames, apiFullName),
                (Repository)Activator.CreateInstance(typeof(Repository), apiRoot + apiFullName)));
            return repositories.Select(repository => repository.Value);
        }
    }
}
