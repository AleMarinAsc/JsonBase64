using Javax.Net.Ssl;

namespace JsonBase64.Droid.Helpers
{
    public class BypassHostnameVerifier : Java.Lang.Object, IHostnameVerifier
    {

        public bool Verify(string hostname, ISSLSession session)
        {
            return true;
        }
    }
}
