namespace solid.spr.compliant{
    public class ActivityLogger{
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
