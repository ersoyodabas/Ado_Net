using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdoNet.Models.EntityLayer
{
    public class Product : DataAccess
    {
        #region Properties
        public string Header { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        #endregion


        #region METHODS

        public bool InsertOrUpdate()
        {
            return DAL.InsertOrUpdateProduct(Id, Header, Content, CreateId, EditId, Deleted);
        }

        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();
            DataTable dt = DAL.GetProductList();

            foreach (DataRow row in dt.Rows)
            {
                Product obj = new Product()
                {
                    Id = row.Field<int>("Id"),
                    Header = row.Field<string>("Header"),
                    Content = row.Field<string>("Content")
                };
                list.Add(obj);
            }

            return list;
        }

        #endregion
    }

    public partial class DataAccessLayer
    {
        public bool InsertOrUpdateProduct(int pId, string pHeader, string pContent, int pCreateId, int pEditId, bool pDeleted)
        {
            //return DatabaseContext.ExecuteNonQuery(CommandType.StoredProcedure, "_Admin_Insert_Or_Update_Product", MethodBase.GetCurrentMethod().GetParameters(), new object[] { pId, pHeader, pFilePath, pName, pFileIcon, pContent, pCompanyType, pCreateId, pEditId, pDeleted });

            return true;
        }

        public DataTable GetListProduct()
        {
            //return DatabaseContext.ExecuteReader(CommandType.StoredProcedure, "_Admin_GetList_Product", MethodBase.GetCurrentMethod().GetParameters(), new object[] { });
            return new DataTable();
        }


    }



}
