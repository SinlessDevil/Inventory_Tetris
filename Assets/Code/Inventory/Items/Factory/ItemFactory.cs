﻿using Code.Inventory.Items.Data;
using Code.Inventory.Items.Provider;

namespace Code.Inventory.Items.Factory
{
    public class ItemFactory : IItemFactory
    {
        private readonly IItemDataProvider _itemDataProvider;

        public ItemFactory(IItemDataProvider itemDataProvider)
        {
            _itemDataProvider = itemDataProvider;
        }

        public Item Create(string itemId)
        {
            ItemData itemData = _itemDataProvider.ForItemId(itemId);
            Item item = itemData.Item.Clone();

            return item;
        }
    }
}