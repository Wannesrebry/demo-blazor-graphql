namespace demo_graphql.Queries
{
    public class Query
    {

        public User GetUser() =>
            new User { Id = 1, Name = "wannes rebry" };



    }


    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}
