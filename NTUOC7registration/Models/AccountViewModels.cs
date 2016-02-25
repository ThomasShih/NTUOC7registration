using System.ComponentModel.DataAnnotations;

namespace NTUOC7registration.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string Action { get; set; }
        public string ReturnUrl { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "目前密碼")]
        public string OldPassword { get; set; }

        
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "新密碼")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "確認新密碼")]
        [Compare("NewPassword", ErrorMessage = "新密碼與確認密碼不相符。")]
        public string ConfirmPassword { get; set; }

        
        [Display(Name = "姓名")]
        [MaxLength(30, ErrorMessage = "必填")]
        public string name { get; set; }


        [Display(Name = "錄取學系")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string department { get; set; }

        
        [Display(Name = "性別")]
        [MaxLength(30, ErrorMessage = "必填")]
        public string sex { get; set; }

        
        [Display(Name = "住家電話")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "必填")]
        public string telphone { get; set; }

        [Display(Name = "個人行動電話")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "必填")]
        public string mobile { get; set; }

        
        [Display(Name = "電子郵件")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string Email { get; set; }

        
        [Display(Name = "緊急聯絡人")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string parent { get; set; }

       
        [Display(Name = "關係")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string relation { get; set; }

        
        [Display(Name = "緊急連絡人電話")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "必填")]
        public string emergence { get; set; }

        
        [Display(Name = "是否住宿")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string dorm { get; set; }

        
        [Display(Name = "是否租用睡袋")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string sleepbag { get; set; }

        
        [Display(Name = "葷／素")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string food { get; set; }


        [Display(Name = "特殊飲食習慣要求")]
        [MaxLength(100)]
        public string eatother { get; set; }

        
        [Display(Name = "是否領有身心障礙手冊")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string disease { get; set; }


        [Display(Name = "需要協助的地方")]
        [MaxLength(100, ErrorMessage = "若無請填無")]
        public string disother { get; set; }

       
        [Display(Name = "是否為中/低收入戶")]
        [MaxLength(30, ErrorMessage = "必填")]
        public string lowincomes { get; set; }

       
        [Display(Name = "新生限定上衣尺寸")]
        [MaxLength(30, ErrorMessage = "ex.S、M、L、XL")]
        public string size { get; set; }


        [Display(Name = "其他備註")]
        [MaxLength(100)]
        public string other { get; set; }

    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "身分證字號")]
        public string unicode { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [Display(Name = "記住我?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "必填")]
        [Display(Name = "身分證字號")]
        [MaxLength(30, ErrorMessage = "必填")]
        public string unidcode { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "確認密碼")]
        [Compare("Password", ErrorMessage = "密碼和確認密碼不相符。")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "必填")]
        [Display(Name = "姓名")]
        [MaxLength(30, ErrorMessage = "必填")]
        public string name { get; set; }

        [Required(ErrorMessage = "必填")]
        [Display(Name = "錄取學系")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string department { get; set; }

        [Required(ErrorMessage = "必填")]
        [Display(Name = "性別")]
        [MaxLength(30, ErrorMessage = "必填")]
        public string sex { get; set; }

        [Required(ErrorMessage = "必填")]
        [Display(Name = "住家電話")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "必填")]
        public string telphone { get; set; }

        [Required(ErrorMessage = "必填")]
        [Display(Name = "行動電話")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "必填")]
        public string mobile { get; set; }

        [Required]
        [Display(Name = "電子郵件")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "緊急聯絡人")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string parent { get; set; }

        [Required]
        [Display(Name = "關係")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string relation { get; set; }

        [Required]
        [Display(Name = "緊急連絡人電話")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "必填")]
        public string emergence { get; set; }

        [Required]
        [Display(Name = "是否住宿")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string dorm { get; set; }

        [Required]
        [Display(Name = "是否租用睡袋")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string sleepbag { get; set; }

        [Required]
        [Display(Name = "葷／素")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string food { get; set; }


        [Display(Name = "特殊飲食習慣要求")]
        [MaxLength(100)]
        public string eatother { get; set; }

        [Required]
        [Display(Name = "是否領有身心障礙手冊")]
        [MaxLength(100, ErrorMessage = "必填")]
        public string disease { get; set; }


        [Display(Name = "需要協助的地方")]
        [MaxLength(100, ErrorMessage = "若無請填無")]
        public string disother { get; set; }

        [Required]
        [Display(Name = "是否為中/低收入戶")]
        [MaxLength(30, ErrorMessage = "必填")]
        public string lowincomes { get; set; }

        [Required]
        [Display(Name = "新生限定上衣尺寸")]
        [MaxLength(30, ErrorMessage = "ex.S、M、L、XL")]
        public string size { get; set; }


        [Display(Name = "其他備註")]
        [MaxLength(100)]
        public string other { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "確認密碼")]
        [Compare("Password", ErrorMessage = "密碼和確認密碼不相符。")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }
    }
}
