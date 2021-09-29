using Sandbox;

namespace TTTReborn.Events
{
    public partial class TTTEvents
    {
        public static class Inventory
        {
            /// <summary>
            /// Occurs when a item is picked up.
            /// <para>Event is passed the <strong><see cref="Items.ICarriableItem"/></strong> instance of the item picked up.</para>
            /// </summary>
            public static string OnItemPickUp => "tttreborn.player.inventory.pickup";

            /// <summary>
            /// Occurs when a item is picked up.
            /// <para>Event is passed the <strong><see cref="Items.ICarriableItem"/></strong> instance of the item picked up.</para>
            /// </summary>
            public class OnItemPickedUpAttribute : EventAttribute
            {
                public OnItemPickedUpAttribute() : base(OnItemPickUp) { }
            }

            /// <summary>
            /// Occurs when a item is picked up. <strong>ICarriableItem</strong> object that is dropped is passed to this event.
            /// <para>Event is passed the <strong><see cref="Items.ICarriableItem"/></strong> instance of the item picked up.</para>
            /// </summary>
            public static string OnItemDropped => "tttreborn.player.inventory.drop";

            /// <summary>
            /// Occurs when a item is picked up. <strong>ICarriableItem</strong> object that is dropped is passed to this event.
            /// <para>Event is passed the <strong><see cref="Items.ICarriableItem"/></strong> instance of the item picked up.</para>
            /// </summary>
            public class OnItemDroppedAttribute : EventAttribute
            {
                public OnItemDroppedAttribute() : base(OnItemDropped) { }
            }

            /// <summary>
            /// Occurs when the player's inventory is cleared.
            /// <para>No data is passed to this event.</para>
            /// </summary>
            public static string OnClear => "tttreborn.player.inventory.clear";

            /// <summary>
            /// Occurs when the player's inventory is cleared.
            /// <para>No data is passed to this event.</para>
            /// </summary>
            public class OnInventoryClearAttribute : EventAttribute
            {
                public OnInventoryClearAttribute() : base(OnClear) {}
            }
        }
    }
}
