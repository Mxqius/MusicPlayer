using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class UrlChecker
    {
        public static bool UrlCheckerMethod(string Url)
        {
            Uri uriResult;
            bool tryCreateResult = Uri.TryCreate(Url, UriKind.Absolute, out uriResult);
            if (tryCreateResult && uriResult != null)
                // if can create return true
                return true;
            return false;
        }
    }
}
