using Business.Transfer;
using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BangCongBusiness
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public BoardSalary getItem(int code)
        {
            return database.BoardSalaries.FirstOrDefault(x => x.code == code);
        }

        public List<BoardSalary> getList()
        {
            return database.BoardSalaries.ToList();
        }

        public List<BoardSalary> getListType()
        {
            return database.BoardSalaries.ToList();
        }

        public BoardSalary createBoardSalary(BoardSalary bs)
        {
            try
            {
                database.BoardSalaries.Add(bs);
                database.SaveChanges();
                return bs;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BoardSalary updateBoardSalary(BoardSalary bs)
        {
            try
            {
                var bsl = database.BoardSalaries.FirstOrDefault(x => x.code == bs.code);
                if(bsl != null)
                {
                    bsl.month = bs.month;
                    bsl.year = bs.year;
                    bsl.@lock = bs.@lock;
                    bsl.wordDay = bs.wordDay;
                    bsl.wordDayOfMonth = bs.wordDayOfMonth;
                    bsl.status = bs.status;
                }
                database.SaveChanges();
                return bs;
            }
            catch (Exception )
            {
                throw;
            }
        }
            
        public void deleteBoardSalary(int code)
        {
            try
            {
                var lsBC = database.BoardSalaryDes.Where(x => x.code == code).ToList();
                foreach (var item in lsBC)
                {
                    database.BoardSalaryDes.Remove(item);
                }
                var dt = database.BoardSalaries.FirstOrDefault(x => x.code == code);
                database.BoardSalaries.Remove(dt);
                database.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool checkData(int id)
        {
            try
            {
                var bh = database.BoardSalaries.FirstOrDefault(x => x.code == id);
                if(bh == null)
                {
                    return false;
                }
                else
                {
                    if (bh.status == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
