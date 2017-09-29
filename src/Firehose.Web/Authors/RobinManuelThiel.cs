using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RobinManuelThiel : IWorkAtXamarinOrMicrosoft, IFilterMyBlogPosts
    {
        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
                   item.Categories.Where(i => i.Name.Equals("Xamarin", StringComparison.OrdinalIgnoreCase)).Any();
        }

        public string FirstName => "Robin-Manuel";
        public string LastName => "Thiel";
        public string ShortBioOrTagLine => "Technical Evangelist at Microsoft by day, tinker and fiddler by night. Loves everything with a power plug or IP address.";
        public string StateOrRegion => "Munich, Germany";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "einRobby";
        public string GitHubHandle => "robinmanuelthiel";
        public GeoPosition Position => new GeoPosition(48.177622, 11.5912643);
        public Uri WebSite => new Uri("https://pumpingco.de/");
        public string GravatarHash => "1b8fabaa8d66250a7049bdb9ecf44397";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://pumpingco.de/feed/"); }
        }
    }
}
