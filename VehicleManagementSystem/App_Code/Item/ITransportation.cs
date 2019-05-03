using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///     交通工具通用接口，所有后续的交通工具实体类都必须继承该类，否则会有重大错误
/// </summary>
public interface ITransportation
{
    /// <summary>
    ///     获取该车辆的类型
    /// </summary>
    /// <returns>返回一个含有车辆类型的文本描述</returns>
    String GetTransportationType();

    /// <summary>
    ///     获取能唯一标识该交通工具的长度在20以内的编号，该编号将在数据库中作为其索引号
    /// </summary>
    /// <returns>返回一个能唯一标识该交通工具的编号，长度在20以内</returns>
    String GetId();

    /// <summary>
    ///     获取该车辆的里程数
    /// </summary>
    /// <returns>返回一个大于0的float型实数，表示该交通工具的里程数</returns>
    float GetMileage();

    /// <summary>
    ///     获取该车辆的最大载人量（含司机）
    /// </summary>
    /// <returns>一个大于等于1的int型整数，表示该交通工具的最大载人量</returns>
    int GetMannedCapasity();

    /// <summary>
    ///     获取该车辆的最大载荷
    /// </summary>
    /// <returns>一个大于0的float型实数，表示该交通工具的最大载荷</returns>
    float GetLoad();
}