using System;
using System.Collections.Generic;

namespace LockKitty
{
    [Serializable]
    public sealed class CatsData
    {
        public List<Section> Sections { get; set; }
    }
}