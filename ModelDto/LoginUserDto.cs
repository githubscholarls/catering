using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace catering.ModelDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "用户名为必填选项"), Display(Name = "用户名")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "用户名必须在6-16个字符")]
        public string Name { get; set; }
        [Required(ErrorMessage = "密码为必填选项"), RegularExpression(@"^[a-zA-Z0-9_]*$", ErrorMessage = "大小写字母，数字和下划线为有效字符"), Display(Name = "密码")]
        [MinLength(6, ErrorMessage = "密码最少6个字符"), MaxLength(18, ErrorMessage = "密码最多18个字符")]
        public string Password { get; set; }
        [Display(Name="记住我")]
        public bool RememberMe { get; set; }

    }
}
