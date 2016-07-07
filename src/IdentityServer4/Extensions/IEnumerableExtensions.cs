﻿using System.Collections.Generic;
using System.Linq;

namespace IdentityServer4.Extensions
{
    public static class IEnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
        {
            if (list == null)
            {
                return false;
            }

            if (!list.Any())
            {
                return false;
            }

            return true;
        }
    }
}