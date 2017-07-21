using Nop.Core.Configuration;

namespace Nop.Plugin.Tax.TaxJar
{
    public class TaxJarSettings : ISettings
    {
        /// <summary>
        /// Gets or sets TaxJar API Token
        /// </summary>
        public string ApiToken { get; set; }

        /// <summary>
        /// Use State or Provice from the table
        /// </summary>
        public string StateProviceTable { get; set; }
    }
}