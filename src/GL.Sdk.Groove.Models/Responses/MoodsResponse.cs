﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GL.Sdk.Groove.Models.Responses
{
    public class MoodsResponse : ResponseBase
    {
        public IEnumerable<CatalogItem> CatalogMoods { get; set; }
    }
}
