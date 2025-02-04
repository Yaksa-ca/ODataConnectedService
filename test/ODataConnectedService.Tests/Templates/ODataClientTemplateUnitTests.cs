﻿//----------------------------------------------------------------------------
// <copyright file="ODataClientTemplateUnitTests.cs" company=".NET Foundation">
//      Copyright (c) .NET Foundation and Contributors. All rights reserved.
//      See License.txt in the project root for license information.
// </copyright>
//----------------------------------------------------------------------------

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.OData.Edm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.OData.CodeGen.Templates;

namespace ODataConnectedService.Tests
{

    [TestClass]
    public class ODataClientTemplateUnitTest
    {
        internal class ODataClientTemplateImp : ODataT4CodeGenerator.ODataClientTemplate
        {
            public List<string> CalledActions { get; private set; }

            public List<PropertyOptions> UsedPropertyOptions { get; private set; }

            public ODataClientTemplateImp(ODataT4CodeGenerator.CodeGenerationContext context)
                : base(context)
            {
                this.CalledActions = new List<string>();
                this.UsedPropertyOptions = new List<PropertyOptions>();
            }

            internal override string GlobalPrefix
            {
                get { return "global::"; }
            }

            internal override string SystemTypeTypeName
            {
                get { return "SystemType"; }
            }

            internal override string AbstractModifier
            {
                get { return "AbstractModifier"; }
            }

            internal override string DataServiceActionQueryTypeName
            {
                get { return "DataServiceActionQueryTypeName"; }
            }

            internal override string DataServiceActionQuerySingleOfTStructureTemplate
            {
                get { return "DataServiceActionQuerySingleOfTStructureTemplate"; }
            }

            internal override string DataServiceActionQueryOfTStructureTemplate
            {
                get { return "DataServiceActionQueryOfTStructureTemplate"; }
            }

            internal override string NotifyPropertyChangedModifier
            {
                get { return "NotifyPropertyChanged"; }
            }

            internal override string ClassInheritMarker
            {
                get { return "ClassInherit"; }
            }

            internal override string ParameterSeparator
            {
                get { return "ParameterSeparator"; }
            }

            internal override string KeyParameterSeparator
            {
                get { return "KeyParameterSeparator"; }
            }

            internal override string KeyDictionaryItemSeparator
            {
                get { return "KeyDictionaryItemSeparator"; }
            }

            internal override string SystemNullableStructureTemplate
            {
                get { return "SystemNullable"; }
            }

            internal override string ICollectionOfTStructureTemplate
            {
                get { return "ICollection`1"; }
            }

            internal override string DataServiceCollectionStructureTemplate
            {
                get { return "DataServiceCollection"; }
            }

            internal override string DataServiceQueryStructureTemplate
            {
                get { return "DataServiceQuery"; }
            }

            internal override string DataServiceQuerySingleStructureTemplate
            {
                get { return "DataServiceQuerySingle"; }
            }

            internal override string ObservableCollectionStructureTemplate
            {
                get { return "ObservableCollection"; }
            }

            internal override string ObjectModelCollectionStructureTemplate
            {
                get { return "ObjectModelCollection"; }
            }

            internal override string DataServiceCollectionConstructorParameters
            {
                get { return "PropertyConstructorParameters"; }
            }

            internal override string NewModifier
            {
                get { return "SystemNew"; }
            }

            internal override string GeoTypeInitializePattern
            {
                get { return "GeoTypeInitializePattern"; }
            }

            internal override string ObjectTypeName
            {
                get { return "Object"; }
            }

            internal override string Int32TypeName
            {
                get { return "Int32"; }
            }

            internal override string StringTypeName
            {
                get { return "String"; }
            }

            internal override string BinaryTypeName
            {
                get { return "Binary"; }
            }

            internal override string DecimalTypeName
            {
                get { return "Decimal"; }
            }

            internal override string Int16TypeName
            {
                get { return "Int16"; }
            }

            internal override string SingleTypeName
            {
                get { return "Single"; }
            }

            internal override string BooleanTypeName
            {
                get { return "Boolean"; }
            }

            internal override string DoubleTypeName
            {
                get { return "Double"; }
            }

            internal override string GuidTypeName
            {
                get { return "Guid"; }
            }

            internal override string ByteTypeName
            {
                get { return "Byte"; }
            }

            internal override string Int64TypeName
            {
                get { return "Int64"; }
            }

            internal override string SByteTypeName
            {
                get { return "SByte"; }
            }

            internal override string DataServiceStreamLinkTypeName
            {
                get { return "Stream"; }
            }

            internal override string GeographyTypeName
            {
                get { return "Geography"; }
            }

            internal override string GeographyPointTypeName
            {
                get { return "GeographyPoint"; }
            }

            internal override string GeographyLineStringTypeName
            {
                get { return "GeographyLineString"; }
            }

            internal override string GeographyPolygonTypeName
            {
                get { return "GeographyPolygon"; }
            }

            internal override string GeographyCollectionTypeName
            {
                get { return "GeographyCollection"; }
            }

            internal override string GeographyMultiPolygonTypeName
            {
                get { return "GeographyMultiPolygon"; }
            }

            internal override string GeographyMultiLineStringTypeName
            {
                get { return "GeographyMultiLineString"; }
            }

            internal override string GeographyMultiPointTypeName
            {
                get { return "GeographyMultiPoint"; }
            }

            internal override string GeometryTypeName
            {
                get { return "Geometry"; }
            }

            internal override string GeometryPointTypeName
            {
                get { return "GeometryPoint"; }
            }

            internal override string GeometryLineStringTypeName
            {
                get { return "GeometryLineString"; }
            }

            internal override string GeometryPolygonTypeName
            {
                get { return "GeometryPolygon"; }
            }

            internal override string GeometryCollectionTypeName
            {
                get { return "GeometryCollection"; }
            }

            internal override string GeometryMultiPolygonTypeName
            {
                get { return "GeometryMultiPolygon"; }
            }

            internal override string GeometryMultiLineStringTypeName
            {
                get { return "GeometryMultiLineString"; }
            }

            internal override string GeometryMultiPointTypeName
            {
                get { return "GeometryMultiPoint"; }
            }

            internal override string DateTypeName
            {
                get { return "Date"; }
            }

            internal override string TimeOfDayTypeName
            {
                get { return "TimeOfDay"; }
            }

            internal override string DateTimeOffsetTypeName
            {
                get { return "DateTimeOffset"; }
            }

            internal override string DurationTypeName
            {
                get { return "Duration"; }
            }

            internal override string XmlConvertClassName
            {
                get { return "XmlConvertClassName"; }
            }

            internal override string DictionaryInterfaceName
            {
                get { return "global::System.Collections.Generic.IDictionary<{0}, {1}>"; }
            }

            internal override string DictionaryTypeName
            {
                get { return "global::System.Collections.Generic.Dictionary<{0}, {1}>"; }
            }

            internal override string EnumTypeName
            {
                get { return "EnumTypeName"; }
            }

            internal override HashSet<string> LanguageKeywords
            {
                get
                {
                    return new HashSet<string>(StringComparer.Ordinal)
                    {
                        "abstract", "as", "base", "byte", "bool", "break", "case", "catch", "char", "checked", "class", "const", "continue",
				        "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "for",
				        "foreach", "finally", "fixed", "float", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock",
			            "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public",
				        "readonly", "ref", "return", "sbyte", "sealed", "string", "short", "sizeof", "stackalloc", "static", "struct", "switch",
				        "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "volatile",
				        "void", "while"
                    };
                }
            }

            internal override string FixPattern
            {
                get { return "@{0}"; }
            }

            internal override string EnumUnderlyingTypeMarker
            {
                get { return " : "; }
            }

            internal override string ConstantExpressionConstructorWithType
            {
                get { return "Expression.Constant({0}, typeof({1}))"; }
            }

            internal override string TypeofFormatter
            {
                get { return "typeof({0})"; }
            }

            internal override string UriOperationParameterConstructor
            {
                get { return "new global::Microsoft.OData.Client.UriOperationParameter(\"{0}\", {1})"; }
            }

            internal override string UriEntityOperationParameterConstructor
            {
                get { return "new global::Microsoft.OData.Client.UriEntityOperationParameter(\"{0}\", {1}, {2})";
                }
            }

            internal override string BodyOperationParameterConstructor
            {
                get { return "new global::Microsoft.OData.Client.BodyOperationParameter(\"{0}\", {1})"; }
            }

            internal override string DictionaryConstructor
            {
                get { return "new global::System.Collections.Generic.Dictionary<{0}, {1}>()"; }
            }

            internal override string BaseEntityType
            {
                get { return "global::Microsoft.OData.Client.BaseEntityType"; }
            }

            internal override string OverloadsModifier
            {
                get { return "new "; }
            }

            internal override string ODataVersion
            {
                get { return "global::Microsoft.OData.ODataVersion.V4"; }
            }

            internal override string ParameterDeclarationTemplate
            {
                get { return "ParameterDeclarationTemplate"; }
            }

            internal override string DictionaryItemConstructor
            {
                get { return "DictionaryItemConstructor"; }
            }

            internal override string ContainerPropertyBase
            {
                get { return "DynamicProperties"; }
            }

            internal override string ContainerPropertyAttribute
            {
                get { return "[global::Microsoft.OData.Client.ContainerProperty]"; }
            }

            internal override string PublicAccessModifier => throw new NotImplementedException();

            internal override string InternalAccessModifier => throw new NotImplementedException();

            internal override void WriteFileHeader()
            {
                this.CalledActions.Add("WriteFileHeader()");
            }

            internal override void WriteNamespaceStart(string fullNamespace)
            {
                this.CalledActions.Add("WriteNamespaceStart(" + fullNamespace + ")");
            }

            internal override void WriteClassStartForEntityContainer(string originalContainerName, string containerName, string fixedContainerName, string description)
            {
                this.CalledActions.Add("WriteClassStartForEntityContainer(" + originalContainerName + ", " + containerName + ", " + fixedContainerName + ", " + description + ")");
            }

            internal override void WriteMethodStartForEntityContainerConstructor(string containerName, string fixedContainerName)
            {
                this.CalledActions.Add("WriteMethodStartForEntityContainerConstructor(" + containerName + ", " + fixedContainerName + ")");
            }

            internal override void WriteKeyAsSegmentUrlConvention()
            {
                this.CalledActions.Add("WriteKeyAsSegmentUrlConvention()");
            }

            internal override void WriteInitializeResolveName()
            {

                this.CalledActions.Add("WriteInitializeResolveName()");
            }

            internal override void WriteInitializeResolveType()
            {
                this.CalledActions.Add("WriteInitializeResolveType()");
            }

            internal override void WriteClassEndForEntityContainerConstructor()
            {
                this.CalledActions.Add("WriteClassEndForEntityContainerConstructor()");
            }

            internal override void WriteMethodStartForResolveTypeFromName()
            {
                this.CalledActions.Add("WriteMethodStartForResolveTypeFromName()");
            }

