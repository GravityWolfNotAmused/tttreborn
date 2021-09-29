using Sandbox;

namespace TTTReborn.Events
{
    public partial class TTTEvents
    {
        public static class Settings
        {
            /// <summary>
            /// Triggered when a server settings are changed.
            /// <para>No data is passed to this event.</para>
            /// </summary>
            public static string OnChanged => "tttreborn.settings.changed";

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
