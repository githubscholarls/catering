using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace catering.ModelDto
{
    public class RegisterUserDto
    {
        [Required(ErrorMessage = "用户名为必填选项")]
        [Display(Name="用户名")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "用户名必须在6-16个字符")]
        public string Name { get; set; }

        [Display(Name = "邮箱")]
        [RegularExpression(@"^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$")]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }

        [Required(ErrorMessage = "密码为必填选项"), RegularExpression(@"^[a-zA-Z0-9_]*$", ErrorMessage = "大小写字母，数字和下划线为有效字符"), Display(Name = "密码")]
        [MinLength(6, ErrorMessage = "密码最少6个字符"), MaxLength(18, ErrorMessage = "密码最多18个字符")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name="确认密码")]
        [Compare("Password",ErrorMessage ="密码与确认密码不一致，请重新输入.")]
        public string ConfirmPassword { get; set; }

        
        [RegularExpression(@"^1[0-9]{10}$", ErrorMessage = "手机号格式错误"), Display(Name = "手机号")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Date), Display(Name = "出生日期")]
        public DateTime? Release { get; set; }
    }
}
