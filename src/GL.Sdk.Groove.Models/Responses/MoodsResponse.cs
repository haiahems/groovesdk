﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GL.Sdk.Groove.Models.Responses
{
    public class MoodsResponse
    {
        public string Culture { get; set; }

        public IEnumerable<CatalogItem> CatalogMoods { get; set; }

        public ErrorModel Error { get; set; }
    }
}