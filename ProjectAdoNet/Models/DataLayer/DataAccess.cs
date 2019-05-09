using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdoNet.Models.DataLayer
{
    public class DataAccess
    {

        #region Properties
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateId { get; set; }
        public DateTime EditDate { get; set; }
        public int EditId { get; set; }
        public bool Deleted { get; set; }
        #endregion

        private static DataAccessLayer dal;
        protected static DataAccessLayer DAL
        {
            get
            {
                if (dal == null)
                    dal = new DataAccessLayer();
                return dal;
            }
        }

    }
}
