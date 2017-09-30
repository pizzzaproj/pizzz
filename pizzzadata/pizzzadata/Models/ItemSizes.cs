﻿using System;
using System.Collections.Generic;

namespace pizzzadata.Models
{
    public partial class ItemSizes
    {
        public ItemSizes()
        {
            MenuItemPrice = new HashSet<MenuItemPrice>();
        }

        public int SizeId { get; set; }
        public string Size { get; set; }

        public ICollection<MenuItemPrice> MenuItemPrice { get; set; }
    }
}
