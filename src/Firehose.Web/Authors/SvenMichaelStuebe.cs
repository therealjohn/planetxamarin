﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SvenMichaelStuebe : IAmAMicrosoftMVP, IAmAXamarinMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Sven-Michael";
        public string LastName => "Stübe";
        public string ShortBioOrTagLine => "loves the cross plattform approach and develops some Xamarin plugins. He organizes the Xamarin Pizza & Beer Meetups in Munich.";
        public string StateOrRegion => "Munich, Germany";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "stuebe2k14";

        public Uri WebSite => new Uri("https://smstuebe.de/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://smstuebe.de/feed.xml"); }
        }

        public string GitHubHandle => "smstuebe";
        public string GravatarHash => "08b73d0a58fc120a8cc8dc561d83b3d6";
        public GeoPosition Position => new GeoPosition(48.1373831, 11.5063151);

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}
