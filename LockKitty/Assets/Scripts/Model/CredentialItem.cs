using System;

namespace LockKitty
{
    [Serializable]
    public sealed class CredentialItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }
}