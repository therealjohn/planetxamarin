﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class TimotheLariviere : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Timothé";
        public string LastName => "Larivière";
        public string ShortBioOrTagLine => "plays with and writes about UWP, Xamarin, and .NET Core";
        public string StateOrRegion => "Paris";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "Tim_Lariviere";
        public string GravatarHash => "b6179a1d616f308a845aa74c43c5f853";
        public string GitHubHandle => "TimLariviere";
        public GeoPosition Position => new GeoPosition(48.8704842, 2.3449646);
        public Uri WebSite => new Uri("http://timothelariviere.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://timothelariviere.com/feed/"); } }

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Contains("xamarin"));
        }
    }
}