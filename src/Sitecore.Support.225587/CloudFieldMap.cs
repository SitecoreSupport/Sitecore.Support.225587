
namespace Sitecore.Support.ContentSearch.Azure.FieldMaps
{
  using System;
  using System.Collections.Generic;
  using System.Xml;
  using Diagnostics;
  using Sitecore.ContentSearch.Azure;
  using Sitecore.ContentSearch.Azure.FieldMaps;

  public class CloudFieldMap : Sitecore.ContentSearch.Azure.FieldMaps.CloudFieldMap, ICloudFieldMap
  {
    CloudSearchFieldConfiguration ICloudFieldMap.GetCloudFieldConfigurationByFieldName(string fieldName)
    {
      var configuration = this.GetFieldConfiguration(fieldName);
      return configuration as CloudSearchFieldConfiguration;
    }

    public override void AddFieldByFieldName(string fieldName, Type settingType, IDictionary<string, string> attributes, XmlNode configNode)
    {
      base.AddFieldByFieldName(fieldName, settingType, attributes, configNode);

      string cloudFieldName;
      if (!attributes.TryGetValue(CloudSearchFieldConfiguration.CloudFieldNameName, out cloudFieldName))
      {
        cloudFieldName = fieldName;
      }

      var configuration = this.fieldNameMap[fieldName.ToLowerInvariant()] as CloudSearchFieldConfiguration;
      if (configuration != null)
      {
        this.cloudFieldNameMap[cloudFieldName] = configuration;
      }
      else
      {
        Log.Info(string.Format(Texts.WrongFieldConfigurationType, fieldName), this);
      }
    }
  }
}