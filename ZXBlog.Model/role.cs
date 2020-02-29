using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXBlog.Model
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class role:BaseEntity
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        [StringLength(maximumLength: 100),Required,Column(TypeName = "varchar")]
        public string role_name { get; set; }
    }
}
