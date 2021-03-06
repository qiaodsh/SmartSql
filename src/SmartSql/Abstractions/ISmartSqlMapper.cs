﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.Common;
using System.Threading.Tasks;
using SmartSql.Abstractions.DbSession;
using SmartSql.Abstractions.DataSource;
using SmartSql.Abstractions.Cache;
using SmartSql.Abstractions.Config;
using SmartSql.Configuration;

namespace SmartSql.Abstractions
{
    /// <summary>
    /// SmartSql 映射器
    /// </summary>
    public interface ISmartSqlMapper : ISmartSqlMapperAsync, ISession, ITransaction, IDisposable
    {
        SmartSqlOptions SmartSqlOptions { get; }
        int Execute(RequestContext context);
        T ExecuteScalar<T>(RequestContext context);
        IEnumerable<T> Query<T>(RequestContext context);
        T QuerySingle<T>(RequestContext context);
        IMultipleResult FillMultiple(RequestContext context, IMultipleResult multipleResult);
        DataTable GetDataTable(RequestContext context);
        DataSet GetDataSet(RequestContext context);

        T GetNested<T>(RequestContext context);
    }

    public enum DataSourceChoice
    {
        Unknow,
        Write,
        Read
    }
}
