﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.SDK.Groove.Models.Responses
{
    public class TrackPlaybackResponse
    {
        public string ContentType { get; set; }

        public DateTime ExpiresOn { get; set; }

        public Uri Url { get; set; }

        public ErrorModel Error { get; set; }
    }
}
