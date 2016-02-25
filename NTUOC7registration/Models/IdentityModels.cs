using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace NTUOC7registration.Models
{
    // 您可以在 ApplicationUser 類別新增更多屬性，為使用者新增設定檔資料，請造訪 http://go.microsoft.com/fwlink/?LinkID=317594 以深入了解。
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // 注意 authenticationType 必須符合 CookieAuthenticationOptions.AuthenticationType 中定義的項目
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // 在這裡新增自訂使用者宣告
            return userIdentity;

        }
        public string unidcode { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public string sex { get; set; }
        public string telphone { get; set; }
        public string mobile { get; set; }
        public override string Email { get; set; }
        public string parent { get; set; }
        public string relation { get; set; }
        public string emergence { get; set; }
        public string dorm { get; set; }
        public string sleepbag { get; set; }
        public string food { get; set; }
        public string eatother { get; set; }
        public string disease { get; set; }
        public string disother { get; set; }
        public string lowincomes { get; set; }
        public string size { get; set; }
        public string other { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}