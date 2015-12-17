using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GolfScoreCard.Models;

namespace GolfScoreCard.Models
{

    public class GameRepository
    {
        private GameContext context;

        // DbContext is now ApplicationDbContext which gives use access to the
        // table containing the users.
        public IDbSet<ApplicationUser> Users { get { return context.Users; } }

        public GameRepository()
        {
            context = new GameContext();
        }

        public GameRepository(GameContext _context)
        {
            context = _context;
        }

        //void or bool 
        public bool AddGameInformation(int _Game_id, GameInformation _list)
        {
            var query = from g in context.MyGames where g.GameId == _Game_id select g;
            Game found_game = null;
            bool result = true;
            try
            {
                found_game = query.Single<Game>();
                found_game.GamesPlayed.Add(_list);
                context.SaveChanges();
            }
            catch (InvalidOperationException)
            {
                result = false;
            }
            catch (ArgumentNullException)
            {
                result = false;
            }
            return result;
        }

        public Game CreateGame(string title, ApplicationUser owner)
        {
            Game my_game= new Game { Title = title, Owner = owner };
            context.MyGames.Add(my_game);
            context.SaveChanges(); // This saves something to the Database

            return my_game;
        }

        public virtual List<Game> GetAllGames()
        {
            return context.MyGames.ToList();
        }

        public int GetGameCount()
        {
            var query = from g in context.MyGames select g;
            

            return query.Count();
        }

        public List<Game> GetGames(ApplicationUser user1)
        {
            var query = from g in context.MyGames where g.Owner.Id == user1.Id select g;
            return query.ToList<Game>(); // Same as query.ToList();
        }

        public Game GetGameById(int game_id)
        {
            var query = from g in context.MyGames where g.GameId == game_id select g;
            return query.Single<Game>(); // Same as query.ToList();
        }

        public bool AddGameInformation(int v, object _list)
        {
            throw new NotImplementedException();
        }
    }

}