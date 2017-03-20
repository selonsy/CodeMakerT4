using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Dapper;
using System.Data;
using Devin.Framework;
namespace Devin.Models
{   	
	/// <summary>
	/// 用户表
	/// </summary>
    public partial class UserModel : ModelClass<UserModel>
    {
        ///<summary>字段枚举</summary>	
		public enum EUser 
		{ 	
			///<summary>用户id</summary>
			Id,	
			///<summary>用户名称</summary>
			UserName,	
			///<summary>手机号码</summary>
			Phone,	
			///<summary>邮箱</summary>
			Email,	
			///<summary>添加时间</summary>
			AddTime,	
			///<summary>修改时间</summary>
			ModifyTime,	
			///<summary>是否有效</summary>
			Activity,	
			///<summary></summary>
			UserType,
		}

        ///<summary>字段列表</summary>	
        public static string[] ps = { "Id", "UserName", "Phone", "Email", "AddTime", "ModifyTime", "Activity", "UserType" };
        
		///<summary>对应数据库的表名</summary>	
        public static string tablename = "User";

		#region 字段成员

		///<summary>用户id</summary>		
		public string Id { get; set; }
		///<summary>用户名称</summary>		
		public string UserName { get; set; }
		///<summary>手机号码</summary>		
		public string Phone { get; set; }
		///<summary>邮箱</summary>		
		public string Email { get; set; }
		///<summary>添加时间</summary>		
		public DateTime AddTime { get; set; }
		///<summary>修改时间</summary>		
		public DateTime? ModifyTime { get; set; }
		///<summary>是否有效</summary>		
		public int Activity { get; set; }
		///<summary></summary>		
		public int UserType { get; set; }
		
		#endregion

		/// <summary>
        /// 构造函数
        /// </summary>
        public UserModel()
        {
            base.TableName = tablename;
            base.Ps = ps;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Dapper;
using System.Data;
using Devin.Framework;
namespace Devin.Models
{
    /// <summary>
    /// 用户表
    /// </summary>
    public partial class UserModel : ModelClass<UserModel>
    {
		#region 查

		#endregion

		#region 增

		#endregion

		#region 删

		#endregion

		#region 改

		#endregion

		#region 扩展属性

		#endregion
    }
}


