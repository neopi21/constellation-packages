//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ForecastIO
{
    
    
    /// <summary>
    /// The ForecastIOConfigurationSection Configuration Section.
    /// </summary>
    public partial class ForecastIOConfigurationSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the ForecastIOConfigurationSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string ForecastIOConfigurationSectionSectionName = "forecastIOConfigurationSection";
        
        /// <summary>
        /// Gets the ForecastIOConfigurationSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public static global::ForecastIO.ForecastIOConfigurationSection Instance
        {
            get
            {
                return ((global::ForecastIO.ForecastIOConfigurationSection)(global::System.Configuration.ConfigurationManager.GetSection(global::ForecastIO.ForecastIOConfigurationSection.ForecastIOConfigurationSectionSectionName)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ForecastIO.ForecastIOConfigurationSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::ForecastIO.ForecastIOConfigurationSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region RefreshInterval Property
        /// <summary>
        /// The XML name of the <see cref="RefreshInterval"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string RefreshIntervalPropertyName = "refreshInterval";
        
        /// <summary>
        /// Gets or sets the RefreshInterval.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The RefreshInterval.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ForecastIO.ForecastIOConfigurationSection.RefreshIntervalPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue="01:00:00")]
        public virtual global::System.TimeSpan RefreshInterval
        {
            get
            {
                return ((global::System.TimeSpan)(base[global::ForecastIO.ForecastIOConfigurationSection.RefreshIntervalPropertyName]));
            }
            set
            {
                base[global::ForecastIO.ForecastIOConfigurationSection.RefreshIntervalPropertyName] = value;
            }
        }
        #endregion
        
        #region ApiKey Property
        /// <summary>
        /// The XML name of the <see cref="ApiKey"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string ApiKeyPropertyName = "apiKey";
        
        /// <summary>
        /// Gets or sets the ApiKey.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The ApiKey.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ForecastIO.ForecastIOConfigurationSection.ApiKeyPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string ApiKey
        {
            get
            {
                return ((string)(base[global::ForecastIO.ForecastIOConfigurationSection.ApiKeyPropertyName]));
            }
            set
            {
                base[global::ForecastIO.ForecastIOConfigurationSection.ApiKeyPropertyName] = value;
            }
        }
        #endregion
        
        #region Language Property
        /// <summary>
        /// The XML name of the <see cref="Language"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string LanguagePropertyName = "language";
        
        /// <summary>
        /// Gets or sets the Language.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Language.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ForecastIO.ForecastIOConfigurationSection.LanguagePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::ForecastIO.Language? Language
        {
            get
            {
                return ((global::ForecastIO.Language?)(base[global::ForecastIO.ForecastIOConfigurationSection.LanguagePropertyName]));
            }
            set
            {
                base[global::ForecastIO.ForecastIOConfigurationSection.LanguagePropertyName] = value;
            }
        }
        #endregion
        
        #region Unit Property
        /// <summary>
        /// The XML name of the <see cref="Unit"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string UnitPropertyName = "unit";
        
        /// <summary>
        /// Gets or sets the Unit.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Unit.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ForecastIO.ForecastIOConfigurationSection.UnitPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue=Unit.auto)]
        public virtual global::ForecastIO.Unit Unit
        {
            get
            {
                return ((global::ForecastIO.Unit)(base[global::ForecastIO.ForecastIOConfigurationSection.UnitPropertyName]));
            }
            set
            {
                base[global::ForecastIO.ForecastIOConfigurationSection.UnitPropertyName] = value;
            }
        }
        #endregion
        
        #region Stations Property
        /// <summary>
        /// The XML name of the <see cref="Stations"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string StationsPropertyName = "stations";
        
        /// <summary>
        /// Gets or sets the Stations.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Stations.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ForecastIO.ForecastIOConfigurationSection.StationsPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual global::ForecastIO.StationsCollection Stations
        {
            get
            {
                return ((global::ForecastIO.StationsCollection)(base[global::ForecastIO.ForecastIOConfigurationSection.StationsPropertyName]));
            }
            set
            {
                base[global::ForecastIO.ForecastIOConfigurationSection.StationsPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace ForecastIO
{
    
    
    /// <summary>
    /// The StationElement Configuration Element.
    /// </summary>
    public partial class StationElement : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ForecastIO.StationElement.NamePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::ForecastIO.StationElement.NamePropertyName]));
            }
            set
            {
                base[global::ForecastIO.StationElement.NamePropertyName] = value;
            }
        }
        #endregion
        
        #region Longitude Property
        /// <summary>
        /// The XML name of the <see cref="Longitude"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string LongitudePropertyName = "longitude";
        
        /// <summary>
        /// Gets or sets the Longitude.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Longitude.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ForecastIO.StationElement.LongitudePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual double Longitude
        {
            get
            {
                return ((double)(base[global::ForecastIO.StationElement.LongitudePropertyName]));
            }
            set
            {
                base[global::ForecastIO.StationElement.LongitudePropertyName] = value;
            }
        }
        #endregion
        
        #region Latitude Property
        /// <summary>
        /// The XML name of the <see cref="Latitude"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string LatitudePropertyName = "latitude";
        
        /// <summary>
        /// Gets or sets the Latitude.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Latitude.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::ForecastIO.StationElement.LatitudePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual double Latitude
        {
            get
            {
                return ((double)(base[global::ForecastIO.StationElement.LatitudePropertyName]));
            }
            set
            {
                base[global::ForecastIO.StationElement.LatitudePropertyName] = value;
            }
        }
        #endregion
    }
}
namespace ForecastIO
{
    
    
    /// <summary>
    /// A collection of StationElement instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::ForecastIO.StationElement), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::ForecastIO.StationsCollection.StationElementPropertyName)]
    public partial class StationsCollection : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::ForecastIO.StationElement"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string StationElementPropertyName = "station";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override string ElementName
        {
            get
            {
                return global::ForecastIO.StationsCollection.StationElementPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::ForecastIO.StationsCollection.StationElementPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::ForecastIO.StationElement)(element)).Name;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::ForecastIO.StationElement"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::ForecastIO.StationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::ForecastIO.StationElement();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::ForecastIO.StationElement"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::ForecastIO.StationElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::ForecastIO.StationElement this[int index]
        {
            get
            {
                return ((global::ForecastIO.StationElement)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::ForecastIO.StationElement"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::ForecastIO.StationElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::ForecastIO.StationElement this[object name]
        {
            get
            {
                return ((global::ForecastIO.StationElement)(base.BaseGet(name)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::ForecastIO.StationElement"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="station">The <see cref="global::ForecastIO.StationElement"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public void Add(global::ForecastIO.StationElement station)
        {
            base.BaseAdd(station);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::ForecastIO.StationElement"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="station">The <see cref="global::ForecastIO.StationElement"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public void Remove(global::ForecastIO.StationElement station)
        {
            base.BaseRemove(this.GetElementKey(station));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::ForecastIO.StationElement"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::ForecastIO.StationElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::ForecastIO.StationElement GetItemAt(int index)
        {
            return ((global::ForecastIO.StationElement)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::ForecastIO.StationElement"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::ForecastIO.StationElement"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::ForecastIO.StationElement GetItemByKey(string name)
        {
            return ((global::ForecastIO.StationElement)(base.BaseGet(((object)(name)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
