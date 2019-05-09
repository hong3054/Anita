using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Anita.Models
{
    public class UserInfo
    {
        public UserInfo()
        {
            State = 1;
            CreateTime = DateTime.Now;
        }

        [Key]
        public int Uid { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [Required,MaxLength(11)]
        public string Phone { get; set; }

        [MaxLength(32)]
        public string UserName { get; set; }

        [MaxLength(32)]
        public string NickName { get; set; }

        [DataType(DataType.Password),MaxLength(64),MinLength(8)]
        public string Password { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [MaxLength(128)]
        public string HeadPortrait { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DefaultValue(1)]
        public int State { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreateTime { get; set; }
    }
}