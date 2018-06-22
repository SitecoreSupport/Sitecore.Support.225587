# Sitecore.Support.225587
When CloudSearchProviderIndex indexes are used, the InvalidCastException can appear in logs:
```
37320 11:34:12 ERROR Application error.
Exception: System.InvalidCastException
Message: Unable to cast object of type 'Sitecore.ContentSearch.AbstractSearchFieldConfiguration' to type 'Sitecore.ContentSearch.Azure.CloudSearchFieldConfiguration'.
Source: Sitecore.ContentSearch.Azure
   at Sitecore.ContentSearch.Azure.FieldMaps.CloudFieldMap.GetCloudFieldConfigurationByFieldName(String fieldName)
   at Sitecore.ContentSearch.Azure.CloudFieldNameTranslator.ProcessFieldName(String fieldName, Type fieldType, CultureInfo documentCulture)
   ...
```

## License  
This patch is licensed under the [Sitecore Corporation A/S License for GitHub](https://github.com/sitecoresupport/Sitecore.Support.225587/blob/master/LICENSE).  

## Download  
Downloads are available via [GitHub Releases](https://github.com/sitecoresupport/Sitecore.Support.225587/releases).  
