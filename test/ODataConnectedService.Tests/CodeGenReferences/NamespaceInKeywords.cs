//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/10/2015 3:58:08 PM
namespace NamespaceInKeywords.@event.@string.@int
{
    /// <summary>
    /// There are no comments for ComplexType in the schema.
    /// </summary>
    public partial class ComplexType
    {
        /// <summary>
        /// Create a new ComplexType object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static ComplexType CreateComplexType(string value)
        {
            ComplexType complexType = new ComplexType();
            complexType.Value = value;
            return complexType;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public virtual string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
    }
    /// <summary>
    /// There are no comments for TestType1Single in the schema.
    /// </summary>
    public partial class TestType1Single : global::Microsoft.OData.Client.DataServiceQuerySingle<TestType1>
    {
        /// <summary>
        /// Initialize a new TestType1Single object.
        /// </summary>
        public TestType1Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TestType1Single object.
        /// </summary>
        public TestType1Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TestType1Single object.
        /// </summary>
        public TestType1Single(global::Microsoft.OData.Client.DataServiceQuerySingle<TestType1> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TestType1 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// KeyProp
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("KeyProp")]
    public partial class TestType1 : global::Microsoft.OData.Client.BaseEntityType
    {
        /// <summary>
        /// Create a new TestType1 object.
        /// </summary>
        /// <param name="keyProp">Initial value of KeyProp.</param>
        /// <param name="valueProp">Initial value of ValueProp.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static TestType1 CreateTestType1(int keyProp, string valueProp)
        {
            TestType1 testType1 = new TestType1();
            testType1.KeyProp = keyProp;
            testType1.ValueProp = valueProp;
            return testType1;
        }
        /// <summary>
        /// There are no comments for Property KeyProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public virtual int KeyProp
        {
            get
            {
                return this._KeyProp;
            }
            set
            {
                this.OnKeyPropChanging(value);
                this._KeyProp = value;
                this.OnKeyPropChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private int _KeyProp;
        partial void OnKeyPropChanging(int value);
        partial void OnKeyPropChanged();
        /// <summary>
        /// There are no comments for Property ValueProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public virtual string ValueProp
        {
            get
            {
                return this._ValueProp;
            }
            set
            {
                this.OnValuePropChanging(value);
                this._ValueProp = value;
                this.OnValuePropChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private string _ValueProp;
        partial void OnValuePropChanging(string value);
        partial void OnValuePropChanged();
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::NamespaceInKeywords.@event.@string.@int.TestType1 as global::NamespaceInKeywords.@event.@string.@int.TestType1Single specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::NamespaceInKeywords.@event.@string.@int.TestType1Single ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::NamespaceInKeywords.@event.@string.@int.TestType1> source, global::System.Collections.Generic.IDictionary<string, object> keys)
        {
            return new global::NamespaceInKeywords.@event.@string.@int.TestType1Single(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::NamespaceInKeywords.@event.@string.@int.TestType1 as global::NamespaceInKeywords.@event.@string.@int.TestType1Single specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keyProp">The value of keyProp</param>
        public static global::NamespaceInKeywords.@event.@string.@int.TestType1Single ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::NamespaceInKeywords.@event.@string.@int.TestType1> source,
            int keyProp)
        {
            global::System.Collections.Generic.IDictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "KeyProp", keyProp }
            };
            return new global::NamespaceInKeywords.@event.@string.@int.TestType1Single(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}
namespace NamespaceInKeywords.@double
{
    /// <summary>
    /// There are no comments for EntityContainer in the schema.
    /// </summary>
    public partial class EntityContainer : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new EntityContainer object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public EntityContainer(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Set1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::NamespaceInKeywords.@event.@string.@int.TestType1> Set1
        {
            get
            {
                if ((this._Set1 == null))
                {
                    this._Set1 = base.CreateQuery<global::NamespaceInKeywords.@event.@string.@int.TestType1>("Set1");
                }
                return this._Set1;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::NamespaceInKeywords.@event.@string.@int.TestType1> _Set1;
        /// <summary>
        /// There are no comments for Set2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<TestType2> Set2
        {
            get
            {
                if ((this._Set2 == null))
                {
                    this._Set2 = base.CreateQuery<TestType2>("Set2");
                }
                return this._Set2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<TestType2> _Set2;
        /// <summary>
        /// There are no comments for Set1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public virtual void AddToSet1(global::NamespaceInKeywords.@event.@string.@int.TestType1 testType1)
        {
            base.AddObject("Set1", testType1);
        }
        /// <summary>
        /// There are no comments for Set2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public virtual void AddToSet2(TestType2 testType2)
        {
            base.AddObject("Set2", testType2);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""NamespaceInKeywords.event.string.int"" xmlns:d=""http://docs.oasis-open.org/odata/ns/data"" xmlns:m=""http://docs.oasis-open.org/odata/ns/metadata"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"">
        <Property Name=""Value"" Type=""Edm.String"" Nullable=""false"" />
      </ComplexType>
      <EntityType Name=""TestType1"">
        <Key>
          <PropertyRef Name=""KeyProp"" />
        </Key>
        <Property Name=""KeyProp"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""ValueProp"" Type=""Edm.String"" Nullable=""false"" />
      </EntityType>
    </Schema>
    <Schema Namespace=""NamespaceInKeywords.double"" xmlns:d=""http://docs.oasis-open.org/odata/ns/data"" xmlns:m=""http://docs.oasis-open.org/odata/ns/metadata"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""TestType2"">
        <Key>
          <PropertyRef Name=""KeyProp"" />
        </Key>
        <Property Name=""KeyProp"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""ValueProp"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""ComplexValueProp"" Type=""NamespaceInKeywords.event.string.int.ComplexType"" Nullable=""false"" />
      </EntityType>
      <EntityContainer Name=""EntityContainer"">
        <EntitySet Name=""Set1"" EntityType=""NamespaceInKeywords.event.string.int.TestType1"" />
        <EntitySet Name=""Set2"" EntityType=""NamespaceInKeywords.double.TestType2"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    global::System.Collections.Generic.IEnumerable<global::Microsoft.OData.Edm.Validation.EdmError> errors;
                    global::Microsoft.OData.Edm.IEdmModel edmModel;

                    if (!global::Microsoft.OData.Edm.Csdl.CsdlReader.TryParse(reader, false, out edmModel, out errors))
                    {
                        global::System.Text.StringBuilder errorMessages = new System.Text.StringBuilder();
                        foreach (var error in errors)
                        {
                            errorMessages.Append(error.ErrorMessage);
                            errorMessages.Append("; ");
                        }

                        throw new global::System.InvalidOperationException(errorMessages.ToString());
                    }

                    return edmModel;
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for TestType2Single in the schema.
    /// </summary>
    public partial class TestType2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<TestType2>
    {
        /// <summary>
        /// Initialize a new TestType2Single object.
        /// </summary>
        public TestType2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TestType2Single object.
        /// </summary>
        public TestType2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TestType2Single object.
        /// </summary>
        public TestType2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<TestType2> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TestType2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// KeyProp
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("KeyProp")]
    public partial class TestType2 : global::Microsoft.OData.Client.BaseEntityType
    {
        /// <summary>
        /// Create a new TestType2 object.
        /// </summary>
        /// <param name="keyProp">Initial value of KeyProp.</param>
        /// <param name="valueProp">Initial value of ValueProp.</param>
        /// <param name="complexValueProp">Initial value of ComplexValueProp.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static TestType2 CreateTestType2(int keyProp, string valueProp, global::NamespaceInKeywords.@event.@string.@int.ComplexType complexValueProp)
        {
            TestType2 testType2 = new TestType2();
            testType2.KeyProp = keyProp;
            testType2.ValueProp = valueProp;
            if ((complexValueProp == null))
            {
                throw new global::System.ArgumentNullException("complexValueProp");
            }
            testType2.ComplexValueProp = complexValueProp;
            return testType2;
        }
        /// <summary>
        /// There are no comments for Property KeyProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public virtual int KeyProp
        {
            get
            {
                return this._KeyProp;
            }
            set
            {
                this.OnKeyPropChanging(value);
                this._KeyProp = value;
                this.OnKeyPropChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private int _KeyProp;
        partial void OnKeyPropChanging(int value);
        partial void OnKeyPropChanged();
        /// <summary>
        /// There are no comments for Property ValueProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public virtual string ValueProp
        {
            get
            {
                return this._ValueProp;
            }
            set
            {
                this.OnValuePropChanging(value);
                this._ValueProp = value;
                this.OnValuePropChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private string _ValueProp;
        partial void OnValuePropChanging(string value);
        partial void OnValuePropChanged();
        /// <summary>
        /// There are no comments for Property ComplexValueProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public virtual global::NamespaceInKeywords.@event.@string.@int.ComplexType ComplexValueProp
        {
            get
            {
                return this._ComplexValueProp;
            }
            set
            {
                this.OnComplexValuePropChanging(value);
                this._ComplexValueProp = value;
                this.OnComplexValuePropChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private global::NamespaceInKeywords.@event.@string.@int.ComplexType _ComplexValueProp;
        partial void OnComplexValuePropChanging(global::NamespaceInKeywords.@event.@string.@int.ComplexType value);
        partial void OnComplexValuePropChanged();
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::NamespaceInKeywords.@double.TestType2 as global::NamespaceInKeywords.@double.TestType2Single specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::NamespaceInKeywords.@double.TestType2Single ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::NamespaceInKeywords.@double.TestType2> source, global::System.Collections.Generic.IDictionary<string, object> keys)
        {
            return new global::NamespaceInKeywords.@double.TestType2Single(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::NamespaceInKeywords.@double.TestType2 as global::NamespaceInKeywords.@double.TestType2Single specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keyProp">The value of keyProp</param>
        public static global::NamespaceInKeywords.@double.TestType2Single ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::NamespaceInKeywords.@double.TestType2> source,
            int keyProp)
        {
            global::System.Collections.Generic.IDictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "KeyProp", keyProp }
            };
            return new global::NamespaceInKeywords.@double.TestType2Single(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}
