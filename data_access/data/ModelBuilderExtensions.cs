using data_access.data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(new[]
            {
                new Category { Id = (int)GamesCategories.BattleRoyale, Name = "BattleRoyale"},
                new Category { Id = (int)GamesCategories.Educational, Name = "Educational"},
                new Category { Id = (int)GamesCategories.Multiplayer, Name = "Multiplayer"},
                new Category { Id = (int)GamesCategories.MMORPG, Name = "MMORPG"},
                new Category { Id = (int)GamesCategories.Indie, Name = "Indie"},
                new Category { Id = (int)GamesCategories.Military, Name = "Military"},
                new Category { Id = (int)GamesCategories.Historical, Name = "Historical"},
                new Category { Id = (int)GamesCategories.FPS, Name = "FPS"},
                new Category { Id = (int)GamesCategories.Action, Name = "Action"},
                new Category { Id = (int)GamesCategories.Adventure, Name = "Adventure"},
                new Category { Id = (int)GamesCategories.Anime, Name = "Anime"},
                new Category { Id = (int)GamesCategories.RPG, Name = "RPG"},
                new Category { Id = (int)GamesCategories.BoardGame, Name = "BoardGame"},
                new Category { Id = (int)GamesCategories.Casual, Name = "Casual"},
                new Category { Id = (int)GamesCategories.Comedy, Name = "Comedy"},
                new Category { Id = (int)GamesCategories.Coop, Name = "Coop"},
                new Category { Id = (int)GamesCategories.CardGame, Name = "CardGame"},
                new Category { Id = (int)GamesCategories.Cyberpunk, Name = "Cyberpunk"},
                new Category { Id = (int)GamesCategories.Esports, Name = "Esports"},
                new Category { Id = (int)GamesCategories.FreeToPlay, Name = "FreeToPlay"},
            });
            builder.Entity<Country>().HasData(new[]
            {
                new Country { Id = (int)Countries.Ukraine, Name="Ukraine"},
                new Country { Id = (int)Countries.UnitedStates, Name="UnitedStates"},
                new Country { Id = (int)Countries.India, Name="India"},
                new Country { Id = (int)Countries.UnitedKingdom, Name="UnitedKingdom"},
                new Country { Id = (int)Countries.Canada, Name="Canada"},
                new Country { Id = (int)Countries.Brazil, Name="Brazil"},
                new Country { Id = (int)Countries.Germany, Name="Germany"},
                new Country { Id = (int)Countries.Japan, Name="Japan"},
                new Country { Id = (int)Countries.Mexico, Name="Mexico"},
                new Country { Id = (int)Countries.SouthAfrica, Name="SouthAfrica"},
            });
            builder.Entity<Edition>().HasData(new[]
            {
                new Edition { Id = 1, Name="Dota 2", Description="Doesn't exist!", Price=420, CategoryId = 5, ImgUrl="https://i.pinimg.com/736x/45/c8/7b/45c87b4b7852f71b49f794ab98f6c6a5.jpg", Discount=0},
                new Edition { Id = 2, Name = "FIFA 22", Description = "Football simulation game", Price = 59.99m, CategoryId = 4, ImgUrl = "https://example.com/fifa22.jpg", Discount = 15 },
                new Edition { Id = 3, Name = "Assassin's Creed Valhalla", Description = "Action role-playing game", CategoryId = 3, Price = 49.99m, ImgUrl = "https://example.com/ac_valhalla.jpg", Discount = 10 },
                new Edition { Id = 4, Name = "Minecraft", Description = "Sandbox game", Price = 29.99m, ImgUrl = "https://example.com/minecraft.jpg", CategoryId = 1, Discount = 5 },
                new Edition { Id = 5, Name = "The Witcher 3: Wild Hunt", Description = "Action role-playing game", CategoryId = 2, Price = 39.99m, ImgUrl = "https://example.com/witcher3.jpg", Discount = 20 },
            });
            builder.Entity<Review>().HasData(new[]
            {
                new Review { Id = 1, Rate = 4, Comment="Good Game!!", EditionId = 1, UserId = 1},
                new Review { Id = 2, Rate = 1, Comment="Bad Game!!", EditionId = 2, UserId = 2},
                new Review { Id = 3, Rate = 2, Comment="Ok Game!!", EditionId = 3, UserId = 3},
                new Review { Id = 4, Rate = 5, Comment="Pretty Good Game!!", EditionId = 4, UserId = 4},
                new Review { Id = 5, Rate = 3, Comment="Normal Game!!", EditionId = 5, UserId = 5},
            });
        }
    }
}
