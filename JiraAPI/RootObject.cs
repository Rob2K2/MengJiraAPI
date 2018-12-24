using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JiraAPI
{
    public partial class RootObject
    {
        public string Expand { get; set; }
        public Uri Self { get; set; }
        public long Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public AvatarUrls AvatarUrls { get; set; }
        public string ProjectTypeKey { get; set; }
        public bool Simplified { get; set; }
        public string Style { get; set; }
        public bool IsPrivate { get; set; }
    }

    public partial class AvatarUrls
    {
        public Uri The48X48 { get; set; }
        public Uri The24X24 { get; set; }
        public Uri The16X16 { get; set; }
        public Uri The32X32 { get; set; }
    }
}
