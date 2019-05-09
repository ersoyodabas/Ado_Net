﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdoNet.Models.DataLayer
{
    public partial class DataAccessLayer
    {
        public DataAccessLayer() { }
    }

    public sealed class MySQLParameterGeneratorEx
    {
        private const string ReturnValueParameterName = "RETURN_VALUE";

        public static MySqlParameter[] GenerateParam(ParameterInfo[] methodParameters, params object[] Values)
        {
            int length = methodParameters.Length;
            MySqlParameter[] sqlParams = new MySqlParameter[length];

            for (int i = 0; i < length; i++)
            {
                MySqlParameter parameter = new MySqlParameter();
                parameter.ParameterName = "@" + methodParameters[i].Name;
                parameter.Value = Values[i];
                sqlParams[i] = parameter;
            }

            return sqlParams;
        }
    }
}
