namespace SimpleAdmin.Core;
/// <summary>
/// 多租户
/// </summary>
[SugarTable("sys_tenant", TableDescription = "多租户")]
[Tenant(SqlsugarConst.DB_Default)]
[CodeGen]
public class SysTenant : DataEntityBase
{
    /// <summary>
    /// 租户名称
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// 联系人
    /// </summary>
    public string contacts { get; set; }

    /// <summary>
    /// 联系电话
    /// </summary>
    public string phone { get; set; }

    /// <summary>
    /// 营业执照号码
    /// </summary>
    public string businessLicenseNo { get; set; }

    /// <summary>
    /// 营业执照名称
    /// </summary>
    public string businessLicenseName { get; set; }

    /// <summary>
    /// 营业执照照片
    /// </summary>
    public string businessLicensePic { get; set; }

    /// <summary>
    /// 法人姓名
    /// </summary>
    public string legalPersonName { get; set; }

    /// <summary>
    /// 法人身份证号
    /// </summary>
    public string legalPersonCardNo { get; set; }

    /// <summary>
    /// 法人身份证国徽面
    /// </summary>
    public string legalPersonCardPicFont { get; set; }

    /// <summary>
    /// 法人身份证信息面
    /// </summary>
    public string legalPersonCardPicBack { get; set; }

    /// <summary>
    /// 是否独立数据库
    /// </summary>
    public bool aloneDataBase { get; set; }

    /// <summary>
    /// 数据库格式 0、SqlServer 1、MySql 2、Sqlite 3、Oracle 
    /// </summary>
    public int? dbType { get; set; }

    /// <summary>
    /// 数据库地址
    /// </summary>
    public string dBServer { get; set; }

    /// <summary>
    /// 数据库名
    /// </summary>
    public string dBName { get; set; }

    /// <summary>
    /// 数据库账号
    /// </summary>
    public string dBUser { get; set; }

    /// <summary>
    /// 数据库密码
    /// </summary>
    public string dBPassWord { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? createTime { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string createUser { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? modifyTime { get; set; }

    /// <summary>
    /// 修改人
    /// </summary>
    public string modifyUser { get; set; }

    /// <summary>
    /// 是否开启
    /// </summary>
    public bool? isEnable { get; set; }

    /// <summary>
    /// 是否删除
    /// </summary>
    public bool? isDelete { get; set; }

    /// <summary>
    /// 到期时间
    /// </summary>
    public DateTime? endTime { get; set; }
}

