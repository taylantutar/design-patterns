using System.Text;

namespace builder
{
    public class UrlBuilder
    {
        public StringBuilder sbUrl { get; set; }
        public string BaseUrl { get; set; }
        private const string _Delimeter = "/";

        public UrlBuilder(string BaseUrl)
        {
            sbUrl = new StringBuilder();
            this.BaseUrl = BaseUrl;
        }

        public UrlBuilder AddParameter(string parameter)
        {
            if (!string.IsNullOrEmpty(parameter))
            {
                sbUrl.AppendFormat("{0}{1}", _Delimeter, parameter);
            }

            return this;
        }

        public UrlBuilder AddQueryParam(Dictionary<string, string> qParams)
        {
            if (qParams.Keys.Any())
                sbUrl.Append("?");

            foreach (var param in qParams)
            {
                sbUrl.Append(String.Format("{0}={1}&", param.Key, param.Value));
            }

            return this;
        }

        public string Build()
        {
            var qparameter = sbUrl.ToString();

            if (qparameter[^1] == '&')
                qparameter = qparameter[0..(qparameter.Length - 1)];

            var url = $"{this.BaseUrl}{qparameter}";

            return url;
        }
    }
}
