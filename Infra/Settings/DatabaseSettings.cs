using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Settings
{
    public sealed class DatabaseSettings : IDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
