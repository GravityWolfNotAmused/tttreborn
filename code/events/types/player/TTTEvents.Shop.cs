using Sandbox;

namespace TTTReborn.Events
{
    public partial class TTTEvents
    {
        public static class Shop
        {
            /// <summary>
            /// Triggered when a server settings are changed.
            /// <para>No data is passed to this event.</para>
            /// </summary>
            public static string OnChanged => "tttreborn.shop.change";

            /// <summary>
            /// Triggered when a server settings are changed.
            /// <para>No data is passed to this event.</para>
            /// </summary>
            public class OnChangedAttribute : EventAttribute
            {
                public OnChangedAttribute() : base(OnChanged) { }
            }
        }
    }
}
