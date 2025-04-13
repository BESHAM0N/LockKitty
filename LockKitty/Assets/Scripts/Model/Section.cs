using System;
using System.Collections.Generic;

namespace LockKitty
{
    [Serializable]
    public sealed class Section
    {   
        public string Id { get; set; }
        public string SectionTitle { get; set; }
        public List<CatButton> Items { get; set; }
    }
}