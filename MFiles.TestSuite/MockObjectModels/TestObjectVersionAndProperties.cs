﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestObjectVersionAndProperties : ObjectVersionAndProperties
    {
        private TestPropertyValues properties = new TestPropertyValues();

        public ObjectVersionAndProperties Clone()
        {
            TestObjectVersionAndProperties clone = new TestObjectVersionAndProperties
            {
                Properties = this.Properties.Clone(),
                Vault = this.Vault,
                VersionData = this.VersionData.Clone()
            };
            return clone;
        }

        public ObjVer ObjVer {
	        get { return VersionData.ObjVer; }
        }

        public PropertyValues Properties
        {
            get { return this.properties; }
	        set
	        {
				properties = new TestPropertyValues();
		        foreach( PropertyValue propertyValue in value )
		        {
					TestPropertyValue pval = new TestPropertyValue();
					pval.PropertyDef = propertyValue.PropertyDef;
					pval.TypedValue = propertyValue.Value;
			        this.properties.Add( -1, pval );
		        }
	        }
        }

        public Vault Vault { get; set; }

        public ObjectVersion VersionData { get; set; }
    }
}
