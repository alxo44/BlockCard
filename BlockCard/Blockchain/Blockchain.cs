namespace Blockchain
{
    public abstract class IBlockchain
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string OrganizationAvatarUrl { get; private set; }
        public string Language { get; private set; }
        public string OpenIssues { get; private set; }
        public string Forks { get; private set; }
        public string Homepage { get; private set; }

        public IBlockchain() => Load();

        public abstract int Rank { get; }

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
}
