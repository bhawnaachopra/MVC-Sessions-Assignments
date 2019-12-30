namespace CustomHtmlHelper
{
    using System.Web.Mvc;

    /// <summary>
    /// Class to create custom html helper
    /// </summary>
    public static class CustomImageHelper
    {
       /// <summary>
       /// Custom ImageFor method
       /// </summary>
       /// <param name="htmlHelper"></param>
       /// <param name="src">Source of image</param>
       /// <param name="alt">Alternate text for image</param>
       /// <param name="height">Height of image</param>
       /// <param name="width">Width of image</param>
       /// <returns>Custom image tag</returns>
       public static MvcHtmlString ImageFor(this HtmlHelper htmlHelper, string src, string alt, string height, string width)
        {
            var tag = new TagBuilder("img");
            tag.MergeAttribute("src", src);
            tag.MergeAttribute("alt", alt);
            tag.MergeAttribute("height", height);
            tag.MergeAttribute("width", width);

            return MvcHtmlString.Create(tag.ToString(TagRenderMode.SelfClosing));

        }
    }
}