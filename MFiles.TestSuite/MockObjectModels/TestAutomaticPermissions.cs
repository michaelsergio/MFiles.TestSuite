﻿using System;
using MFiles.VaultJsonTools.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestAutomaticPermissions : AutomaticPermissions
    {
        public TestAutomaticPermissions() {}

        public TestAutomaticPermissions(xAutomaticPermissions automaticPermissions)
        {
            if (automaticPermissions == null)
                return;
            this.CanDeactivate = automaticPermissions.CanDeactivate;
            this.IsBasedOnObjectACL = automaticPermissions.IsBasedOnObjectACL;
            this.IsDefault = automaticPermissions.IsDefault;
            this.NamedACL = new TestNamedACL(automaticPermissions.NamedACL);
        }

        public bool CanDeactivate { get; set; }

        public AutomaticPermissions Clone()
        {
            throw new NotImplementedException();
        }

        public bool IsBasedOnObjectACL { get; set; }

        public bool IsDefault { get; set; }

        public NamedACL NamedACL { get; set; }

        public void SetBasedOnObjectACL()
        {
            throw new NotImplementedException();
        }

        public void SetNamedACL(NamedACL NamedACL)
        {
            throw new NotImplementedException();
        }
    }
}
