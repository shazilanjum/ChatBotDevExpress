﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIChatApp.Models
{
    public class ModelParameters
    {
        public int MaxTokens { get; set; }

        public float Temperature { get; set; }

        public float TopP { get; set; }

        public int FrequencyPenalty { get; set; }

        public int PresencePenalty { get; set; }


        public ChatModelSettings ChatModelSettings { get; set; }
        public int ChatModelSettingsID { get; set; }

        public ModelParameters()
        {
            MaxTokens = 150;
            Temperature = 0.7f;
            TopP = 1.0f;
            FrequencyPenalty = 0;
            PresencePenalty = 0;
        }
    }

}