            internal override void WriteResolveNamespace(string typeName, string fullNamespace, string languageDependentNamespace)
            {

                this.CalledActions.Add("WriteResolveNamespace(" + typeName + ", " + fullNamespace + ", " + languageDependentNamespace + ")");
            }

            internal override void WriteMethodEndForResolveTypeFromName()
            {
                this.CalledActions.Add("WriteMethodEndForResolveTypeFromName()");
            }

            internal override void WriteMethodStartForResolveNameFromType(string containerName, string fullNamespace)
            {

                this.CalledActions.Add("WriteMethodStartForResolveNameFromType(" + containerName + ", " + fullNamespace + ")");
            }

            internal override void WriteResolveType(string fullNamespace, string languageDependentNamespace)
            {

                this.CalledActions.Add("WriteResolveType(" + fullNamespace + ", " + languageDependentNamespace + ")");
            }

            internal override void WriteMethodEndForResolveNameFromType(bool modelHasInheritance)
            {

                this.CalledActions.Add("WriteMethodEndForResolveNameFromType(" + modelHasInheritance + ")");
            }

            internal override void WriteContextEntitySetProperty(string entitySetName, string entitySetFixedName, string originalEntitySetName, string entitySetElementTypeName, string description, IDictionary<string, string> revisionAnnotations, bool inContext = true)
            {
                this.CalledActions.Add("WriteContextEntitySetProperty(" + entitySetName + ", " + entitySetFixedName + ", " + originalEntitySetName + ", " + entitySetElementTypeName + ", " + description + ", " + revisionAnnotations + ", " + inContext + ")");
            }

            internal override void WriteContextSingletonProperty(string singletonName, string singletonFixedName, string originalSingletonName, string singletonElementTypeName, string description, IDictionary<string, string> revisionAnnotations, bool inContext = true)
            {
                this.CalledActions.Add("WriteContextsSingletonProperty(" + singletonName + ", " + singletonFixedName + ", " + originalSingletonName + ", " + singletonElementTypeName + ", " + description + ", " + revisionAnnotations + ", " + inContext + ")");
            }

            internal override void WriteContextAddToEntitySetMethod(string entitySetName, string originalEntitySetName, string typeName, string parameterName)
            {
                this.CalledActions.Add("WriteContextAddToEntitySetMethod(" + entitySetName + ", " + originalEntitySetName + ", " + typeName + ", " + parameterName + ")");
            }

            internal override void WriteGeneratedEdmModel(string escapedEdmxString)
            {
                this.CalledActions.Add("WriteGeneratedEdmModel(" + escapedEdmxString + ")");
            }

            internal override void WriteClassEndForEntityContainer()
            {
                this.CalledActions.Add("WriteClassEndForEntityContainer()");
            }

            internal override void WriteSummaryCommentForStructuredType(string typeName, string description)
            {
                this.CalledActions.Add("WriteSummaryCommentForStructuredType(" + typeName + ", " + description + ")");
            }

            internal override void WriteKeyPropertiesCommentAndAttribute(IEnumerable<string> keyProperties, string keyString)
            {
                this.CalledActions.Add("WriteKeyPropertiesCommentAndAttribute(" + string.Join(", ", keyProperties) + ")");
            }

            internal override void WriteEntityTypeAttribute()
            {
                this.CalledActions.Add("WriteEntityTypeAttribute()");
            }

            internal override void WriteEntitySetAttribute(string entitySetName)
            {
                this.CalledActions.Add("WriteEntitySetAttribute(" + entitySetName + ")");
            }

            internal override void WriteEntityHasStreamAttribute()
            {
                this.CalledActions.Add("WriteEntityHasStreamAttribute()");
            }

            internal override void WriteClassStartForStructuredType(string abstractModifier, string typeName, string originalTypeName, string baseTypeName)
            {
                this.CalledActions.Add("WriteClassStartForStructuredType(" + abstractModifier + ", " + typeName + ", " + originalTypeName + ", " + baseTypeName + ")");
            }

            internal override void WriteSummaryCommentForStaticCreateMethod(string typeName)
            {
                this.CalledActions.Add("WriteSummaryCommentForStaticCreateMethod(" + typeName + ")");
            }

            internal override void WriteParameterCommentForStaticCreateMethod(string parameterName, string propertyName)
            {
                this.CalledActions.Add("WriteParameterCommentForStaticCreateMethod(" + parameterName + ", " + propertyName + ")");
            }

            internal override void WriteDeclarationStartForStaticCreateMethod(string typeName, string fixedTypeName)
            {
                this.CalledActions.Add("WriteDeclarationStartForStaticCreateMethod(" + typeName + ", " + fixedTypeName + ")");
            }

            internal override void WriteParameterForStaticCreateMethod(string parameterTypeName, string parameterName, string parameterSeparater)
            {
                this.CalledActions.Add("WriteParameterForStaticCreateMethod(" + parameterTypeName + ", " + parameterName + ", " + parameterSeparater + ")");
            }

            internal override void WriteDeclarationEndForStaticCreateMethod(string typeName, string instanceName)
            {
                this.CalledActions.Add("WriteDeclarationEndForStaticCreateMethod(" + typeName + ", " + instanceName + ")");
            }

            internal override void WriteParameterNullCheckForStaticCreateMethod(string parameterName)
            {
                this.CalledActions.Add("WriteParameterNullCheckForStaticCreateMethod(" + parameterName + ")");
            }

            internal override void WritePropertyValueAssignmentForStaticCreateMethod(string instanceName, string propertyName, string parameterName)
            {
                this.CalledActions.Add("WritePropertyValueAssignmentForStaticCreateMethod(" + instanceName + ", " + propertyName + ", " + parameterName + ")");
            }

            internal override void WriteMethodEndForStaticCreateMethod(string instanceName)
            {
                this.CalledActions.Add("WriteMethodEndForStaticCreateMethod(" + instanceName + ")");
            }

            internal override void WritePropertyForStructuredType(PropertyOptions propertyOptions)
            {
                this.CalledActions.Add("WritePropertyForStructuredType(" + propertyOptions + ")");
                this.UsedPropertyOptions.Add(propertyOptions);
            }

            internal override void WriteINotifyPropertyChangedImplementation()
            {
                this.CalledActions.Add("WriteINotifyPropertyChangedImplementation()");
            }

            internal override void WriteClassEndForStructuredType()
            {
                this.CalledActions.Add("WriteClassEndForStructuredType()");
            }

            internal override void WriteNamespaceEnd()
            {
                this.CalledActions.Add("WriteNamespaceEnd()");
            }

            internal override void WriteEnumFlags()
            {
                this.CalledActions.Add("WriteEnumFlags()");
            }

            internal override void WriteSummaryCommentForEnumType(string enumName, string description)
            {
                this.CalledActions.Add("WriteSummaryCommentForEnumType(" + enumName + ", " + description + ")");
            }

            internal override void WriteEnumDeclaration(string enumName, string originalEnumName, string underlyingType)
            {
                this.CalledActions.Add("WriteEnumDeclaration(" + enumName + ", " + originalEnumName + ", " + underlyingType + ")");
            }

            internal override void WriteMemberForEnumType(string member, string originalMemberName, bool last)
            {
                this.CalledActions.Add("WriteMemberForEnumType(" + member + ", " + originalMemberName + ", " + last + ")");
            }

            internal override void WriteEnumEnd()
            {
                this.CalledActions.Add("WriteEnumEnd()");
            }

            internal override void WritePropertyRootNamespace(string containerName, string fullNamespace)
            {
                this.CalledActions.Add("WritePropertyRootNamespace(" + containerName + ", " + fullNamespace + ")");
            }

            internal override void WriteFunctionImportReturnCollectionResult(string functionName, string originalFunctionName, string returnTypeName, string parameters, string parameterValues, bool isComposable, bool useEntityReference, string description, IDictionary<string, string> revisionAnnotations)
            {
                this.CalledActions.Add("WriteFunctionImportReturnCollectionResult(" + functionName + ", " + originalFunctionName + ", " + returnTypeName + ", " + parameters + ", " + parameterValues + ", " + isComposable + ", " + useEntityReference + ", " + description + ", " + revisionAnnotations + ")");
            }

            internal override void WriteFunctionImportReturnSingleResult(string functionName, string originalFunctionName, string returnTypeName, string returnTypeNameWithSingleSuffix, string parameters, string parameterValues, bool isComposable, bool isReturnEntity, bool useEntityReference, string description, IDictionary<string, string> revisionAnnotations)
            {
                this.CalledActions.Add("WriteFunctionImportReturnSingleResult(" + functionName + ", " + originalFunctionName + ", " + returnTypeName + ", " + returnTypeNameWithSingleSuffix + ", " + parameters + ", " + parameterValues + ", " + isComposable + ", " + useEntityReference + ", " + description + ", " + revisionAnnotations + ")");
            }
            internal override void WriteBoundFunctionInEntityTypeReturnCollectionResult(bool hideBaseMethod, string functionName, string originalFunctionName, string returnTypeName, string parameters, string fullNamespace, string parameterValues, bool isComposable, bool useEntityReference, string description, IDictionary<string, string> revisionAnnotations)
            {
                this.CalledActions.Add("WriteBoundFunctionInEntityTypeReturnCollectionResult(" + hideBaseMethod + ", " + functionName + ", " + originalFunctionName + ", " + returnTypeName + ", " + parameters + ", " + fullNamespace + ", " + parameterValues + ", " + isComposable + ", " + useEntityReference + ", " + description + ", " + revisionAnnotations + ")");
            }

            internal override void WriteBoundFunctionInEntityTypeReturnSingleResult(bool hideBaseMethod, string functionName, string originalFunctionName, string returnTypeName, string returnTypeNameWithSingleSuffix, string parameters, string fullNamespace, string parameterValues, bool isComposable, bool isReturnEntity, bool useEntityReference, string description, IDictionary<string, string> revisionAnnotations)
            {
                this.CalledActions.Add("WriteBoundFunctionInEntityTypeReturnSingleResult(" + hideBaseMethod + ", " + functionName + ", " + originalFunctionName + ", " + returnTypeName + ", " + returnTypeNameWithSingleSuffix + ", " + parameters + ", " + fullNamespace + ", " + parameterValues + ", " + isComposable + ", " + isReturnEntity + ", " + useEntityReference + ", " + description + ", " + revisionAnnotations + ")");
            }

            internal override void WriteActionImport(string actionName, string originalActionName, string returnTypeName, string parameters, string parameterValues, string description, IDictionary<string, string> revisionAnnotations)
            {
                this.CalledActions.Add("WriteActionImport(" + actionName + ", " + originalActionName + ", " + returnTypeName + ", " + parameters + ", " + parameterValues + ", " + description + ", " + revisionAnnotations + ")");
            }

