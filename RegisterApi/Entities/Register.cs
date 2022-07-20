namespace RegisterApi.Entities
{
    public class Register
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        

        public Register(int id, string name, string password)
        {
            Name = name;
            Password = password;
            Id = id;
        }
    }
}
    

