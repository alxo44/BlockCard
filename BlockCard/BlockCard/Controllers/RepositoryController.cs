using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;
using Blockchain;
using Microsoft.AspNetCore.Mvc;

namespace BlockCard.Controllers
{
    [Route("api/[controller]")]
    public class RepositoryController : Controller
    {
        private ResourceManager ResourceManager => _resourceManager = _resourceManager ??
                    new ResourceManager("Resources.resx", Assembly.GetExecutingAssembly());
        private ResourceManager _resourceManager;

        private string[] ApiFullNames => _apiFullNames = _apiFullNames ??
            ResourceManager.GetString("ApiList").Split(';');
        private string[] _apiFullNames;

        private string ApiRoot => _apiRoot = _apiRoot ??
            ResourceManager.GetString("ApiRoot");
        private string _apiRoot;

        [HttpGet("[action]")]
        public IEnumerable<Repository> All()
        {
            var repositories = new SortedDictionary<int, Repository>();
            Parallel.ForEach(ApiFullNames, apiFullName => repositories.Add(Array.IndexOf(ApiFullNames, apiFullName),
                (Repository)Activator.CreateInstance(typeof(Repository), ApiRoot + apiFullName)));
            return repositories.Select(repository => repository.Value);
        }
    }
}
