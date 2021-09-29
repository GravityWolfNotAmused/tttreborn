using Sandbox;

namespace TTTReborn.Events
{
    public partial class TTTEvents
    {
        public static class Player
        {
            /// <summary>
            /// Occurs when a player initialization happens.
            /// <para>No data is passed to this event.</para>
            /// </summary>
            public static string InitialSpawn => "tttreborn.player.initialspawn";

            /// <summary>
            /// Occurs when a player initialization happens.
            /// <para>No data is passed to this event.</para>
            /// </summary>
            public class OnInitialSpawnAttribute : EventAttribute
            {
                public OnInitialSpawnAttribute() : base(InitialSpawn) { }
            }

            /// <summary>
            /// Occurs when a player spawns.
            /// <para>Event is passed the <strong><see cref="TTTReborn.Player.TTTPlayer"/></strong> instance of the player spawned.</para>
            /// </summary>
            public static string Spawned => "tttreborn.player.spawned";

            /// <summary>
            /// Occurs when a player spawns.
            /// <para>Event is passed the <strong><see cref="TTTReborn.Player.TTTPlayer"/></strong> instance of the player spawned.</para>
            /// </summary>
            public class OnPlayerSpawnedAttribute : EventAttribute
            {
                public OnPlayerSpawnedAttribute() : base(Spawned) { }
            }

            /// <summary>
            /// Occurs when a player dies.
            /// <para>Event is passed the <strong><see cref="TTTReborn.Player.TTTPlayer"/></strong> instance of the player who died.</para>
            /// </summary>
            public static string Died => "tttreborn.player.died";

            /// <summary>
            /// Occurs when a player dies.
            /// <para>Event is passed the <strong><see cref="TTTReborn.Player.TTTPlayer"/></strong> instance of the player who died.</para>
            /// </summary>
            public class OnPlayerDiedAttribute : EventAttribute
            {
                public OnPlayerDiedAttribute() : base(Died) { }
            }

            /// <summary>
            /// Occurs when the player's inventory is cleared.
            /// <para>Event is passed the <strong><see cref="TTTReborn.Player.TTTPlayer"/></strong> instance of the player whose role was set.</para>
            /// </summary>
            public static string RoleSelected => "tttreborn.player.role.onselect";

            /// <summary>
            /// Occurs when the player's inventory is cleared.
            /// <para>Event is passed the <strong><see cref="TTTReborn.Player.TTTPlayer"/></strong> instance of the player whose role was set.</para>
            /// </summary>
            public class OnRoleSelectedAttribute : EventAttribute
            {
                public OnRoleSelectedAttribute() : base(RoleSelected) { }
            }

            /// <summary>
            /// Occurs when the player is changed to spectate. <strong>TTTPlayer</strong> is passed to this event.
            /// <para>Event is passed the <strong><see cref="TTTReborn.Player.TTTPlayer"/></strong> instance of the player who was changed to spectate.</para>
            /// </summary>
            public static string OnChangedToSpectate => "tttreborn.player.spectating.change";

            /// <summary>
            /// Occurs when the player is changed to spectate. <strong>TTTPlayer</strong> is passed to this event.
            /// <para>Event is passed the <strong><see cref="TTTReborn.Player.TTTPlayer"/></strong> instance of the player who was changed to spectate.</para>
            /// </summary>
            public class OnChangedToSpectateAttribute : EventAttribute
            {
                public OnChangedToSpectateAttribute() : base(InitialSpawn) { }
            }

            /// <summary>
            /// Occurs when the player takes damage. <strong>TTTPlayer</strong> is passed to this event.
            /// <para>The <strong><see cref="TTTReborn.Player.TTTPlayer"/></strong> instance of the player who took damage.</para>
            /// <para>The <strong><see cref="float"/></strong> of the amount of damage taken.</para>
            /// </summary>
            public static string OnTakeDamage => "tttreborn.player.takedamage";

            /// <summary>
            /// Occurs when the player takes damage. <strong>TTTPlayer</strong> is passed to this event.
            /// <para>The <strong><see cref="TTTReborn.Player.TTTPlayer"/></strong> instance of the player who took damage.</para>
            /// <para>The <strong><see cref="float"/></strong> of the amount of damage taken.</para>
            /// </summary>
            public class OnTakeDamageAttribute : EventAttribute
            {
                public OnTakeDamageAttribute() : base(InitialSpawn) { }
            }
        }
    }
}
