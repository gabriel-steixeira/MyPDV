using System.Data.Entity;

namespace ReactApp1.Server.Data
{
    public class Context : DbContext 
    {
        public Context() : base("name=Context")
        {
            Database.SetInitializer<Context>(null);
        }

        public static Context Create()
        {
            return new Context();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add<Context>(new Context());

            base.OnModelCreating(modelBuilder);
        }

        //DbSet
    }
}
