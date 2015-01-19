using Framework.Utilities.OgTagManagers.Interfaces;

namespace Framework.Utilities.OgTagManagers.Models.OgImage
{
    public class OgImageType : IOgTag
    {
        /// <summary>
        /// http://en.wikipedia.org/wiki/Internet_media_type
        ///     image/gif: GIF image; Defined in RFC 2045 and RFC 2046
        ///     image/jpeg: JPEG JFIF image; Defined in RFC 2045 and RFC 2046
        ///     image/pjpeg: JPEG JFIF image; Associated with Internet Explorer; Listed in ms775147(v=vs.85) - Progressive JPEG, initiated before global browser support for progressive JPEGs (Microsoft and Firefox).
        ///     image/png: Portable Network Graphics; Registered,[13] Defined in RFC 2083
        ///     image/svg+xml: SVG vector image; Defined in SVG Tiny 1.2 Specification Appendix M
        ///     image/tiff: TIF image;
        ///     image/vnd.djvu: DjVu image and multipage document format.[14]
        ///     image/example: example in documentation, Defined in RFC 4735
        /// </summary>
        public enum MimeType
        {
            Gif,
            Jpeg,
            Pjpeg,
            Png,
            Svg,
            Tiff,
            Vnd,
            Example
        }

        public OgImageType(MimeType type)
        {
            switch (type)
            {
                case MimeType.Gif:
                    Content = "image/gif";
                    break;
                case MimeType.Jpeg:
                    Content = "image/jpeg";
                    break;
                case MimeType.Pjpeg:
                    Content = "image/pjpeg";
                    break;
                case MimeType.Png:
                    Content = "image/png";
                    break;
                case MimeType.Svg:
                    Content = "image/svg+xml";
                    break;
                case MimeType.Tiff:
                    Content = "image/tiff";
                    break;
                case MimeType.Vnd:
                    Content = "image/vnd.djvu";
                    break;
                case MimeType.Example:
                    Content = "image/example";
                    break;
            }
        }

        public string Property
        {
            get { return "og:image:type"; }
        }
        public string Content { get; set; }
    }
}
