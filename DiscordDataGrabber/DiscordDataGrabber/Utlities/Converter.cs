﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace DiscordDataGrabber.Utlities
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            // SHITSHITSHIT 
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
