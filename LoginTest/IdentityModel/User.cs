using Microsoft.AspNetCore.Identity;

namespace LoginTest.IdentityModel
{
    public class User : IdentityUser
    {
        // See https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.entityframeworkcore.identityuser?view=aspnetcore-1.1
        // for IdenityUser properties that are included in IdentityUser.

        //You can add anything you want to have about your user here e.g.:
        public string MaidenName { get; set; }

    }
}
