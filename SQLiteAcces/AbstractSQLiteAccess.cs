using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteAccess
{
    public abstract class AbstractSQLiteAccess
    {

        public enum ErrCheck 
        { 
            OK,
            AccessErr,
            NOCONErr,
            NOTransactionErr,
            SelectOK,
            SelectNG,
            TransactionErr,
            CommitErr,
            RollBackErr,
            NullErr,
            EmptyErr,
            OtherErr            
        }

        public enum ModeCheck 
        {
            IDEL,
            CON,
            TRAN,
            SelectOK,
            SelectNG        
        }

        public abstract ErrCheck ExeNonQuery(string query);

        public abstract (ErrCheck para,SQLiteDataReader ExeQuery) GetSQLiteData(string query);
    }
}
