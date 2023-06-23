using Dapper;
using Game.Domain.Entities;
using Game.Infra.Data.DataContext;
using Microsoft.Data.SqlClient;

namespace Game.Service.Repositories
{
    public class GameRepository : IRepository<VideogameCartridge, int>
    {
        private readonly GameDatabaseContext _db;

        public GameRepository(GameDatabaseContext db)
        {
            _db = db;
        }

        public void Add(VideogameCartridge entity)
        {
            _db.VideogameCartridges.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var temp = _db.VideogameCartridges.FirstOrDefault(x => x.Id == id);
            _db.VideogameCartridges.Remove(temp);
            _db.SaveChanges();
        }

        public VideogameCartridge Find(int id)
        {
            var result =  _db.VideogameCartridges.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public VideogameCartridge FindByName(string name)
        {
            //I can use EFCore, but to samplify CQRS I will use Dapper
            //var result = _db.VideogameCartridges.FirstOrDefault(x => x.Name.StartsWith(name));
            var result = new VideogameCartridge();

            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameDatabase;Integrated Security=True;";
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM VideogameCartridges ";
                result = connection.QuerySingle<VideogameCartridge>(sql,name);
            }
            
            return result;
        }

        public void Update(int id, VideogameCartridge entity)
        {
            throw new NotImplementedException();
        }
    }
}
