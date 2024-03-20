//using UniEat.Models;
//using Microsoft.Extensions.Options;
//using MongoDB.Driver;

//namespace UniEat.Services
//{
//    public class UniEatService
//    {
//        private readonly IMongoDatabase _UniEat;

//        public UniEatService(
//            IOptions<UniEatDatabaseSettings> unieatDatabaseSettings)
//        {
//            var mongoClient = new MongoClient(
//                unieatDatabaseSettings.Value.ConnectionString);

//            var mongoDatabase = new mongoClient.GetDatabase(
//                unieatDatabaseSettings.Value.DatabaseName);

//            _UniEat = mongoDatabase.GetCollection<MongoTest>(
//                UniEatDatabaseSettings.Value);

//        }
//    }
//}
