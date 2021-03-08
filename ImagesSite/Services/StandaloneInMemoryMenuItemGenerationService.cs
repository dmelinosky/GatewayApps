using CommonUI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ImagesSite.Services
{
    public class StandaloneInMemoryMenuItemGenerationService : InMemoryMenuItemGenerationService
    {
        public override IEnumerable<MenuItem> GenerateMenuItems()
        {
            var items = base.GenerateMenuItems();

            var standaloneOnlyItems = items.Where(x => x.Link.StartsWith("/images", StringComparison.OrdinalIgnoreCase)).ToList();

            void TrimImage(MenuItem item)
            {
                item.Link = item.Link.Remove(0, "/images".Count());

                if (string.IsNullOrWhiteSpace(item.Link))
                {
                    item.Link = "/";
                }

                foreach (var subItem in item.SubItems)
                {
                    TrimImage(subItem);
                }
            }

            standaloneOnlyItems.ForEach(x => TrimImage(x));

            return standaloneOnlyItems;
        }
    }
}
