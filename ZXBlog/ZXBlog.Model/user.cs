using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXBlog.Model
{
    public class user:BaseEntity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [StringLength(maximumLength: 100), Required, Column(TypeName = "varchar")]
        public string user_name { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        [StringLength(maximumLength: 100), Required, Column(TypeName = "varchar")]
        public string user_pwd { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        [StringLength(maximumLength: 100), Required, Column(TypeName = "varchar")]
        public string user_email { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        [StringLength(maximumLength: 100), Required, Column(TypeName = "varchar")]
        public string user_headportrait { get; set; }
        /// <summary>
        /// 用户生日
        /// </summary>
        [Required]
        public DateTime user_birthday { get; set; }
        /// <summary>
        /// 用户年龄
        /// </summary>
        [Required]
        public int user_age { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        [StringLength(maximumLength: 100), Required, Column(TypeName = "varchar")]
        public string user_phone { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        [StringLength(maximumLength: 100), Required, Column(TypeName = "varchar")]
        public string user_rname { get; set; }
        /// <summary>
        /// 角色id（外键）
        /// </summary>
        [ForeignKey(nameof(role))]
        public Guid role_id { get; set; }
        public role role { get; set; }
    }
}
