﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Settings
{
    public interface IDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
