using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SQLiteAccess
{
    public class AccessDB : AbstractSQLiteAccess
    {
        public string dbName;

        private ModeCheck Mode;

        SQLiteTransaction transaction;
        SQLiteConnection conn;
        SQLiteCommand command;

        public AccessDB(string dbname)
        {
            this.dbName = dbname;
            conn = new SQLiteConnection($"Data Source={dbname}");
            command = conn.CreateCommand();
        }

        public ErrCheck OpenDB()
        {
            if(Mode!=ModeCheck.IDEL)
            {
                return ErrCheck.OK;
            }

            try
            {
                conn.Open();
                Mode = ModeCheck.CON;
            }
            catch
            {
                return ErrCheck.AccessErr;
            }

            return ErrCheck.OK;
        }

        public override ErrCheck ExeNonQuery(string query)
        {
            if (query==null)
            {
                return ErrCheck.NullErr;
            }
            if (query.Trim()==String.Empty)
            {
                return ErrCheck.EmptyErr;
            }
            if (Mode==(int)ModeCheck.IDEL)
            {
                return ErrCheck.NOCONErr;
            }
            if (Mode==ModeCheck.CON)
            {
                return ErrCheck.NOTransactionErr;
            }
            else if(Mode==ModeCheck.SelectOK||Mode==ModeCheck.SelectNG)
            {
                return ErrCheck.TransactionErr;
            }

            try
            {
                command.CommandText = query;
                command.ExecuteNonQuery();
                Mode = ModeCheck.TRAN;
            }
            catch
            {
                return ErrCheck.TransactionErr;
            }

            return ErrCheck.OK;
        }

        public override (ErrCheck para, SQLiteDataReader ExeQuery) GetSQLiteData(string query)
        {
            SQLiteDataReader reader = null;
            if (Mode==(int)ModeCheck.IDEL)
            {
                return (ErrCheck.CommitErr,reader);
            }
            try
            {
                command.CommandText = query;
                reader = command.ExecuteReader();
                Mode = ModeCheck.SelectOK;
            }
            catch
            {
                Mode = ModeCheck.SelectNG;
                return (ErrCheck.SelectNG, reader);
            }

            return (ErrCheck.SelectOK, reader);
        }

        public ErrCheck Transaction()
        {
            if (Mode == (int)ModeCheck.IDEL)
            {
                return ErrCheck.NOCONErr;
            }
            else if (Mode==ModeCheck.TRAN)
            {
                return ErrCheck.OK;
            }

            try
            {
                transaction = conn.BeginTransaction();
                command = conn.CreateCommand();
                command.Connection = conn;
                command.Transaction = transaction;
                Mode = ModeCheck.TRAN;
            }
            catch
            {
                return ErrCheck.TransactionErr;
            }

            return ErrCheck.OK;
        }

        public ErrCheck Commit()
        {
            if (Mode == (int)ModeCheck.IDEL)
            {
                return ErrCheck.NOCONErr;
            }
            else if (Mode==ModeCheck.CON)
            {
                return ErrCheck.NOTransactionErr;
            }
            else if (transaction==null)
            {
                return ErrCheck.NullErr;
            }

            try
            {
                transaction.Commit();
                Mode = ModeCheck.CON;
            }
            catch
            {
                if (Mode == ModeCheck.SelectOK || Mode == ModeCheck.SelectNG)
                {
                    return ErrCheck.NOTransactionErr;
                }

                return ErrCheck.CommitErr;
            }

            return ErrCheck.OK;
        }

        public ErrCheck RollBack()
        {
            if (Mode == (int)ModeCheck.IDEL)
            {
                return ErrCheck.NOCONErr;
            }
            else if (Mode == ModeCheck.CON)
            {
                return ErrCheck.NOTransactionErr;
            }
            else if (transaction == null)
            {
                return ErrCheck.NullErr;
            }

            try
            {
                transaction.Rollback();
                Mode = ModeCheck.CON;
            }
            catch
            {
                if (Mode == ModeCheck.SelectOK || Mode == ModeCheck.SelectNG)
                {
                    return ErrCheck.NOTransactionErr;
                }

                return ErrCheck.RollBackErr;
            }

            return ErrCheck.OK;
        }

        public ErrCheck CloseDB()
        {
            if (Mode == (int)ModeCheck.IDEL)
            {
                return ErrCheck.NOCONErr;
            }
            else if (Mode==ModeCheck.TRAN)
            {
                transaction.Rollback();
            }
            else if (Mode == ModeCheck.SelectOK || Mode == ModeCheck.SelectNG)
            {
                try
                {
                    transaction.Rollback();
                }
                catch
                {
                    conn.Close();
                    return ErrCheck.OK;
                }
            }

            conn.Close();

            return ErrCheck.OK;
        }

        //テスト用
        public void SetData(string query,DataTable datatable)
        {
            using(SQLiteDataAdapter sqladater=new SQLiteDataAdapter(query, conn))
            {
                sqladater.Fill(datatable);
            }
        } 

    }
}
