﻿using System;
using System.Collections.Generic;
using Smartstore.Utilities;
using Smartstore.Web.Modelling;

namespace Smartstore.Admin.Models.Common
{
    [LocalizedDisplay("Admin.System.SystemInfo.")]
    public class SystemInfoModel : ModelBase
    {
        [LocalizedDisplay("*ASPNETInfo")]
        public string AspNetInfo { get; set; }

        [LocalizedDisplay("*AppVersion")]
        public string AppVersion { get; set; }

        [LocalizedDisplay("*AppDate")]
        public DateTime AppDate { get; set; }

        [LocalizedDisplay("*OperatingSystem")]
        public string OperatingSystem { get; set; }

        [LocalizedDisplay("*ServerLocalTime")]
        public DateTime ServerLocalTime { get; set; }

        [LocalizedDisplay("*ServerTimeZone")]
        public string ServerTimeZone { get; set; }

        [LocalizedDisplay("*UTCTime")]
        public DateTime UtcTime { get; set; }

        [LocalizedDisplay("*HTTPHOST")]
        public string HttpHost { get; set; }

        [LocalizedDisplay("*LoadedAssemblies")]
        public List<LoadedAssembly> LoadedAssemblies { get; set; } = new();

        [LocalizedDisplay("*DatabaseSize")]
        public long DatabaseSize { get; set; }
        public string DatabaseSizeString => (DatabaseSize == 0 ? string.Empty : Prettifier.HumanizeBytes(DatabaseSize));

        [LocalizedDisplay("*UsedMemorySize")]
        public long UsedMemorySize { get; set; }
        public string UsedMemorySizeString => Prettifier.HumanizeBytes(UsedMemorySize);

        [LocalizedDisplay("*DataProviderFriendlyName")]
        public string DataProviderFriendlyName { get; set; }

        public bool ShrinkDatabaseEnabled { get; set; }

        public IDictionary<string, long> MemoryCacheStats { get; set; }

        public class LoadedAssembly : ModelBase
        {
            public string FullName { get; set; }
            public string Location { get; set; }
        }

    }
}