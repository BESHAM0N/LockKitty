using System;
using System.Collections.Generic;

namespace LockKitty
{
    [Serializable]
    public sealed class CredentialData
    {
        public List<Section> Sections { get; set; }
    }
}