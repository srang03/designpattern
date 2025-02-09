namespace solid.spr{
    public class User {
        string id;
        string name;

        public User(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string getId(){
            return id;
        }

        public string getName(){
            return name;
        }
    }
}

