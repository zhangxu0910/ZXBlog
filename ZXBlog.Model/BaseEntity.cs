using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXBlog.Model
{
    /// <summary>
    /// 基类表
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// 编号id
        /// </summary>
        public Guid id { get; set; } = Guid.NewGuid();
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime create_time { get; set; } = DateTime.Now;
        /// <summary>
        /// 是否删除（假删除）
        /// </summary>
        public bool isremoved { get; set; }
    }
}
