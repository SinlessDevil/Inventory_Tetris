using System;
using InventorySystem.Abstract;

namespace InventorySystem
{
    public class InventorySlot : IInventorySlot
    {
        public bool IsFull => Amount == Capacity;
        public bool IsEmpty => Item == null;
        public IInventoryItem Item { get; private set; }
        public Type ItemType => Item.Type;
        public int Amount => IsEmpty ? 0 : Item.Amount;
        public int Capacity { get; private set; }

        public void SetItem(IInventoryItem item)
        {
            if (IsEmpty == false)
                return;

            this.Item = item;
            this.Capacity = item.MaxItemsInInventorySlot;
        }
        public void Clear()
        {
            if (IsEmpty == true)
                return;

            Item.Amount = 0;
            Item = null;
        }
    }
}