            internal override void WriteBoundActionInEntityType(bool hideBaseMethod, string actionName, string originalActionName, string returnTypeName, string parameters, string fullNamespace, string parameterValues, string description, IDictionary<string, string> revisionAnnotations)
            {
                this.CalledActions.Add("WriteBoundActionInEntityType(" + hideBaseMethod + ", " + actionName + ", " + originalActionName + ", " + returnTypeName + ", " + parameters + ", " + fullNamespace + ", " + parameterValues + ", " + description + ", " + revisionAnnotations + ")");
            }

            internal override void WriteConstructorForSingleType(string singleTypeName, string baseTypeName)
            {
                this.CalledActions.Add("WriteConstructorForSingleType(" + singleTypeName + ", " + baseTypeName + ")");
            }

            internal override void WriteExtensionMethodsStart()
            {
                this.CalledActions.Add("WriteExtensionMethodsStart()");
            }

            internal override void WriteExtensionMethodsEnd()
            {
                this.CalledActions.Add("WriteExtensionMethodsEnd()");
            }

            internal override void WriteByKeyMethods(string entityTypeName, string returnTypeName, IEnumerable<string> keys, string keyParameters, string keyDictionaryItems)
            {
                this.CalledActions.Add("WriteByKeyMethods(" + entityTypeName + ", " + returnTypeName + ", " + string.Join(", ", keys) + ", " + keyParameters + ", " + keyDictionaryItems + ")");
            }

            internal override void WriteCastToMethods(string baseTypeName, string derivedTypeName, string derivedTypeFullName, string returnTypeName)
            {
                this.CalledActions.Add("WriteCastToMethods(" + baseTypeName + ", " + derivedTypeName + ", " + derivedTypeFullName + ", " + returnTypeName + ")");
            }

            internal override void WriteBoundFunctionReturnSingleResultAsExtension(string functionName, string originalFunctionName,
                string boundTypeName, string returnTypeName, string returnTypeNameWithSingleSuffix, string parameters, string fullNamespace, string parameterValues,
                bool isComposable, bool isReturnEntity, bool useEntityReference, string description)
            {
                this.CalledActions.Add("WriteBoundFunctionInSingleTypeReturnSingleResult(" + functionName + ", " + originalFunctionName + ", " + boundTypeName + ", " + returnTypeName + ", " + returnTypeNameWithSingleSuffix + ", " + parameters + ", " + fullNamespace + ", " + parameterValues + ", " + isComposable + ", " + isReturnEntity + ", " + useEntityReference + ", " + description + ")");
            }

            internal override void WriteBoundFunctionReturnCollectionResultAsExtension(string functionName, string originalFunctionName,
                string boundTypeName, string returnTypeName, string parameters, string fullNamespace, string parameterValues,
                bool isComposable, bool useEntityReference, string description)
            {
                this.CalledActions.Add("WriteBoundFunctionInSingleTypeReturnCollectionResult(" + functionName + ", " + originalFunctionName + ", " + boundTypeName + ", " + returnTypeName + ", " + parameters + ", " + fullNamespace + ", " + parameterValues + ", " + isComposable + ", " + useEntityReference + ", " + description + ")");
            }

            internal override void WriteBoundActionAsExtension(string actionName, string originalActionName, string boundTypeName, string returnTypeName, string parameters, string fullNamespace, string parameterValues, string description)
            {
                this.CalledActions.Add("WriteBoundActionAsExtension(" + actionName + ", " + originalActionName + ", " + boundTypeName + ", " + returnTypeName + ", " + parameters + ", " + fullNamespace + ", " + parameterValues + ", " + description + ")");
            }

            protected override void WriteDescriptionSummary(string description, bool isClass = false)
            {
                // this method is called internally by other language specific write methods
            }

            protected override void WriteObsoleteAttribute(IDictionary<string, string> revisionAnnotations, bool isClass = false)
            {
                // this method is called internally by other language specific write methods
            }
            protected override void WriteStringLengthAttribute(int maxLength, string errorMessage)
            {
                // this method is called internally by other language specific write methods
            }

            protected override void WriteRequiredAttribute(string errorMessage)
            {
                // this method is called internally by other language specific write methods
            }
        }

        private static ODataT4CodeGenerator.CodeGenerationContext Context;

        private Dictionary<IEdmStructuredType, List<IEdmOperation>> boundOperationMap = new Dictionary<IEdmStructuredType, List<IEdmOperation>>();

        private const string OneNamespaceAndEmptyComplexTypeEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string EmptyEntityTypeEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""EntityType"" Abstract=""true"" />
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string EmptyEnumTypeEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EnumType Name=""EnumType""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string FullEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"">
        <Property Name=""Value"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""EnumValue"" Type=""Namespace1.ContentType"" Nullable=""false"" />
      </ComplexType>
      <EnumType Name=""ContentType"" UnderlyingType=""Edm.Int32"" IsFlags=""true"">
          <Member Name=""Liquid""/>
          <Member Name=""Perishable""/>
          <Member Name=""Edible""/>
      </EnumType>
      <EntityType Name=""EntityType"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Guid"" Nullable=""false"" />
        <Property Name=""Complex"" Type=""Namespace1.ComplexType"" Nullable=""true"" />
        <Property Name=""Contents"" Type=""Collection(Namespace1.ContentType)"" Nullable=""false"" />
      </EntityType>
      <EntityContainer Name=""EntityContainer"">
        <EntitySet Name=""Set1"" EntityType=""Namespace1.EntityType"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string EmptyEntityContainerEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityContainer Name=""EntityContainer""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string TwoNamespacesEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityContainer Name=""EntityContainer""/>
    </Schema>
    <Schema Namespace=""Namespace2"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string BasicEntityContainerEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""EntityType""/>
      <EntityContainer Name=""EntityContainer"">
        <EntitySet Name=""Set1"" EntityType=""Namespace1.EntityType"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string ModelHasInheritanceEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""BaseEntityType""/>
      <EntityType Name=""EntityType"" BaseType=""Namespace1.BaseEntityType""/>
      <EntityContainer Name=""EntityContainer""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string AbstractComplexTypeEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"" Abstract=""true""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string ComplexTypeWithPropertyEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"">
        <Property Name=""Value"" Type=""Edm.String"" Nullable=""false"" />
      </ComplexType>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string ComplexTypeWithPropertiesEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"">
        <Property Name=""Name"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""Value"" Type=""Edm.String"" Nullable=""false"" />
      </ComplexType>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        #region Tests for WriteNamespaces

        [TestMethod]
        public void OnlyOneNamespaceShouldCallWriteNamespaceStartJustOnce()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(OneNamespaceAndEmptyComplexTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteNamespaces();
            // Verify WriteNamespaceStart to representing WriteNamepsace
            template.CalledActions.FindAll(act => act == "WriteNamespaceStart(Namespace1)").Count.Should().Be(1);
        }

        [TestMethod]
        public void TwoNamespacesShouldCallWriteNamespaceStartTwice()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(TwoNamespacesEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteNamespaces();
            // Verify WriteNamespaceStart representing WriteNamepsace
            template.CalledActions.FindAll(act => act.StartsWith("WriteNamespaceStart", StringComparison.Ordinal)).Count.Should().Be(2);
        }

        #endregion

        #region Tests for GetFileNameForMultipleFilesGeneration

        private const string SameNamedTypesEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType""/>
      <EnumType Name=""EnumType""/>
      <EntityType Name=""EntityType"" Abstract=""true""/>
    </Schema>
    <Schema Namespace=""Namespace2"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType""/>
      <EnumType Name=""EnumType""/>
      <EntityType Name=""EntityType"" Abstract=""true""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void GetFileNameForMultipleFilesGenerationForSameNamedTypesShouldReturnsFileNamesWithNamespaces()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(SameNamedTypesEdmx, namespacePrefix);
            Context.GenerateMultipleFiles = true;

            ODataClientTemplateImp template;
            foreach (ODataT4CodeGenerator.LanguageOption language in Enum.GetValues(typeof(ODataT4CodeGenerator.LanguageOption)))
            {
                Context.TargetLanguage = language;
                template = new ODataClientTemplateImp(Context);

                IEdmSchemaElement[] schemaElements = Context.GetSchemaElements("Namespace1").ToArray();
                foreach (IEdmSchemaType type in schemaElements.OfType<IEdmSchemaType>())
                {
                    var fileName = template.GetFileNameForMultipleFilesGeneration(type);
                    fileName.Should().StartWith("Namespace1.").And.EndWith(language == ODataT4CodeGenerator.LanguageOption.CSharp ? ".cs" : ".vb");
                }

                schemaElements = Context.GetSchemaElements("Namespace2").ToArray();
                foreach (IEdmSchemaType type in schemaElements.OfType<IEdmSchemaType>())
                {
                    var fileName = template.GetFileNameForMultipleFilesGeneration(type);
                    fileName.Should().StartWith("Namespace2.").And.EndWith(language == ODataT4CodeGenerator.LanguageOption.CSharp ? ".cs" : ".vb");
                }
            }
        }

        [TestMethod]
        public void GetFileNameForMultipleFilesGenerationForSimpleEdmxShouldReturnsFileNamesWithoutNamespaces()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(SimpleEdmx, namespacePrefix);
            Context.GenerateMultipleFiles = true;
            var template = new ODataClientTemplateImp(Context);

