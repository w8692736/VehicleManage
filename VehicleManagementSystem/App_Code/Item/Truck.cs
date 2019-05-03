using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///     货车的实体类
/// </summary>
public class Truck : ITransportation
{

    /// <summary>
    ///     Truck类的构造函数
    /// </summary>
    /// <param name="License">车牌号</param>
    /// <param name="Type">车辆类型</param>
    /// <param name="Length">长度</param>
    /// <param name="Weight">重量</param>
    /// <param name="Load">最大载荷</param>
    /// <param name="UsedYear">使用年限</param>
    /// <param name="Mileage">总行驶里程数</param>
    public Truck(string License, string Type, float Length, float Weight, float Load, float UsedYear, float Mileage)
    {
        this.License = License;
        this.Type = Type;
        this.Length = Length;
        this.Weight = Weight;
        this.Load = Load;
        this.UsedYear = UsedYear;
        this.Mileage = Mileage;
    }

    #region ITransportation方法
    /// <summary>
    ///     获取能唯一标识该交通工具的长度在20以内的编号，该编号将在数据库中作为其索引号
    /// </summary>
    /// <returns>返回一个能唯一标识该交通工具的编号，长度在20以内</returns>
    public string GetId()
    {
        return this.License;
    }

    /// <summary>
    ///     获取该车辆的最大载荷
    /// </summary>
    /// <returns>一个大于0的float型实数，表示该交通工具的最大载荷</returns>
    public float GetLoad()
    {
        return this.Load;
    }

    /// <summary>
    ///     获取该车辆的最大载人量（含司机）
    /// </summary>
    /// <returns>一个大于等于1的int型整数，表示该交通工具的最大载人量</returns>
    public int GetMannedCapasity()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     获取该车辆的里程数
    /// </summary>
    /// <returns>返回一个大于0的float型实数，表示该交通工具的里程数</returns>
    public float GetMileage()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     获取该车辆的类型
    /// </summary>
    /// <returns>返回一个含有车辆类型的文本描述</returns>
    public string GetTransportationType()
    {
        return this.Type;
    }
    #endregion

    #region 属性及其封装
    /// <summary>
    ///     货车类型
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    ///     货车长度
    /// </summary>
    public float Length { get; set; }

    /// <summary>
    ///     货车重量
    /// </summary>
    public float Weight { get; set; }

    /// <summary>
    ///     最大载荷
    /// </summary>
    public float Load { get; set; }

    /// <summary>
    ///     车辆牌照
    /// </summary>
    public string License { get; set; }

    /// <summary>
    ///     已使用年限
    /// </summary>
    public float UsedYear { get; set; }

    /// <summary>
    ///     总行驶里程数
    /// </summary>
    public float Mileage { get; set; }
    #endregion
}