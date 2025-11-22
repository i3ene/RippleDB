namespace Engine.Core.Model
{
	/// <summary>
	/// Document
	/// </summary>
	public class Puddle
	{
        /// <summary>
        /// ID
        /// </summary>
        public static ulong LastIsotope = 0;

        public readonly ulong IceAge;
        public readonly ulong Isotope;

		public Puddle() : this(Epoch.LastIceAge) { }

        public Puddle(ulong iceAge)
		{
			IceAge = iceAge;
            Isotope = ++LastIsotope;
        }
	}
}
