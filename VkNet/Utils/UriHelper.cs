using System;

namespace VkNet.Utils
{
    public static class UriHelper
    {
        public static string GetLeftPart(this Uri uri, UriPartial uriPartial)
        {
            string result;
            switch (uriPartial)
            {
                case UriPartial.Authority:
                    result = $"{uri.Scheme}://{uri.Authority}";
                    break;
                case UriPartial.Path:
                    throw new NotImplementedException();
                case UriPartial.Query:
                    throw new NotImplementedException();
                case UriPartial.Scheme:
                    throw new NotImplementedException();
                default:
                    throw new ArgumentOutOfRangeException(nameof(uriPartial), uriPartial, null);
            }

            return result;
        }
    }
}