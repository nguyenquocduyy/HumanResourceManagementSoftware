using Business.Transfer;
using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business
{
    public class BusinessAccount
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        /*
        public Account getItem(string username , string password)
        {
            var resUser = database.Accounts.FirstOrDefault(x => x.username == username);
            var resPass = database.Accounts.FirstOrDefault(x => x.password == password);
            if(resUser == null || resPass == null)
            {
                return null;
            }
            return resPass; 
        }
        */

        public Account getItem(string username, string password)
        {
            var resUser = database.Accounts.FirstOrDefault(x => x.username == username);
            if (resUser == null || resUser.password != password)
            {
                return null;
            }
            return resUser;
        }

        public Account getItemById(int id)
        {
            return database.Accounts.FirstOrDefault(x => x.id == id);
        }


        public Account changePass(string username, string password)
        {
            try
            {
                var account = database.Accounts.FirstOrDefault(x => x.username == username);
                account.password = password;
                database.SaveChanges();
                return account;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Account> getList()
        {
            return database.Accounts.ToList();
        }

        public List<T_Account> getListTransfer()
        {
            var lsAccount = database.Accounts.
            Select(item => new T_Account
            {
                id = item.id,
                idStaff = (int)item.idStaff,
                username = item.username,
                nameStaff = database.Staffs.FirstOrDefault(x => x.id == item.idStaff).nameStaff
            }
            ).ToList();
            return lsAccount;
        }

        /*
        public List<T_Account> getListTransfer()
        {
            var lsAccount = database.Accounts.ToList();
            List<T_Account> lsACT = new List<T_Account>();
            T_Account ACT;
            foreach (var item in lsACT)
            {
                ACT = new T_Account();
                ACT.id = item.id;
                ACT.idStaff = item.idStaff;
                ACT.username = item.username;

                var ns = database.Staffs.FirstOrDefault(x => x.id == item.idStaff);
                ACT.nameStaff = ns.nameStaff;

                lsACT.Add(ACT);
            }
            return lsACT;
        }
        */
        /*
        public Account createAccount(Account ac)
        {
            try
            {
                database.Accounts.Add(ac);
                database.SaveChanges();
                return ac;
            }
            catch (Exception)
            {

                throw;
            }
        }
        */

        public bool createAccount(Account ac)
        {
            try
            {
                database.Accounts.Add(ac);
                database.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Account updateAccount(Account ac)
        {
            try
            {
                database.SaveChanges();
                return ac;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deleteAccount(int id)
        {
            try
            {
                var dt = database.Accounts.FirstOrDefault(x => x.id == id);
                if (dt != null)
                {
                    database.Accounts.Remove(dt);
                    database.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
