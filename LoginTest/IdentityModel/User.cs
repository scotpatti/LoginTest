using Microsoft.AspNetCore.Identity;

namespace LoginTest.IdentityModel
{
    public class User : IdentityUser
    {
        // See https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.entityframeworkcore.identityuser?view=aspnetcore-1.1
        // for IdenityUser properties that are included in IdentityUser.

        //You can add anything you want to have about your user here e.g. suppose we wanted to add MaidenName as an optional field
        //We could do it as follows (Note the question mark means that this string is nullable reference type - introduced in c# 8
        //https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references
        //The challenge here is that this additional bit of information is not included in any of the default pages that we scaffolded in before.
        //Too add source of the scaffolded pages so that we can edit them see:
        //https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-6.0#scaffold-identity-into-a-razor-project-with-authorization
        //OR if you just want to edit that information somewhere else, use the normal EntityFramework tools to do that in a separate webpage. 
        public string? MaidenName { get; set; } = "";
    }
}
