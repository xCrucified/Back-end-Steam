using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.data.Entities
{
    public enum GamesCategories
    {
        Action = 1,
        Adventure,
        Casual,
        Indie,
        RPG,
        Simulation,
        Sports,
        Strategy,
        Horror,
        Multiplayer,
        VR,
        Puzzle,
        OpenWorld,
        Racing,
        Fighting,
        Sandbox,
        Coop,
        MMORPG,
        Music,
        FPS,
        ThirdPerson,
        Survival,
        Tactical,
        SciFi,
        Fantasy,
        Historical,
        Educational,
        CardGame,
        BoardGame,
        FreeToPlay,
        EarlyAccess,
        Anime,
        StoryRich,
        PixelGraphics,
        Retro,
        BattleRoyale,
        MOBA,
        Stealth,
        Exploration,
        Crafting,
        Comedy,
        Military,
        Cyberpunk,
        Space,
        Western,
        Zombie,
        PostApocalyptic,
        Esports
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int EditionId { get; set; }

        public Edition? Edition { get; set; }
    }
}
