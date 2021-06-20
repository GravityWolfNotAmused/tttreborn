using Sandbox;

using TTTReborn.Items;

namespace TTTReborn.Player
{
    public enum BuyError
    {
        None,
        InventoryBlocked,
        NotEnoughCredits
    }

    partial class TTTPlayer
    {
        public BuyError CanBuy(IBuyableItem item)
        {
            if (!item.IsBuyable(this))
            {
                return BuyError.InventoryBlocked;
            }

            if (Credits < item.GetPrice())
            {
                return BuyError.NotEnoughCredits;
            }

            return BuyError.None;
        }

        public void RequestPurchase(IBuyableItem item)
        {
            if (CanBuy(item) == BuyError.None)
            {
                Credits -= item.GetPrice();

                item.Equip(this);

                return;
            }

            Log.Warning($"{GetClientOwner().Name} tried to buy '{item.GetName()}'.");
        }
    }
}