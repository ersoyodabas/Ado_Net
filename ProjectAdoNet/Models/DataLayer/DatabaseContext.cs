using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdoNet.Models.DataLayer
{
    public class DatabaseContext
    {
        //public static DataTable ExecuteReader(CommandType commandType, string commandText)
        //{
        //    if (string.IsNullOrEmpty(commandText))
        //        return new DataTable();

        //    try
        //    {
        //        return Eryaz.Utility.MsSqlHelper.ExecuteDataTable(GlobalSettings.ConnectionString, commandType, commandText);
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.LogGeneral(LogGeneralErrorType.Error, ClientType.None, commandText.Length > 50 ? commandText.Substring(0, 49) : commandText, ex, string.Empty);
        //        return new DataTable();
        //    }
        //}

        //public static DataTable ExecuteReader(CommandType commandType, string commandText, ParameterInfo[] parameterNames, object[] parameterValues)
        //{
        //    if (string.IsNullOrEmpty(commandText))
        //        return new DataTable();

        //    try
        //    {
        //        return Eryaz.Utility.MsSqlHelper.ExecuteDataTable(GlobalSettings.ConnectionString, commandType, commandText, GenerateParam(parameterNames, parameterValues));
        //    }
        //    catch (Exception ex)
        //    {
        //        // add parameters to log
        //        string parametres = GenerateParamStr(parameterNames, parameterValues);

        //        Logger.LogGeneral(LogGeneralErrorType.Error, ClientType.None, commandText.Length > 50 ? commandText.Substring(0, 49) : commandText, ex.Message + parametres, string.Empty);
        //        return new DataTable();
        //    }
        //}

        //public static async Task<DataTable> ExecuteReaderAsync(CommandType commandType, string commandText, string[] parameterNames, object[] parameterValues)
        //{
        //    if (string.IsNullOrEmpty(commandText))
        //        return new DataTable();

        //    try
        //    {
        //        return await Task.Run(async () => Eryaz.Utility.MsSqlHelper.ExecuteDataTable(GlobalSettings.ConnectionString, commandType, commandText, await GenerateParamAync(parameterNames, parameterValues)));
        //    }
        //    catch (Exception ex)
        //    {
        //        string parametres = await GenerateParamAyncStr(parameterNames, parameterValues);

        //        await Logger.LogGeneral(LogGeneralErrorType.Error, ClientType.None, commandText.Length > 50 ? commandText.Substring(0, 49) : commandText, ex.Message + parametres, string.Empty);
        //        return new DataTable();
        //    }
        //}

        //public static DataSet ExecuteReaderDs(CommandType commandType, string commandText)
        //{
        //    if (string.IsNullOrEmpty(commandText))
        //        return new DataSet();

        //    try
        //    {
        //        return Eryaz.Utility.MsSqlHelper.ExecuteDataset(GlobalSettings.ConnectionString, CommandType.StoredProcedure, commandText);
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.LogGeneral(LogGeneralErrorType.Error, ClientType.None, commandText.Length > 50 ? commandText.Substring(0, 49) : commandText, ex, string.Empty);
        //        return new DataSet();
        //    }
        //}

        //public static DataSet ExecuteReaderDs(CommandType commandType, string commandText, ParameterInfo[] parameterNames, object[] parameterValues)
        //{
        //    if (string.IsNullOrEmpty(commandText))
        //        return new DataSet();

        //    try
        //    {
        //        return Eryaz.Utility.MsSqlHelper.ExecuteDataset(GlobalSettings.ConnectionString, CommandType.StoredProcedure, commandText, GenerateParam(parameterNames, parameterValues));
        //    }
        //    catch (Exception ex)
        //    {
        //        string parametres = GenerateParamStr(parameterNames, parameterValues);

        //        Logger.LogGeneral(LogGeneralErrorType.Error, ClientType.None, commandText.Length > 50 ? commandText.Substring(0, 49) : commandText, ex.Message + parametres, string.Empty);
        //        return new DataSet();
        //    }
        //}

        //public static bool ExecuteNonQuery(CommandType commandType, string commandText)
        //{
        //    if (string.IsNullOrEmpty(commandText))
        //        return false;

        //    try
        //    {
        //        Eryaz.Utility.MsSqlHelper.ExecuteNonQuery(GlobalSettings.ConnectionString, commandType, commandText);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.LogGeneral(LogGeneralErrorType.Error, ClientType.None, commandText.Length > 50 ? commandText.Substring(0, 49) : commandText, ex, string.Empty);
        //        return false;
        //    }
        //}

        //public static bool ExecuteNonQuery(CommandType commandType, string commandText, ParameterInfo[] parameterNames, object[] parameterValues)
        //{
        //    if (string.IsNullOrEmpty(commandText))
        //        return false;

        //    try
        //    {
        //        Eryaz.Utility.MsSqlHelper.ExecuteNonQuery(GlobalSettings.ConnectionString, CommandType.StoredProcedure, commandText, GenerateParam(parameterNames, parameterValues));
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string parametres = GenerateParamStr(parameterNames, parameterValues);

        //        Logger.LogGeneral(LogGeneralErrorType.Error, ClientType.None, commandText.Length > 50 ? commandText.Substring(0, 49) : commandText, ex.Message + parametres, string.Empty);
        //        return false;
        //    }
        //}

        //public static SqlParameter[] GenerateParam(ParameterInfo[] parameterNames, params object[] parameterValues)
        //{
        //    int length = parameterNames.Length;
        //    SqlParameter[] sqlParams = new SqlParameter[length];

        //    for (int i = 0; i < length; i++)
        //    {
        //        SqlParameter parameter = new SqlParameter();
        //        parameter.ParameterName = "@" + parameterNames[i].Name;
        //        parameter.Value = parameterValues[i] == null ? "" : parameterValues[i];
        //        sqlParams[i] = parameter;
        //    }

        //    return sqlParams;
        //}

        //public static string GenerateParamStr(ParameterInfo[] parameterNames, params object[] parameterValues)
        //{
        //    int length = parameterNames.Length;
        //    string sqlParams = string.Empty;

        //    for (int i = 0; i < length; i++)
        //    {
        //        sqlParams += string.Format("\r\n{0}: {1}", parameterNames[i].Name, parameterValues[i] == null ? "" : parameterValues[i]);
        //    }

        //    return sqlParams;
        //}

        //public static async Task<SqlParameter[]> GenerateParamAync(string[] parameterNames, params object[] parameterValues)
        //{
        //    int length = parameterNames.Length;
        //    SqlParameter[] sqlParams = new SqlParameter[length];

        //    for (int i = 0; i < length; i++)
        //    {
        //        SqlParameter parameter = new SqlParameter();
        //        parameter.ParameterName = "@" + parameterNames[i];
        //        parameter.Value = parameterValues[i] == null ? "" : parameterValues[i];
        //        sqlParams[i] = parameter;
        //    }
        //    return sqlParams;
        //}

        //public static async Task<string> GenerateParamAyncStr(string[] parameterNames, params object[] parameterValues)
        //{
        //    int length = parameterNames.Length;
        //    string sqlParams = string.Empty;

        //    for (int i = 0; i < length; i++)
        //    {
        //        sqlParams += string.Format("\r\n{0}: {1}", parameterNames[i], parameterValues[i] == null ? "" : parameterValues[i]);
        //    }

        //    return sqlParams;
        //}
    }
}
