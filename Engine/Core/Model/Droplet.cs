namespace Engine.Core.Model
{
    /// <summary>
    /// Property
    /// </summary>
    public class Droplet
    {
        /// <summary>
        /// ID
        /// </summary>
        public static ulong LastIsomer = 0;

        public readonly ulong IceAge;
        public readonly ulong Puddle;
        public readonly ulong Isomer;
        public readonly Form Form;

        public Droplet(ulong puddle, Form form) : this(Epoch.LastIceAge, puddle, form) { }

        public Droplet(ulong iceAge, ulong puddle, Form form)
        {
            IceAge = iceAge;
            Puddle = puddle;
            Form = form;
            Isomer = ++LastIsomer;
        }
    }
}
