// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace DancingGoat.Models
{
    public partial class Grinder
    {
        public const string Codename = "grinder";
        public const string MetadataOgDescriptionCodename = "metadata__og_description";
        public const string MetadataMetaTitleCodename = "metadata__meta_title";
        public const string MetadataOgTitleCodename = "metadata__og_title";
        public const string PriceCodename = "price";
        public const string LongDescriptionCodename = "long_description";
        public const string ShortDescriptionCodename = "short_description";
        public const string ManufacturerCodename = "manufacturer";
        public const string MetadataMetaDescriptionCodename = "metadata__meta_description";
        public const string MetadataTwitterSiteCodename = "metadata__twitter_site";
        public const string ProductStatusCodename = "product_status";
        public const string MetadataTwitterImageCodename = "metadata__twitter_image";
        public const string MetadataTwitterCreatorCodename = "metadata__twitter_creator";
        public const string ImageCodename = "image";
        public const string MetadataTwitterTitleCodename = "metadata__twitter_title";
        public const string ProductNameCodename = "product_name";
        public const string MetadataTwitterDescriptionCodename = "metadata__twitter_description";
        public const string UrlPatternCodename = "url_pattern";
        public const string MetadataOgImageCodename = "metadata__og_image";

        public string MetadataOgDescription { get; set; }
        public string MetadataMetaTitle { get; set; }
        public string MetadataOgTitle { get; set; }
        public decimal? Price { get; set; }
        public IRichTextContent LongDescription { get; set; }
        public IRichTextContent ShortDescription { get; set; }
        public string Manufacturer { get; set; }
        public string MetadataMetaDescription { get; set; }
        public string MetadataTwitterSite { get; set; }
        public IEnumerable<TaxonomyTerm> ProductStatus { get; set; }
        public IEnumerable<Asset> MetadataTwitterImage { get; set; }
        public string MetadataTwitterCreator { get; set; }
        public IEnumerable<Asset> Image { get; set; }
        public string MetadataTwitterTitle { get; set; }
        public string ProductName { get; set; }
        public string MetadataTwitterDescription { get; set; }
        public string UrlPattern { get; set; }
        public IEnumerable<Asset> MetadataOgImage { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}