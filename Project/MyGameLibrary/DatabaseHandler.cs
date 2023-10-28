using MongoDB.Driver;
using MyGameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public class DatabaseHandler
    {
        private static MongoClient instance = null;
        
        private static MongoClient get_connection_instance()
        {
            
                if (instance == null)
                {
                    instance = new MongoClient("mongodb://localhost:27017");
                }
                return instance;
        }
        
        private static IMongoDatabase get_database(string database_name)
        {

            return DatabaseHandler.get_connection_instance().GetDatabase(database_name);
            
        }

        public static IMongoCollection<StatisticsDatabaseModel> get_statistics_collection()
        {

            return DatabaseHandler.get_database("CSC532").GetCollection<StatisticsDatabaseModel>("Statistics");
            
        } 

        public async static void insert_statistics()
        {

            Console.WriteLine("Inserting statistics");
            Console.WriteLine("Damage Done: " + StatisticsModel.DamageDone);
            Console.WriteLine("Damage Taken: " + StatisticsModel.DamageTaken);
            Console.WriteLine("Distance Traveled: " + StatisticsModel.DistanceTraveled);
            // Insert statistics model with values it is currently holding 
            await DatabaseHandler.get_statistics_collection().InsertOneAsync(new StatisticsDatabaseModel
            {
                DamageDone = StatisticsModel.DamageDone,
                DamageTaken = StatisticsModel.DamageTaken,
                DistanceTraveled = StatisticsModel.DistanceTraveled
            });

        }

        public static StatisticsDatabaseModel get_latest_statistics()
        {

            // Get the latest statistics model from the database
            return DatabaseHandler.get_statistics_collection().Find(_ => true).SortByDescending(x => x.Id).Limit(1).FirstOrDefault();

        }
    }

        // TODO game state collection goes here

    
}
