using System.Collections.Concurrent;

namespace Engine.Core.Model
{
    /// <summary>
    /// Database
    /// </summary>
    public class Ocean
    {
        public readonly ulong IceAge;
        public readonly string Name;

        public readonly ConcurrentDictionary<string, Lake> Lakes = new();

        public Ocean(string name) : this(Epoch.LastIceAge, name) { }

        public Ocean(ulong iceAge, string name)
        {
            IceAge = iceAge;
            Name = name;
        }
    }
}
