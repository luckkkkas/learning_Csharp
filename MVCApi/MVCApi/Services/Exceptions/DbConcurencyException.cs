namespace MVCApi.Services.Exceptions
{
    public class DbConcurencyException:ApplicationException
    {
        public DbConcurencyException(string name): base(name) 
        {
            
        }
    }
}
