﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOchecklistKyiv.Tests
{
    public class Canonical:Base
    {
        [Test]
        public void GetCanonical()
        {
            All_Pages.GetAllLinks();
            for (int i = 0; i < All_Pages.siteAllLinks.Count; i++)
            {
                try
                {
                    Canonical_Helper.CheckCanonical(All_Pages.siteAllLinks[i].ToString());
                }

                catch
                {
                    continue;
                }
            }
        }
    }
}
