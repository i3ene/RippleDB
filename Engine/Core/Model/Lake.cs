using System.Collections.Concurrent;

namespace Engine.Core.Model
{
    /// <summary>
    /// Collection
    /// </summary>
    public class Lake
    {
        public readonly ulong IceAge;
        public readonly string Name;

        public readonly ConcurrentDictionary<ulong, Puddle> Puddles = new();
        public readonly ConcurrentDictionary<ulong, Droplet> Droplets = new();

        public Lake(string name) : this(Epoch.LastIceAge, name) { }

        public Lake(ulong iceAge, string name)
        {
            IceAge = iceAge;
            Name = name;
        }
    }
}
