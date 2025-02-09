namespace solid.spr.compliant{
    public class UserRepository{
        public void saveUser(User user){
            System.Console.WriteLine($"save user instance to DB: {user.id}");
        }
    }
}
