using solid.spr;

namespace solid.spr{
    public class UserService{
        public void saveUser(User user){
            System.Console.WriteLine($"save user instance to DB: {user.id}");
        }
        public void sendMessageToUser(User user){
            System.Console.WriteLine($"sent message user: {user.Id}");
        }
        public void saveLogUserActivity(User usr){
            System.Console.WriteLine($"Logging user Activity: {user.Id}");
        }
    }
}

