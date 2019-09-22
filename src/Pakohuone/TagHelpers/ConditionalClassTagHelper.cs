// Source: https://stackoverflow.com/questions/42337101/asp-net-core-tag-helper-for-conditionally-add-class-to-an-element

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Pakohuone.TagHelpers
{
    [HtmlTargetElement(Attributes = ClassPrefix + "*")]
    public class ConditionalClassTagHelper : TagHelper
    {
        private const string ClassPrefix = "conditional-class-";

        private IDictionary<string, bool> classValues;

        [HtmlAttributeName("class")]
        public string CssClass { get; set; }

        [HtmlAttributeName("", DictionaryAttributePrefix = ClassPrefix)]
        public IDictionary<string, bool> ClassValues
        {
            get => classValues ?? 
                (classValues = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase));
            set => classValues = value;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var items = classValues.Where(e => e.Value)
                .Select(e => e.Key)
                .ToList();

            if (!string.IsNullOrEmpty(CssClass))
                items.Insert(0, CssClass);

            if (items.Any())
            {
                var classes = string.Join(" ", items.ToArray());
                output.Attributes.Add("class", classes);
            }
        }
    }
}
