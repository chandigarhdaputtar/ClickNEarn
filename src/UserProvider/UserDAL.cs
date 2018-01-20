using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Diagnostics;
using Profiler;

namespace UserProvider
{
    public class UserDAL
    {
        IMongoCollection<User> userData;
        public UserDAL()
        {
            MongoClient client = new MongoClient("mongodb://ClickNEarnAccounts:shantam99@cluster0-shard-00-00-fpmgs.mongodb.net:27017,cluster0-shard-00-01-fpmgs.mongodb.net:27017,cluster0-shard-00-02-fpmgs.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin");
            userData = client.GetDatabase("ClickNEarn").GetCollection<User>("Users");
        }
        public bool AddUser(User user)
        {
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            try
            {
                userData.InsertOne(user);
                return true;
            }
            catch (Exception ex)
            {
                //log
                return false;
            }
            finally
            {
#if DEBUG
                //sw.Stop();
                //MethodProfile.Profile(MethodProfile.GetProjectName(),MethodProfile.GetFileName(),MethodProfile.GetCurrentMethod(), sw);
#endif
            }
        }
        public User GetUser(string username)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            try
            {
                var user = userData.Find<User>(x => x.AccountInfo.Username == username).Single();
                if (user != null)
                {
                    sw.Stop();
                    return user as User;
                }
                sw.Stop();
                return null;
            }
            catch (Exception ex)
            {
                //log
                sw.Stop();
                return null;
            }
        }
        public async Task<bool> AuthoriseLogin(string username)
        {
            try
            {
                var authorise = await userData.FindAsync(x => x.AccountInfo.Username == username);
                if (authorise == null)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                //log
                return false;
            }
        }
        public bool UpdateUser()
        {
            return false;
        }
        public bool DeleteUser()
        {
            return false;
        }
        public bool TerminateUser()
        {
            return false;

        }
    }
}
