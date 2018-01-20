using MongoDB.Driver;
using System;
using Models;

namespace LoggingProvider
{
    public class LoggingDAL
    {
        IMongoCollection<Logs> userData;
        public LoggingDAL()
        {
            MongoClient client = new MongoClient("mongodb://ClickNEarnAccounts:shantam99@cluster0-shard-00-00-fpmgs.mongodb.net:27017,cluster0-shard-00-01-fpmgs.mongodb.net:27017,cluster0-shard-00-02-fpmgs.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin");
            userData = client.GetDatabase("ClickNEarn").GetCollection<Logs>("Logs");
        }
        public bool LogToDB()
        {

            return false;
        }
    }
}
