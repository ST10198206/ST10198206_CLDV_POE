using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ST10198206_CLDV_POE.Data;
using System;
using System.Linq;

namespace ST10198206_CLDV_POE.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ST10198206_CLDV_POEContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ST10198206_CLDV_POEContext>>()))
        {
            // Look for any movies.
            if (context.Item.Any())
            {
                return;   // DB has been seeded
            }
            context.Item.AddRange(
                new Item
                {
                    ItemName = "Handcrafted Wooden Bowl",
                    ItemDescription = "A beautifully handcrafted wooden bowl made from sustainably sourced oak. Perfect for salads, fruits, or as a decorative piece.",
                    ItemPrice = 100,

                },
                new Item
                {
                    ItemName = "Ceramic Coffee Mug",
                    ItemDescription = "A unique ceramic coffee mug with a hand-painted design. Each mug is one-of-a-kind and holds 12 ounces of your favorite beverage.",
                    ItemPrice = 500
                },
                new Item
                {
                    ItemName = "Knitted Wool Scarf",
                    ItemDescription = "Cozy and warm, this knitted wool scarf is made from 100% natural wool. It features a classic cable knit pattern and measures 60 inches in length.",
                    ItemPrice = 600
                },
                new Item
                {
                    ItemName = "Embroidered Pillow Cover",
                    ItemDescription = "A handmade pillow cover featuring intricate embroidery in vibrant colors. Fits a 16x16 inch pillow insert (not included).",
                    ItemPrice = 600
                }
                );
            context.SaveChanges();
        }
    }
}