using Sandbox;

namespace TTTReborn.Events
{
    public partial class TTTEvents
    {
        public static class Round
        {
            /// <summary>
            /// Triggered on round change.
            /// <para>Event is passed the <see cref="Rounds.BaseRound"/> instance of the round that the game is being changed to.</para>
            /// </summary>
            public static string OnChanged => "tttreborn.round.changed";

            /// <summary>
            /// Triggered on round change.
            /// <para>Event is passed the <see cref="Rounds.BaseRound"/> instance of the round that the game is being changed to.</para>
            /// </summary>
            public class OnChangedAttribute : EventAttribute
            {
                public OnChangedAttribute() : base(OnChanged) { }
            }
        }
    }
}
