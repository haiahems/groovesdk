﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GL.Sdk.Groove.Client.Formatters
{
    internal class ParametersFormatter
    {
        public static string Format(IEnumerable<string> _array)
        {
            if (_array.Count() == 0 || _array == null || _array.Count() > 10)
                return string.Empty;

            return string.Join("+", _array);
        }
    }
}
