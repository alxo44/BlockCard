using Newtonsoft.Json;
using System.Net;

namespace Blockchain
{
    public class Repository
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string OrganizationAvatarUrl { get; private set; }
        public string Language { get; private set; }
        public string OpenIssues { get; private set; }
        public string Forks { get; private set; }
        public string Homepage { get; private set; }

        public Repository(string api)
        {
            string response;
            using (var webClient = new WebClient())
                response = webClient.DownloadString(api);

            var repository = new
            {
                name = default(string),
                description = default(string),
                owner = new { avatar_url = default(string) },
                language = default(string),
                open_issues = default(string),
                forks = default(string),
                homepage = default(string)
            };
            var json = JsonConvert.DeserializeAnonymousType(response, repository);

            Name = json.name;
            Description = json.description;
            OrganizationAvatarUrl = json.owner.avatar_url;
            Language = json.language;
            OpenIssues = json.open_issues;
            Forks = json.forks;
            Homepage = json.homepage;
        }
    }
}
