﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Chunks;
using Microsoft.AspNetCore.Mvc.Razor.Directives;

namespace Orchard.DisplayManagement.Razor
{
    /// <summary>
    /// Use this class to redefine the list of chunks that a razor page will have
    /// out of the box.
    /// </summary>
    public class MvcRazorHost : Microsoft.AspNetCore.Mvc.Razor.MvcRazorHost
    {
        public MvcRazorHost(IChunkTreeCache chunkTreeCache)
            : base(chunkTreeCache)
        {
        }

        public override IReadOnlyList<Chunk> DefaultInheritedChunks
        {
            get
            {
                return base.DefaultInheritedChunks;
            }
        }
    }
}
