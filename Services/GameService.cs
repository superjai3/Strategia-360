using Herramientas_de_programacion.Pages;

namespace clase3.Services;

public static class GameService
{
    public static List<Game> GameList {get; set;} = new List<Game>();

    public static List<Game> GetAll()         //devuelve un alista de juegos.
    {
        if(GameList.Count() == 0)
        {
            var game1 = new Game();
            game1.Name = "Fifa 2023";
            game1.Clasif = Clasification.p7;
            game1.IsMultiplayer = true;
            GameList.Add(game1);

            var game2 = new Game();
            game2.Name = "Mortal Kombat";
            game2.Clasif = Clasification.p18;
            game2.IsMultiplayer = true;
            GameList.Add(game2);

            var game3 = new Game();
            game3.Name = "Mario Bross";
            game3.Clasif = Clasification.p3;
            game3.IsMultiplayer = true;
            GameList.Add(game3);
        }
        return GameList;
    }

    public static void Delete(string name)
    {
        var item = GameList.FirstOrDefault (x => x.Name.ToLower() == name.ToLower());
        if (item != null)
        {
         GameList.Remove(item);
        }
    }
    
    public static void Create(Game newGame)
    {
        GameList.Add(newGame);
    }

    public static void Update()
    {
        
    }
}