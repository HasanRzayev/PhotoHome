using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using PhotoHome.Data;

namespace PhotoHome.Models.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public int index { get; set; }


        public void Configure(EntityTypeBuilder<User> builder)
        {
            index = 1;

            builder.HasData(new User { Id = "1", UserName= "Hesen_Rzayev", FirstName = "Hesen", Email = "hsnrz2002@gmail.com", LastName = "Rzayev"});
            builder.HasData(new User { Id = "2",  UserName= "Adil_Abbasov", FirstName = "Adil", Email = "ffff@gmail.com", LastName = "Abbasov"});
            //builder.HasData(new User { Id = "3",  UserName= "AlpAslan_Cakirbeyli", FirstName = "AlpAslan", Email = "dd@gmail.com", LastName = "Cakirbeyli" });
            //builder.HasData(new User { Id = "4",  UserName= "Hizir_Cakirbeyli", FirstName = "Hizir", Email = "sss@gmail.com", LastName = "Cakirbeyli" });
            //builder.HasData(new User { Id = "5", UserName = "Ilyas_Cakirbeyli", FirstName = "Ilyas", Email = "aaaa@gmail.com", LastName = "Cakirbeyli" });
        }

        //// In this method we will create default User roles and Admin user for login    
        //private void createRolesandUsers()
        //{
         

        //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());
        //    var UserManager = new UserManager<User>(new UserStore<User>());


        //    // In Startup iam creating first Admin Role and creating a default Admin User     
        //    if (!roleManager.RoleExists("Admin"))
        //    {

        //        // first we create Admin rool    
        //        var role = new IdentityRole();
        //        role.Name = "Admin";
        //        roleManager.Create(role);

        //        //Here we create a Admin super user who will maintain the website                   

        //        var user = new User();
        //        user.UserName = "shanu";
        //        user.Email = "syedshanumcain@gmail.com";

        //        string userPWD = "A@Z200711";

        //        var chkUser = UserManager.Create(user, userPWD);

        //        //Add default User to Role Admin    
        //        if (chkUser.Succeeded)
        //        {
        //            var result1 = UserManager.AddToRole(user.Id, "Admin");

        //        }
        //    }

        //    // creating Creating Manager role     
        //    if (!roleManager.RoleExists("Client"))
        //    {
        //        var role = new IdentityRole();
        //        role.Name = "Client";
        //        roleManager.Create(role);

        //    }

            
        //}

    }
}
