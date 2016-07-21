﻿using Newtonsoft.Json;

namespace Discord.API.Voice
{
    public class SpeakingParams
    {
        [JsonProperty("speaking")]
        public bool IsSpeaking { get; set; }
        [JsonProperty("delay")]
        public int Delay { get; set; }
    }
}