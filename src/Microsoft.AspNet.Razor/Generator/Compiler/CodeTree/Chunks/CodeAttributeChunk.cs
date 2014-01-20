﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Text;

namespace Microsoft.AspNet.Razor.Generator.Compiler
{
    public class CodeAttributeChunk : ChunkBlock
    {
        public string Attribute { get; set; }
        public LocationTagged<string> Prefix { get; set; }
        public LocationTagged<string> Suffix { get; set; }
    }
}