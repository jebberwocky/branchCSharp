using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Branch
{
    public static class DeepLinkHandler
    {
        public static event Action<string> OnAppDeepLinkEvent = delegate { };

        public static void OnAppDeepLink(string url)
        {
            OnAppDeepLinkEvent.Invoke(url);
        }
    }
}
