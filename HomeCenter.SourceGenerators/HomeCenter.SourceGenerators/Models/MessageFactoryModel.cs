﻿using System.Collections.Generic;

namespace HomeCenter.SourceGenerators
{
    internal record MessageFactoryModel
    {
        public string ClassName { get; set; }

        public string Namespace { get; set; }

        public string ClassModifier { get; set; }

        public List<string> Usings { get; set; } = new List<string>();
    }
}