            IEdmSchemaElement[] schemaElements = Context.GetSchemaElements("Namespace1").ToArray();
            foreach (IEdmSchemaType type in schemaElements.OfType<IEdmSchemaType>())
            {
                var fileName = template.GetFileNameForMultipleFilesGeneration(type);
                fileName.Should().NotContain("Namespace1.");
            }
        }

        #endregion

        #region Tests for WriteNamespace

        private const string SimpleEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType""/>
      <EnumType Name=""EnumType""/>
      <EntityType Name=""EntityType"" Abstract=""true""/>
      <EntityContainer Name=""EntityContainer""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void OnlyEntityContainerShouldCallWriteEntityContainer()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEntityContainerEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteNamespace("Namespace1");

            var expectedActions = new List<string>
            {
                "WriteNamespaceStart(Namespace1)",
                "WriteClassStartForEntityContainer(EntityContainer, EntityContainer, EntityContainer, )",
                "WriteMethodStartForEntityContainerConstructor(EntityContainer, EntityContainer)",
                "WriteClassEndForEntityContainerConstructor()",
                "WriteGeneratedEdmModel(<edmx:Edmx Version=\"\"4.0\"\" xmlns:edmx=\"\"http://docs.oasis-open.org/odata/ns/edmx\"\">\r\n  <edmx:DataServices>\r\n    <Schema Namespace=\"\"Namespace1\"\" xmlns=\"\"http://docs.oasis-open.org/odata/ns/edm\"\">\r\n      <EntityContainer Name=\"\"EntityContainer\"\" />\r\n    </Schema>\r\n  </edmx:DataServices>\r\n</edmx:Edmx>)",
                "WriteClassEndForEntityContainer()",
                "WriteNamespaceEnd()",
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void OnlyComplexTypeShouldCallWriteComplexType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(OneNamespaceAndEmptyComplexTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteNamespace("Namespace1");

            var expectedActions = new List<string>
            {
                "WriteNamespaceStart(Namespace1)",
                "WriteSummaryCommentForStructuredType(ComplexType, )",
                "WriteClassStartForStructuredType(, ComplexType, ComplexType, )",
                "WriteClassEndForStructuredType()",
                "WriteNamespaceEnd()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void OnlyEnumTypeShouldCallWriteEnumType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEnumTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteNamespace("Namespace1");

            var expectedActions = new List<string>
            {
                "WriteNamespaceStart(Namespace1)",
                "WriteSummaryCommentForEnumType(EnumType, )",
                "WriteEnumDeclaration(EnumType, EnumType, )",
                "WriteEnumEnd()",
                "WriteNamespaceEnd()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void OnlyEntityTypeShouldCallWriteEntityType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEntityTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteNamespace("Namespace1");

            var expectedActions = new List<string>
            {
                "WriteNamespaceStart(Namespace1)",
                "WriteSummaryCommentForStructuredType(EntityTypeSingle, )",
                "WriteClassStartForStructuredType(, EntityTypeSingle, EntityTypeSingle, ClassInheritDataServiceQuerySingle)",
                "WriteConstructorForSingleType(EntityTypeSingle, DataServiceQuerySingle)",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForStructuredType(EntityType, )",
                "WriteEntityTypeAttribute()",
                "WriteClassStartForStructuredType(AbstractModifier, EntityType, EntityType, global::Microsoft.OData.Client.BaseEntityType)",
                "WriteClassEndForStructuredType()",
                "WriteExtensionMethodsStart()",
                "WriteExtensionMethodsEnd()",
                "WriteNamespaceEnd()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void SimpleEdmxShouldCallMethodsInOrder()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(SimpleEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteNamespace("Namespace1");

            var expectedActions = new List<string>
            {
                "WriteNamespaceStart(Namespace1)",
                "WriteClassStartForEntityContainer(EntityContainer, EntityContainer, EntityContainer, )",
                "WriteMethodStartForEntityContainerConstructor(EntityContainer, EntityContainer)",
                "WriteClassEndForEntityContainerConstructor()",
                "WriteGeneratedEdmModel(<edmx:Edmx Version=\"\"4.0\"\" xmlns:edmx=\"\"http://docs.oasis-open.org/odata/ns/edmx\"\">\r\n  <edmx:DataServices>\r\n    <Schema Namespace=\"\"Namespace1\"\" xmlns=\"\"http://docs.oasis-open.org/odata/ns/edm\"\">\r\n      <ComplexType Name=\"\"ComplexType\"\" />\r\n      <EnumType Name=\"\"EnumType\"\" />\r\n      <EntityType Name=\"\"EntityType\"\" Abstract=\"\"true\"\" />\r\n      <EntityContainer Name=\"\"EntityContainer\"\" />\r\n    </Schema>\r\n  </edmx:DataServices>\r\n</edmx:Edmx>)",
                "WriteClassEndForEntityContainer()",
                "WriteSummaryCommentForStructuredType(ComplexType, )",
                "WriteClassStartForStructuredType(, ComplexType, ComplexType, )",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForStructuredType(EntityTypeSingle, )",
                "WriteClassStartForStructuredType(, EntityTypeSingle, EntityTypeSingle, ClassInheritDataServiceQuerySingle)",
                "WriteConstructorForSingleType(EntityTypeSingle, DataServiceQuerySingle)",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForStructuredType(EntityType, )",
                "WriteEntityTypeAttribute()",
                "WriteClassStartForStructuredType(AbstractModifier, EntityType, EntityType, global::Microsoft.OData.Client.BaseEntityType)",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForEnumType(EnumType, )",
                "WriteEnumDeclaration(EnumType, EnumType, )",
                "WriteEnumEnd()",
                "WriteExtensionMethodsStart()",
                "WriteExtensionMethodsEnd()",
                "WriteNamespaceEnd()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        #endregion

        #region Tests for WriteEntityContainer

        private const string EntityContainerUsingDifferentNamespacesEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""EntityType""/>
      <EntityContainer Name=""EntityContainer"">
        <EntitySet Name=""Set1"" EntityType=""Namespace1.EntityType"" />
        <EntitySet Name=""Set2"" EntityType=""Namespace2.EntityType"" />
      </EntityContainer>
    </Schema>
    <Schema Namespace=""Namespace2"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
        <EntityType Name=""EntityType""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void WriteEntityContainerWithOneEntitySet()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(BasicEntityContainerEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var container = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityContainer>().First();
            template.WriteEntityContainer(container, "Namespace1");

            var expectedActions = new List<string>
            {
                "WriteClassStartForEntityContainer(EntityContainer, EntityContainer, EntityContainer, )",
                "WriteMethodStartForEntityContainerConstructor(EntityContainer, EntityContainer)",
                "WriteClassEndForEntityContainerConstructor()",
                "WriteContextEntitySetProperty(Set1, Set1, Set1, EntityType, , System.Collections.Generic.Dictionary`2[System.String,System.String], True)",
                "WriteContextAddToEntitySetMethod(Set1, Set1, EntityType, entityType)",
                "WriteGeneratedEdmModel(<edmx:Edmx Version=\"\"4.0\"\" xmlns:edmx=\"\"http://docs.oasis-open.org/odata/ns/edmx\"\">\r\n  <edmx:DataServices>\r\n    <Schema Namespace=\"\"Namespace1\"\" xmlns=\"\"http://docs.oasis-open.org/odata/ns/edm\"\">\r\n      <EntityType Name=\"\"EntityType\"\" />\r\n      <EntityContainer Name=\"\"EntityContainer\"\">\r\n        <EntitySet Name=\"\"Set1\"\" EntityType=\"\"Namespace1.EntityType\"\" />\r\n      </EntityContainer>\r\n    </Schema>\r\n  </edmx:DataServices>\r\n</edmx:Edmx>)",
                "WriteClassEndForEntityContainer()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEntityContainerWithTwoEntitySetUsingDifferentNamespaces()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EntityContainerUsingDifferentNamespacesEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var container = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityContainer>().First();
            template.WriteEntityContainer(container, "Namespace1");

            var expectedActions = new List<string>
            {
                "WriteClassStartForEntityContainer(EntityContainer, EntityContainer, EntityContainer, )",
                "WriteMethodStartForEntityContainerConstructor(EntityContainer, EntityContainer)",
                "WriteClassEndForEntityContainerConstructor()",
                "WriteContextEntitySetProperty(Set1, Set1, Set1, EntityType, , System.Collections.Generic.Dictionary`2[System.String,System.String], True)",
                "WriteContextEntitySetProperty(Set2, Set2, Set2, global::Namespace2.EntityType, , System.Collections.Generic.Dictionary`2[System.String,System.String], True)",
                "WriteContextAddToEntitySetMethod(Set1, Set1, EntityType, entityType)",
                "WriteContextAddToEntitySetMethod(Set2, Set2, global::Namespace2.EntityType, entityType)",
                "WriteGeneratedEdmModel(<edmx:Edmx Version=\"\"4.0\"\" xmlns:edmx=\"\"http://docs.oasis-open.org/odata/ns/edmx\"\">\r\n  <edmx:DataServices>\r\n    <Schema Namespace=\"\"Namespace1\"\" xmlns=\"\"http://docs.oasis-open.org/odata/ns/edm\"\">\r\n      <EntityType Name=\"\"EntityType\"\" />\r\n      <EntityContainer Name=\"\"EntityContainer\"\">\r\n        <EntitySet Name=\"\"Set1\"\" EntityType=\"\"Namespace1.EntityType\"\" />\r\n        <EntitySet Name=\"\"Set2\"\" EntityType=\"\"Namespace2.EntityType\"\" />\r\n      </EntityContainer>\r\n    </Schema>\r\n    <Schema Namespace=\"\"Namespace2\"\" xmlns=\"\"http://docs.oasis-open.org/odata/ns/edm\"\">\r\n      <EntityType Name=\"\"EntityType\"\" />\r\n    </Schema>\r\n  </edmx:DataServices>\r\n</edmx:Edmx>)",
                "WriteClassEndForEntityContainer()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEntityContainerWithNamesapcePrefixAndOneNamespace()
        {
            var namespacePrefix = "Foo";
            Context = new ODataT4CodeGenerator.CodeGenerationContext(BasicEntityContainerEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var container = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityContainer>().First();
            template.WriteEntityContainer(container, "Namespace1");

            var expectedActions = new List<string>
            {
                "WriteClassStartForEntityContainer(EntityContainer, EntityContainer, EntityContainer, )",
                "WriteMethodStartForEntityContainerConstructor(EntityContainer, EntityContainer)",
                "WriteInitializeResolveName()",
                "WriteInitializeResolveType()",
                "WriteClassEndForEntityContainerConstructor()",
                "WritePropertyRootNamespace(EntityContainer, Foo)",
                "WriteMethodStartForResolveTypeFromName()",
                "WriteResolveNamespace(SystemType , Namespace1, Foo)",
                "WriteMethodEndForResolveTypeFromName()",
                "WriteMethodStartForResolveNameFromType(EntityContainer, Namespace1)",
                "WriteResolveType(Namespace1, Foo)",
                "WriteMethodEndForResolveNameFromType(False)",
                "WriteContextEntitySetProperty(Set1, Set1, Set1, EntityType, , System.Collections.Generic.Dictionary`2[System.String,System.String], True)",
                "WriteContextAddToEntitySetMethod(Set1, Set1, EntityType, entityType)",
                "WriteGeneratedEdmModel(<edmx:Edmx Version=\"\"4.0\"\" xmlns:edmx=\"\"http://docs.oasis-open.org/odata/ns/edmx\"\">\r\n  <edmx:DataServices>\r\n    <Schema Namespace=\"\"Namespace1\"\" xmlns=\"\"http://docs.oasis-open.org/odata/ns/edm\"\">\r\n      <EntityType Name=\"\"EntityType\"\" />\r\n      <EntityContainer Name=\"\"EntityContainer\"\">\r\n        <EntitySet Name=\"\"Set1\"\" EntityType=\"\"Namespace1.EntityType\"\" />\r\n      </EntityContainer>\r\n    </Schema>\r\n  </edmx:DataServices>\r\n</edmx:Edmx>)",
                "WriteClassEndForEntityContainer()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEntityContainerWithNamesapcePrefixAndTwoNamespaces()
        {
            var namespacePrefix = "Foo";
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EntityContainerUsingDifferentNamespacesEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var container = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityContainer>().First();
            template.WriteEntityContainer(container, "Namespace1");

            var expectedActions = new List<string>
            {
                "WriteClassStartForEntityContainer(EntityContainer, EntityContainer, EntityContainer, )",
                "WriteMethodStartForEntityContainerConstructor(EntityContainer, EntityContainer)",
                "WriteInitializeResolveName()",
                "WriteInitializeResolveType()",
                "WriteClassEndForEntityContainerConstructor()",
                "WritePropertyRootNamespace(EntityContainer, Foo.Namespace1)",
                "WriteMethodStartForResolveTypeFromName()",
                "WriteResolveNamespace(SystemType , Namespace1, Foo.Namespace1)",
                "WriteResolveNamespace(, Namespace2, Foo.Namespace2)",
                "WriteMethodEndForResolveTypeFromName()",
                "WriteMethodStartForResolveNameFromType(EntityContainer, Namespace1)",
                "WriteResolveType(Namespace1, Foo.Namespace1)",
                "WriteResolveType(Namespace2, Foo.Namespace2)",
                "WriteMethodEndForResolveNameFromType(False)",
                "WriteContextEntitySetProperty(Set1, Set1, Set1, EntityType, , System.Collections.Generic.Dictionary`2[System.String,System.String], True)",
                "WriteContextEntitySetProperty(Set2, Set2, Set2, global::Foo.Namespace2.EntityType, , System.Collections.Generic.Dictionary`2[System.String,System.String], True)",
                "WriteContextAddToEntitySetMethod(Set1, Set1, EntityType, entityType)",
                "WriteContextAddToEntitySetMethod(Set2, Set2, global::Foo.Namespace2.EntityType, entityType)",
                "WriteGeneratedEdmModel(<edmx:Edmx Version=\"\"4.0\"\" xmlns:edmx=\"\"http://docs.oasis-open.org/odata/ns/edmx\"\">\r\n  <edmx:DataServices>\r\n    <Schema Namespace=\"\"Namespace1\"\" xmlns=\"\"http://docs.oasis-open.org/odata/ns/edm\"\">\r\n      <EntityType Name=\"\"EntityType\"\" />\r\n      <EntityContainer Name=\"\"EntityContainer\"\">\r\n        <EntitySet Name=\"\"Set1\"\" EntityType=\"\"Namespace1.EntityType\"\" />\r\n        <EntitySet Name=\"\"Set2\"\" EntityType=\"\"Namespace2.EntityType\"\" />\r\n      </EntityContainer>\r\n    </Schema>\r\n    <Schema Namespace=\"\"Namespace2\"\" xmlns=\"\"http://docs.oasis-open.org/odata/ns/edm\"\">\r\n      <EntityType Name=\"\"EntityType\"\" />\r\n    </Schema>\r\n  </edmx:DataServices>\r\n</edmx:Edmx>)",
                "WriteClassEndForEntityContainer()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        #endregion

        #region Tests for WriteEntityContainerConstructor

        private const string KeyAsSegmentAnnotationEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityContainer Name=""EntityContainer""/>
      <Annotations Target=""Namespace1.EntityContainer"">
        <Annotation Term=""Com.Microsoft.OData.Service.Conventions.V1.UrlConventions"" String=""KeyAsSegment"" />
      </Annotations>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string KeyAsSegmentAnnotationDefiningDifferentNamespaceEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <Annotations Target=""Namespace2.EntityContainer"">
        <Annotation Term=""Com.Microsoft.OData.Service.Conventions.V1.UrlConventions"" String=""KeyAsSegment"" />
      </Annotations>
    </Schema>
    <Schema Namespace=""Namespace2"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityContainer Name=""EntityContainer""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void WriteEntityContainerConstructorWithoutResolveNameAndType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEntityContainerEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var container = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityContainer>().First();
            template.WriteEntityContainerConstructor(container);

            var expectedActions = new List<string>
            {
                "WriteMethodStartForEntityContainerConstructor(EntityContainer, EntityContainer)",
                "WriteClassEndForEntityContainerConstructor()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEntityContainerConstructorWithResolveNameWithoutResolveType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ModelHasInheritanceEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var container = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityContainer>().First();
            template.WriteEntityContainerConstructor(container);

            var expectedActions = new List<string>
            {
                "WriteMethodStartForEntityContainerConstructor(EntityContainer, EntityContainer)",
                "WriteInitializeResolveName()",
                "WriteClassEndForEntityContainerConstructor()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEntityContainerConstructorWithResolveNameAndResolveType()
        {
            const string namespacePrefix = "NamespacePrefix";
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ModelHasInheritanceEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var container = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityContainer>().First();
            template.WriteEntityContainerConstructor(container);

            var expectedActions = new List<string>
            {
                "WriteMethodStartForEntityContainerConstructor(EntityContainer, EntityContainer)",
                "WriteInitializeResolveName()",
                "WriteInitializeResolveType()",
                "WriteClassEndForEntityContainerConstructor()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEntityContainerConstructorWithKeyAsSegment()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(KeyAsSegmentAnnotationEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var container = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityContainer>().First();
            template.WriteEntityContainerConstructor(container);

            var expectedActions = new List<string>
            {
                "WriteMethodStartForEntityContainerConstructor(EntityContainer, EntityContainer)",
                "WriteKeyAsSegmentUrlConvention()",
                "WriteClassEndForEntityContainerConstructor()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEntityContainerConstructorWithKeyAsSegmentDefiningDifferentNamespace()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(KeyAsSegmentAnnotationDefiningDifferentNamespaceEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var container = Context.GetSchemaElements("Namespace2").OfType<IEdmEntityContainer>().First();
            template.WriteEntityContainerConstructor(container);

            var expectedActions = new List<string>
            {
                "WriteMethodStartForEntityContainerConstructor(EntityContainer, EntityContainer)",
                "WriteKeyAsSegmentUrlConvention()",
                "WriteClassEndForEntityContainerConstructor()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        #endregion

        #region Tests for WriteResolveTypeFromName

        [TestMethod]
        public void NoNeedResolveTypeFromNameShouldReturn()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEntityContainerEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteResolveTypeFromName();
            template.CalledActions.Should().BeEmpty();
        }

        [TestMethod]
        public void NeedResolveTypeFromNameShouldRunInOrder()
        {
            const string namespacePrefix = "NamespacePrefix";
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEntityContainerEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteResolveTypeFromName();

            var expectedActions = new List<string>
            {
                "WriteMethodStartForResolveTypeFromName()",
                "WriteResolveNamespace(SystemType , Namespace1, NamespacePrefix)",
                "WriteMethodEndForResolveTypeFromName()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void NeedResolveTypeFromNameForTwiceShouldRunInOrder()
        {
            const string namespacePrefix = "NamespacePrefix";
            Context = new ODataT4CodeGenerator.CodeGenerationContext(TwoNamespacesEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteResolveTypeFromName();

            var expectedActions = new List<string>
            {
                "WriteMethodStartForResolveTypeFromName()",
                "WriteResolveNamespace(SystemType , Namespace1, NamespacePrefix.Namespace1)",
                "WriteResolveNamespace(, Namespace2, NamespacePrefix.Namespace2)",
                "WriteMethodEndForResolveTypeFromName()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        #endregion

        #region Tests for NeedResolveNameFromType

        [TestMethod]
        public void NoNeedResolveNameFromTypeShouldReturn()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEntityContainerEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteResolveNameFromType("EntityContainer", "Namespace1");
            template.CalledActions.Should().BeEmpty();
        }

        [TestMethod]
        public void NeedResolveNameFromTypeShouldRunInOrder()
        {
            const string namespacePrefix = "NamespacePrefix";
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEntityContainerEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            template.WriteResolveNameFromType("EntityContainer", "Namespace1");

            var expectedActions = new List<string>
            {
                "WriteMethodStartForResolveNameFromType(EntityContainer, Namespace1)",
                "WriteResolveType(Namespace1, NamespacePrefix)",
                "WriteMethodEndForResolveNameFromType(False)"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        #endregion

        #region Tests for WriteEntityType

        private const string EntityTypeHasStreamAttributeEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""EntityType"" HasStream=""true""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string EntityTypeWithPropertyEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""EntityType"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Guid"" Nullable=""false"" />
      </EntityType>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string AbstractEntityTypeWithoutKeyEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""abstractEntityType"" Abstract=""true"">
        <Property Name=""propValue"" Type=""Edm.String"" Nullable=""false"" />
      </EntityType>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string MultipleEntitySetsWithTheSameEntityType = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns:d=""http://docs.oasis-open.org/odata/ns/data"" xmlns:m=""http://docs.oasis-open.org/odata/ns/metadata"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""Customer"">
        <Key>
          <PropertyRef Name=""PersonId"" />
        </Key>
        <Property Name=""PersonId"" Type=""Edm.Int32"" Nullable=""false"" />
      </EntityType>
      <EntityContainer Name=""DefaultContainer"">
        <EntitySet Name=""CustomerSet1"" EntityType=""Namespace1.Customer"" />
        <EntitySet Name=""CustomerSet2"" EntityType=""Namespace1.Customer"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string OneSingleEntitySet = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns:d=""http://docs.oasis-open.org/odata/ns/data"" xmlns:m=""http://docs.oasis-open.org/odata/ns/metadata"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""Customer"">
        <Key>
          <PropertyRef Name=""PersonId"" />
        </Key>
        <Property Name=""PersonId"" Type=""Edm.Int32"" Nullable=""false"" />
      </EntityType>
      <EntityContainer Name=""DefaultContainer"">
        <EntitySet Name=""CustomerSet1"" EntityType=""Namespace1.Customer"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";


        [TestMethod]
        public void WriteAbstractEntityTypeWithoutKey()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(AbstractEntityTypeWithoutKeyEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var entityType = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityType>().First();
            template.WriteEntityType(entityType, boundOperationMap);

            template.CalledActions.Should().NotContain(act => act.StartsWith("WriteKeyPropertiesCommentAndAttribute", StringComparison.Ordinal));
        }

        [TestMethod]
        public void WriteEmptyEntityType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEntityTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var entityType = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityType>().First();
            template.WriteEntityType(entityType, boundOperationMap);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(EntityTypeSingle, )",
                "WriteClassStartForStructuredType(, EntityTypeSingle, EntityTypeSingle, ClassInheritDataServiceQuerySingle)",
                "WriteConstructorForSingleType(EntityTypeSingle, DataServiceQuerySingle)",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForStructuredType(EntityType, )",
                "WriteEntityTypeAttribute()",
                "WriteClassStartForStructuredType(AbstractModifier, EntityType, EntityType, global::Microsoft.OData.Client.BaseEntityType)",
                "WriteClassEndForStructuredType()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEmptyEntityTypeWithUseDataServiceCollection()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEntityTypeEdmx, namespacePrefix) { UseDataServiceCollection = true };
            var template = new ODataClientTemplateImp(Context);
            var entityType = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityType>().First();
            template.WriteEntityType(entityType, boundOperationMap);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(EntityTypeSingle, )",
                "WriteClassStartForStructuredType(, EntityTypeSingle, EntityTypeSingle, ClassInheritDataServiceQuerySingle)",
                "WriteConstructorForSingleType(EntityTypeSingle, DataServiceQuerySingle)",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForStructuredType(EntityType, )",
                "WriteEntityTypeAttribute()",
                "WriteClassStartForStructuredType(AbstractModifier, EntityType, EntityType, global::Microsoft.OData.Client.BaseEntityType, NotifyPropertyChanged)",
                "WriteINotifyPropertyChangedImplementation()",
                "WriteClassEndForStructuredType()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEmptyEntityTypeWithUseDataServiceCollectionAndEntitySet()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(BasicEntityContainerEdmx, namespacePrefix) { UseDataServiceCollection = true };
            var template = new ODataClientTemplateImp(Context);
            var entitySets = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityContainer>().First().EntitySets();
            var entityType = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityType>().First();
            foreach (var edmEntitySet in entitySets)
            {
                List<IEdmNavigationSource> navigationSourceList = null;
                if (!Context.ElementTypeToNavigationSourceMap.TryGetValue(edmEntitySet.EntityType(), out navigationSourceList))
                {
                    navigationSourceList = new List<IEdmNavigationSource>();
                    Context.ElementTypeToNavigationSourceMap.Add(edmEntitySet.EntityType(), navigationSourceList);
                }

                navigationSourceList.Add(edmEntitySet);
            }

            template.WriteEntityType(entityType, boundOperationMap);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(EntityTypeSingle, )",
                "WriteClassStartForStructuredType(, EntityTypeSingle, EntityTypeSingle, ClassInheritDataServiceQuerySingle)",
                "WriteConstructorForSingleType(EntityTypeSingle, DataServiceQuerySingle)",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForStructuredType(EntityType, )",
                "WriteEntityTypeAttribute()",
                "WriteEntitySetAttribute(Set1)",
                "WriteClassStartForStructuredType(, EntityType, EntityType, global::Microsoft.OData.Client.BaseEntityType, NotifyPropertyChanged)",
                "WriteINotifyPropertyChangedImplementation()",
                "WriteClassEndForStructuredType()"
            };

            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEmptyEntityTypeWithHasStreamAttribute()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EntityTypeHasStreamAttributeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var entityType = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityType>().First();
            template.WriteEntityType(entityType, boundOperationMap);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(EntityTypeSingle, )",
                "WriteClassStartForStructuredType(, EntityTypeSingle, EntityTypeSingle, ClassInheritDataServiceQuerySingle)",
                "WriteConstructorForSingleType(EntityTypeSingle, DataServiceQuerySingle)",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForStructuredType(EntityType, )",
                "WriteEntityTypeAttribute()",
                "WriteEntityHasStreamAttribute()",
                "WriteClassStartForStructuredType(, EntityType, EntityType, global::Microsoft.OData.Client.BaseEntityType)",
                "WriteClassEndForStructuredType()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEmptyEntityTypeWithBaseType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ModelHasInheritanceEdmx, namespacePrefix) { UseDataServiceCollection = true };
            var template = new ODataClientTemplateImp(Context);
            var entityType = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityType>().Last();
            template.WriteEntityType(entityType, boundOperationMap);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(EntityTypeSingle, )",
                "WriteClassStartForStructuredType(, EntityTypeSingle, EntityTypeSingle, ClassInheritDataServiceQuerySingle)",
                "WriteConstructorForSingleType(EntityTypeSingle, DataServiceQuerySingle)",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForStructuredType(EntityType, )",
                "WriteEntityTypeAttribute()",
                "WriteClassStartForStructuredType(, EntityType, EntityType, ClassInheritBaseEntityType)",
                "WriteClassEndForStructuredType()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEntityTypeWithProperty()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EntityTypeWithPropertyEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var entityType = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityType>().First();
            template.WriteEntityType(entityType, boundOperationMap);

            Type propertyOptionsType = typeof(ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions);
            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(EntityTypeSingle, )",
                "WriteClassStartForStructuredType(, EntityTypeSingle, EntityTypeSingle, ClassInheritDataServiceQuerySingle)",
                "WriteConstructorForSingleType(EntityTypeSingle, DataServiceQuerySingle)",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForStructuredType(EntityType, )",
                "WriteKeyPropertiesCommentAndAttribute(Id)",
                "WriteClassStartForStructuredType(, EntityType, EntityType, global::Microsoft.OData.Client.BaseEntityType)",
                "WriteSummaryCommentForStaticCreateMethod(EntityType)",
                "WriteParameterCommentForStaticCreateMethod(ID, Id)",
                "WriteDeclarationStartForStaticCreateMethod(EntityType, EntityType)",
                "WriteParameterForStaticCreateMethod(Guid, ID, )",
                "WriteDeclarationEndForStaticCreateMethod(EntityType, entityType)",
                "WritePropertyValueAssignmentForStaticCreateMethod(entityType, Id, ID)",
                "WriteMethodEndForStaticCreateMethod(entityType)",
                $"WritePropertyForStructuredType({propertyOptionsType})",
                "WriteClassEndForStructuredType()"
            };
            template.CalledActions.Should().Equal(expectedActions);

            var expectedUsedPropertyOptions = new List<ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions> {
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "Guid",
                    OriginalPropertyName = "Id",
                    PropertyName = "Id",
                    FixedPropertyName = "Id",
                    PrivatePropertyName = "_Id",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                }
            };
            template.UsedPropertyOptions.Should().Equal(expectedUsedPropertyOptions);
        }

        [TestMethod]
        public void WriteEntityTypeForMoreThanTwoEntitySetsWithTheSameEntityTypeInEntityContainer()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(MultipleEntitySetsWithTheSameEntityType, namespacePrefix) { UseDataServiceCollection = true };
            var template = new ODataClientTemplateImp(Context);
            var entitySets = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityContainer>().First().EntitySets();
            var entityType = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityType>().First();
            foreach (var edmEntitySet in entitySets)
            {
                List<IEdmNavigationSource> navigationSourceList = null;
                if (!Context.ElementTypeToNavigationSourceMap.TryGetValue(edmEntitySet.EntityType(), out navigationSourceList))
                {
                    navigationSourceList = new List<IEdmNavigationSource>();
                    Context.ElementTypeToNavigationSourceMap.Add(edmEntitySet.EntityType(), navigationSourceList);
                }

                navigationSourceList.Add(edmEntitySet);
            }

            template.WriteEntityType(entityType, boundOperationMap);

            Type propertyOptionsType = typeof(ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions);
            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(CustomerSingle, )",
                "WriteClassStartForStructuredType(, CustomerSingle, CustomerSingle, ClassInheritDataServiceQuerySingle)",
                "WriteConstructorForSingleType(CustomerSingle, DataServiceQuerySingle)",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForStructuredType(Customer, )",
                "WriteKeyPropertiesCommentAndAttribute(PersonId)",
                "WriteClassStartForStructuredType(, Customer, Customer, global::Microsoft.OData.Client.BaseEntityType, NotifyPropertyChanged)",
                "WriteSummaryCommentForStaticCreateMethod(Customer)",
                "WriteParameterCommentForStaticCreateMethod(personId, PersonId)",
                "WriteDeclarationStartForStaticCreateMethod(Customer, Customer)",
                "WriteParameterForStaticCreateMethod(Int32, personId, )",
                "WriteDeclarationEndForStaticCreateMethod(Customer, customer)",
                "WritePropertyValueAssignmentForStaticCreateMethod(customer, PersonId, personId)",
                "WriteMethodEndForStaticCreateMethod(customer)",
                $"WritePropertyForStructuredType({propertyOptionsType})",
                "WriteINotifyPropertyChangedImplementation()",
                "WriteClassEndForStructuredType()"
            };
            template.CalledActions.Should().Equal(expectedActions);

            var expectedUsedPropertyOptions = new List<ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions> {
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "Int32",
                    OriginalPropertyName = "PersonId",
                    PropertyName = "PersonId",
                    FixedPropertyName = "PersonId",
                    PrivatePropertyName = "_PersonId",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = true,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                }
            };
            template.UsedPropertyOptions.Should().Equal(expectedUsedPropertyOptions);
        }

        [TestMethod]
        public void WriteEntityTypeForOneEntitySetInEntityContainer()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(OneSingleEntitySet, namespacePrefix) { UseDataServiceCollection = true };
            var template = new ODataClientTemplateImp(Context);
            var entitySets = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityContainer>().First().EntitySets();
            var entityType = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityType>().First();
            foreach (var edmEntitySet in entitySets)
            {
                List<IEdmNavigationSource> navigationSourceList = null;
                if (!Context.ElementTypeToNavigationSourceMap.TryGetValue(edmEntitySet.EntityType(), out navigationSourceList))
                {
                    navigationSourceList = new List<IEdmNavigationSource>();
                    Context.ElementTypeToNavigationSourceMap.Add(edmEntitySet.EntityType(), navigationSourceList);
                }

                navigationSourceList.Add(edmEntitySet);
            }

            template.WriteEntityType(entityType, boundOperationMap);

            Type propertyOptionsType = typeof(ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions);
            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(CustomerSingle, )",
                "WriteClassStartForStructuredType(, CustomerSingle, CustomerSingle, ClassInheritDataServiceQuerySingle)",
                "WriteConstructorForSingleType(CustomerSingle, DataServiceQuerySingle)",
                "WriteClassEndForStructuredType()",
                "WriteSummaryCommentForStructuredType(Customer, )",
                "WriteKeyPropertiesCommentAndAttribute(PersonId)",
                "WriteEntitySetAttribute(CustomerSet1)",
                "WriteClassStartForStructuredType(, Customer, Customer, global::Microsoft.OData.Client.BaseEntityType, NotifyPropertyChanged)",
                "WriteSummaryCommentForStaticCreateMethod(Customer)",
                "WriteParameterCommentForStaticCreateMethod(personId, PersonId)",
                "WriteDeclarationStartForStaticCreateMethod(Customer, Customer)",
                "WriteParameterForStaticCreateMethod(Int32, personId, )",
                "WriteDeclarationEndForStaticCreateMethod(Customer, customer)",
                "WritePropertyValueAssignmentForStaticCreateMethod(customer, PersonId, personId)",
                "WriteMethodEndForStaticCreateMethod(customer)",
                $"WritePropertyForStructuredType({propertyOptionsType})",
                "WriteINotifyPropertyChangedImplementation()",
                "WriteClassEndForStructuredType()"
            };
            template.CalledActions.Should().Equal(expectedActions);

            var expectedUsedPropertyOptions = new List<ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions> {
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "Int32",
                    OriginalPropertyName = "PersonId",
                    PropertyName = "PersonId",
                    FixedPropertyName = "PersonId",
                    PrivatePropertyName = "_PersonId",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = true,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                }
            };
            template.UsedPropertyOptions.Should().Equal(expectedUsedPropertyOptions);
        }
        #endregion

        #region Tests for WriteComplexType

        private const string ComplexTypeWithBaseType = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""BaseComplexType""/>
      <ComplexType Name=""ComplexType"" BaseType=""Namespace1.BaseComplexType""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void WriteEmptyComplexType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(OneNamespaceAndEmptyComplexTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteComplexType(complexType, boundOperationMap);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(ComplexType, )",
                "WriteClassStartForStructuredType(, ComplexType, ComplexType, )",
                "WriteClassEndForStructuredType()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEmptyComplexTypeWithUseDataServiceCollection()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(OneNamespaceAndEmptyComplexTypeEdmx, namespacePrefix)
            {
                UseDataServiceCollection = true
            };
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteComplexType(complexType, boundOperationMap);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(ComplexType, )",
                "WriteClassStartForStructuredType(, ComplexType, ComplexType, ClassInheritNotifyPropertyChanged)",
                "WriteINotifyPropertyChangedImplementation()",
                "WriteClassEndForStructuredType()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteComplexTypeWithBaseType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ComplexTypeWithBaseType, namespacePrefix)
            {
                UseDataServiceCollection = true
            };
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().Last();
            template.WriteComplexType(complexType, boundOperationMap);


            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(ComplexType, )",
                "WriteClassStartForStructuredType(, ComplexType, ComplexType, ClassInheritBaseComplexType)",
                "WriteClassEndForStructuredType()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteComplexTypeWithProperty()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ComplexTypeWithPropertyEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteComplexType(complexType, boundOperationMap);

            Type propertyOptionsType = typeof(ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions);
            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStructuredType(ComplexType, )",
                "WriteClassStartForStructuredType(, ComplexType, ComplexType, )",
                "WriteSummaryCommentForStaticCreateMethod(ComplexType)",
                "WriteParameterCommentForStaticCreateMethod(value, Value)",
                "WriteDeclarationStartForStaticCreateMethod(ComplexType, ComplexType)",
                "WriteParameterForStaticCreateMethod(String, value, )",
                "WriteDeclarationEndForStaticCreateMethod(ComplexType, complexType)",
                "WritePropertyValueAssignmentForStaticCreateMethod(complexType, Value, value)",
                "WriteMethodEndForStaticCreateMethod(complexType)",
                $"WritePropertyForStructuredType({propertyOptionsType})",
                "WriteClassEndForStructuredType()"
            };
            template.CalledActions.Should().Equal(expectedActions);

            var expectedUsedPropertyOptions = new List<ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions> {
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "Value",
                    PropertyName = "Value",
                    FixedPropertyName = "Value",
                    PrivatePropertyName = "_Value",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                }
            };
            template.UsedPropertyOptions.Should().Equal(expectedUsedPropertyOptions);
        }

        #endregion

        #region Tests for WriteEnumType

        private const string EnumTypeWithFlagsEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EnumType Name=""EnumType"" IsFlags=""true""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string EnumTypeWithUnderlyingTypeInt32Edmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EnumType Name=""EnumType"" UnderlyingType=""Edm.Int32""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string EnumTypeWithUnderlyingTypeNotInt32Edmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EnumType Name=""EnumType"" UnderlyingType=""Edm.String""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string EnumTypeWithMemberEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EnumType Name=""ContentType"" UnderlyingType=""Edm.Int32"" IsFlags=""true"">
          <Member Name=""Liquid""/>
      </EnumType>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void WriteEmptyEnumType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEnumTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var enumType = Context.GetSchemaElements("Namespace1").OfType<IEdmEnumType>().First();
            template.WriteEnumType(enumType);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForEnumType(EnumType, )",
                "WriteEnumDeclaration(EnumType, EnumType, )",
                "WriteEnumEnd()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEmptyEnumTypeWithFlags()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EnumTypeWithFlagsEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var enumType = Context.GetSchemaElements("Namespace1").OfType<IEdmEnumType>().First();
            template.WriteEnumType(enumType);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForEnumType(EnumType, )",
                "WriteEnumFlags()",
                "WriteEnumDeclaration(EnumType, EnumType, )",
                "WriteEnumEnd()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEnumTypeWithUnderlyingTypeInt32()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EnumTypeWithUnderlyingTypeInt32Edmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var enumType = Context.GetSchemaElements("Namespace1").OfType<IEdmEnumType>().First();
            template.WriteEnumType(enumType);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForEnumType(EnumType, )",
                "WriteEnumDeclaration(EnumType, EnumType, )",
                "WriteEnumEnd()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEnumTypeWithUnderlyingTypeNotInt32()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EnumTypeWithUnderlyingTypeNotInt32Edmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var enumType = Context.GetSchemaElements("Namespace1").OfType<IEdmEnumType>().First();
            template.WriteEnumType(enumType);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForEnumType(EnumType, )",
                "WriteEnumDeclaration(EnumType, EnumType,  : String)",
                "WriteEnumEnd()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteEnumTypeWithMembers()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EnumTypeWithMemberEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var enumType = Context.GetSchemaElements("Namespace1").OfType<IEdmEnumType>().First();
            template.WriteEnumType(enumType);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForEnumType(ContentType, )",
                "WriteEnumFlags()",
                "WriteEnumDeclaration(ContentType, ContentType, )",
                "WriteMemberForEnumType(Liquid = 0, Liquid, True)",
                "WriteEnumEnd()"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        #endregion

        #region Tests for WriteStructuredTypeDeclaration

        private const string ComplexTypeEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"" Abstract=""true""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string InheritedComplexTypeEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"" BaseType=""Namespace2.BaseComplexType""/>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void WriteEmptyStructuredType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(OneNamespaceAndEmptyComplexTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteStructurdTypeDeclaration(complexType, string.Empty);

            var expectedActions = new List<string>
            {
                "WriteClassStartForStructuredType(, ComplexType, ComplexType, )"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteAbstractModifier()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(AbstractComplexTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteStructurdTypeDeclaration(complexType, string.Empty);

            var expectedActions = new List<string>
            {
                "WriteClassStartForStructuredType(AbstractModifier, ComplexType, ComplexType, )"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteNoBaseTypeStructuredTypeWithUseDataServiceCollection()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(OneNamespaceAndEmptyComplexTypeEdmx, namespacePrefix)
            {
                UseDataServiceCollection = true
            };
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteStructurdTypeDeclaration(complexType, string.Empty);

            var expectedActions = new List<string>
            {
                "WriteClassStartForStructuredType(, ComplexType, ComplexType, ClassInheritNotifyPropertyChanged)"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteStructuredTypeWithSameNamespaceBaseType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ModelHasInheritanceEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var entityType = Context.GetSchemaElements("Namespace1").OfType<IEdmEntityType>().Last();
            template.WriteStructurdTypeDeclaration(entityType, string.Empty);

            var expectedActions = new List<string>
            {
                "WriteClassStartForStructuredType(, EntityType, EntityType, ClassInheritBaseEntityType)"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteStructuredTypeWithDifferentNamespaceBaseType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(InheritedComplexTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteStructurdTypeDeclaration(complexType, string.Empty);

            var expectedActions = new List<string>
            {
                "WriteClassStartForStructuredType(, ComplexType, ComplexType, ClassInheritglobal::Namespace2.BaseComplexType)"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        #endregion

        #region Tests for WriteTypeStaticCreateMethod

        private const string ComplexTypeWithNullablePropertyEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"">
        <Property Name=""Value"" Type=""Edm.String"" Nullable=""true"" />
      </ComplexType>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        private const string ComplexTypeWithCollectionPropertyEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"">
        <Property Name=""Value"" Type=""Collection(Edm.String)"" />
      </ComplexType>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void WriteStaticCreateMethodForAbstractStructuredType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(AbstractComplexTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteTypeStaticCreateMethod("ComplexType", complexType);
            template.CalledActions.Should().BeEmpty();
        }

        [TestMethod]
        public void WriteStaticCreateMethodForEmptyStructuredType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(OneNamespaceAndEmptyComplexTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteTypeStaticCreateMethod("ComplexType", complexType);
            template.CalledActions.Should().BeEmpty();
        }

        [TestMethod]
        public void WriteStaticCreateMethodForStructuredTypeWithProperty()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ComplexTypeWithPropertyEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteTypeStaticCreateMethod("ComplexType", complexType);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStaticCreateMethod(ComplexType)",
                "WriteParameterCommentForStaticCreateMethod(value, Value)",
                "WriteDeclarationStartForStaticCreateMethod(ComplexType, ComplexType)",
                "WriteParameterForStaticCreateMethod(String, value, )",
                "WriteDeclarationEndForStaticCreateMethod(ComplexType, complexType)",
                "WritePropertyValueAssignmentForStaticCreateMethod(complexType, Value, value)",
                "WriteMethodEndForStaticCreateMethod(complexType)"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteStaticCreateMethodForStructuredTypeWithProperties()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ComplexTypeWithPropertiesEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteTypeStaticCreateMethod("ComplexType", complexType);

            var expectedActions = new List<string>
            {
                "WriteSummaryCommentForStaticCreateMethod(ComplexType)",
                "WriteParameterCommentForStaticCreateMethod(name, Name)",
                "WriteParameterCommentForStaticCreateMethod(value, Value)",
                "WriteDeclarationStartForStaticCreateMethod(ComplexType, ComplexType)",
                "WriteParameterForStaticCreateMethod(String, name, , )",
                "WriteParameterForStaticCreateMethod(String, value, )",
                "WriteDeclarationEndForStaticCreateMethod(ComplexType, complexType)",
                "WritePropertyValueAssignmentForStaticCreateMethod(complexType, Name, name)",
                "WritePropertyValueAssignmentForStaticCreateMethod(complexType, Value, value)",
                "WriteMethodEndForStaticCreateMethod(complexType)"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteStaticCreateMethodForStructuredTypeWithNullableProperty()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ComplexTypeWithNullablePropertyEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteTypeStaticCreateMethod("ComplexType", complexType);
            template.CalledActions.Should().BeEmpty();
        }

        [TestMethod]
        public void WriteStaticCreateMethodForStructuredTypeWithCollectionProperty()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ComplexTypeWithCollectionPropertyEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WriteTypeStaticCreateMethod("ComplexType", complexType);
            template.CalledActions.Should().BeEmpty();
        }

        #endregion

        #region Tests for WriteStaticCreateMethodParameters

        private const string ComplexTypeWithMorethan5PropertiesEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"">
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""FirstName"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""MiddleName"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""LastName"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""Age"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Gender"" Type=""Edm.String"" Nullable=""false"" />
      </ComplexType>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void WriteStaticCreateMethodParametersForEmptyStructuredType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(OneNamespaceAndEmptyComplexTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            var propertyToParameterNamePairs = complexType.Properties().Select(p => new KeyValuePair<IEdmProperty, string>(p, p.Name)).ToArray();
            template.WriteStaticCreateMethodParameters(propertyToParameterNamePairs);
            template.CalledActions.Should().BeEmpty();
        }

        [TestMethod]
        public void WriteStaticCreateMethodParametersForStructuredTypeWithProperties()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ComplexTypeWithPropertiesEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            var propertyToParameterNamePairs = complexType.Properties().Select(p => new KeyValuePair<IEdmProperty, string>(p, p.Name)).ToArray();
            template.WriteStaticCreateMethodParameters(propertyToParameterNamePairs);

            var expectedActions = new List<string>
            {
                "WriteParameterForStaticCreateMethod(String, Name, , )",
                "WriteParameterForStaticCreateMethod(String, Value, )"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        [TestMethod]
        public void WriteStaticCreateMethodParametersForStructuredTypeWithMoreThan5Properties()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ComplexTypeWithMorethan5PropertiesEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            var propertyToParameterNamePairs = complexType.Properties().Select(p => new KeyValuePair<IEdmProperty, string>(p, p.Name)).ToArray();
            template.WriteStaticCreateMethodParameters(propertyToParameterNamePairs);

            var expectedActions = new List<string>
            {
                "WriteParameterForStaticCreateMethod(Int32, Id, ParameterSeparator)",
                "WriteParameterForStaticCreateMethod(String, FirstName, ParameterSeparator)",
                "WriteParameterForStaticCreateMethod(String, MiddleName, ParameterSeparator)",
                "WriteParameterForStaticCreateMethod(String, LastName, ParameterSeparator)",
                "WriteParameterForStaticCreateMethod(Int32, Age, ParameterSeparator)",
                "WriteParameterForStaticCreateMethod(String, Gender, )"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        #endregion

        #region Tests for WritePropertiesForStructuredType

        [TestMethod]
        public void WritePropertiesForEmptyStructuredType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(OneNamespaceAndEmptyComplexTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WritePropertiesForStructuredType(complexType);
            template.CalledActions.Should().BeEmpty();
        }

        [TestMethod]
        public void WritePropertiesForStructuredTypeWithProperties()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ComplexTypeWithPropertiesEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WritePropertiesForStructuredType(complexType);

            Type propertyOptionsType = typeof(ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions);
            var expectedActions = new List<string>
            {
                $"WritePropertyForStructuredType({propertyOptionsType})",
                $"WritePropertyForStructuredType({propertyOptionsType})"
            };
            template.CalledActions.Should().Equal(expectedActions);

            var expectedUsedPropertyOptions = new List<ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions> {
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "Name",
                    PropertyName = "Name",
                    FixedPropertyName = "Name",
                    PrivatePropertyName = "_Name",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                },
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "Value",
                    PropertyName = "Value",
                    FixedPropertyName = "Value",
                    PrivatePropertyName = "_Value",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                }
            };
            template.UsedPropertyOptions.Should().Equal(expectedUsedPropertyOptions);
        }

        [TestMethod]
        public void WritePropertiesForStructuredTypeWithPropertyAndUseDataServiceCollection()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(ComplexTypeWithPropertyEdmx, namespacePrefix)
            {
                UseDataServiceCollection = true
            };
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WritePropertiesForStructuredType(complexType);

            Type propertyOptionsType = typeof(ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions);
            var expectedActions = new List<string>
            {
                $"WritePropertyForStructuredType({propertyOptionsType})",
            };
            template.CalledActions.Should().Equal(expectedActions);

            var expectedUsedPropertyOptions = new List<ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions> {
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "Value",
                    PropertyName = "Value",
                    FixedPropertyName = "Value",
                    PrivatePropertyName = "_Value",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = true,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                }
            };
            template.UsedPropertyOptions.Should().Equal(expectedUsedPropertyOptions);
        }

        #endregion

        #region Tests for WriteMembersForEnumType

        private const string EnumTypeWithMembersEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EnumType Name=""ContentType"" UnderlyingType=""Edm.Int32"" IsFlags=""true"">
          <Member Name=""Liquid""/>
          <Member Name=""Perishable""/>
      </EnumType>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void WriteMembersForEmptyEnumType()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EmptyEnumTypeEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var enumType = Context.GetSchemaElements("Namespace1").OfType<IEdmEnumType>().First();
            template.WriteMembersForEnumType(enumType.Members);
            template.CalledActions.Should().BeEmpty();
        }

        [TestMethod]
        public void WriteMembersForEnumTypeWithMembers()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(EnumTypeWithMembersEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var enumType = Context.GetSchemaElements("Namespace1").OfType<IEdmEnumType>().First();
            template.WriteMembersForEnumType(enumType.Members);

            var expectedActions = new List<string>
            {
                "WriteMemberForEnumType(Liquid = 0, Liquid, False)",
                "WriteMemberForEnumType(Perishable = 1, Perishable, True)"
            };
            template.CalledActions.Should().Equal(expectedActions);
        }

        #endregion

        #region Tests for prefix conflict

        private const string PrefixConflictEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
       <ComplexType Name=""ComplexType"">
         <Property Name=""Name"" Type=""Edm.String"" Nullable=""false"" />
         <Property Name=""_Name"" Type=""Edm.String"" Nullable=""false"" />
         <Property Name=""__Name"" Type=""Edm.String"" Nullable=""false"" />
      </ComplexType>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void WritePrefixConfict()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(PrefixConflictEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.WritePropertiesForStructuredType(complexType);

            Type propertyOptionsType = typeof(ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions);
            var expectedActions = new List<string>
            {
                $"WritePropertyForStructuredType({propertyOptionsType})",
                $"WritePropertyForStructuredType({propertyOptionsType})",
                $"WritePropertyForStructuredType({propertyOptionsType})",
            };
            template.CalledActions.Should().Equal(expectedActions);

            var expectedUsedPropertyOptions = new List<ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions> {
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "Name",
                    PropertyName = "Name",
                    FixedPropertyName = "Name",
                    PrivatePropertyName = "_Name1",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                },
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "_Name",
                    PropertyName = "_Name",
                    FixedPropertyName = "_Name",
                    PrivatePropertyName = "__Name1",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                },
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "__Name",
                    PropertyName = "__Name",
                    FixedPropertyName = "__Name",
                    PrivatePropertyName = "___Name",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                }
            };
            template.UsedPropertyOptions.Should().Equal(expectedUsedPropertyOptions);
        }
        #endregion

        #region Tests for Dup Names

        private const string DupNamesEdmx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
       <ComplexType Name=""Name"">
         <Property Name=""Name"" Type=""Edm.String"" Nullable=""false"" />
         <Property Name=""name"" Type=""Edm.String"" Nullable=""false"" />
         <Property Name=""Name1"" Type=""Edm.String"" Nullable=""false"" />
         <Property Name=""_Name2"" Type=""Edm.String"" Nullable=""false"" />
      </ComplexType>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";

        [TestMethod]
        public void WriteDupNames()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(DupNamesEdmx, namespacePrefix);
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.SetPropertyIdentifierMappingsIfNameConflicts(complexType.Name, complexType);
            template.WritePropertiesForStructuredType(complexType);

            Type propertyOptionsType = typeof(ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions);
            var expectedActions = new List<string>
            {
                $"WritePropertyForStructuredType({propertyOptionsType})",
                $"WritePropertyForStructuredType({propertyOptionsType})",
                $"WritePropertyForStructuredType({propertyOptionsType})",
                $"WritePropertyForStructuredType({propertyOptionsType})"
            };
            template.CalledActions.Should().Contain(expectedActions);

            var expectedUsedPropertyOptions = new List<ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions> {
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "Name",
                    PropertyName = "Name2",
                    FixedPropertyName = "Name2",
                    PrivatePropertyName = "_Name21",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                },
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "name",
                    PropertyName = "name",
                    FixedPropertyName = "name",
                    PrivatePropertyName = "_name",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                },
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "Name1",
                    PropertyName = "Name1",
                    FixedPropertyName = "Name1",
                    PrivatePropertyName = "_Name1",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                },
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "_Name2",
                    PropertyName = "_Name2",
                    FixedPropertyName = "_Name2",
                    PrivatePropertyName = "__Name2",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                }
            };
            template.UsedPropertyOptions.Should().Equal(expectedUsedPropertyOptions);
        }

        [TestMethod]
        public void WriteDupNamesWithCamelCase()
        {
            var namespacePrefix = string.Empty;
            Context = new ODataT4CodeGenerator.CodeGenerationContext(DupNamesEdmx, namespacePrefix);
            Context.EnableNamingAlias = true;
            var template = new ODataClientTemplateImp(Context);
            var complexType = Context.GetSchemaElements("Namespace1").OfType<IEdmComplexType>().First();
            template.SetPropertyIdentifierMappingsIfNameConflicts(complexType.Name, complexType);
            template.WritePropertiesForStructuredType(complexType);

            Type propertyOptionsType = typeof(ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions);
            var expectedActions = new List<string>
            {
                $"WritePropertyForStructuredType({propertyOptionsType})",
                $"WritePropertyForStructuredType({propertyOptionsType})",
                $"WritePropertyForStructuredType({propertyOptionsType})",
                $"WritePropertyForStructuredType({propertyOptionsType})"
            };
            template.CalledActions.Should().Contain(expectedActions);

            var expectedUsedPropertyOptions = new List<ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions> {
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "Name",
                    PropertyName = "Name2",
                    FixedPropertyName = "Name2",
                    PrivatePropertyName = "_Name21",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                },
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "name",
                    PropertyName = "Name3",
                    FixedPropertyName = "Name3",
                    PrivatePropertyName = "_Name3",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                },
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "Name1",
                    PropertyName = "Name1",
                    FixedPropertyName = "Name1",
                    PrivatePropertyName = "_Name1",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                },
                new ODataT4CodeGenerator.ODataClientTemplate.PropertyOptions {
                    PropertyType = "String",
                    OriginalPropertyName = "_Name2",
                    PropertyName = "_Name2",
                    FixedPropertyName = "_Name2",
                    PrivatePropertyName = "__Name2",
                    PropertyInitializationValue = null,
                    PropertyAttribute = "",
                    PropertyDescription = null,
                    PropertyMaxLength = null,
                    WriteOnPropertyChanged = false,
                    IsNullable = false,
                    RevisionAnnotations = new ConcurrentDictionary<string, string>()
                }
            };
            template.UsedPropertyOptions.Should().Equal(expectedUsedPropertyOptions);
        }

        #endregion

        [TestMethod]
        public void GetFixedNameShouldReadNonKeywords()
        {
            var template = new ODataClientTemplateImp(new ODataT4CodeGenerator.CodeGenerationContext(FullEdmx, null));
            template.GetFixedName("Name").Should().Be("Name");
        }

        [TestMethod]
        public void FixParameterNameShouldReadKeywords()
        {
            var template = new ODataClientTemplateImp(new ODataT4CodeGenerator.CodeGenerationContext(FullEdmx, null));
            template.GetFixedName("bool").Should().Be("@bool");
        }
    }
}
