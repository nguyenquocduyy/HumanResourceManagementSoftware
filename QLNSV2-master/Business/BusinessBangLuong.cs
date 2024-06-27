using Business.Transfer;
using DataObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessBangLuong
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public PayRoll getItem(int code , int idStaff)
        {
            return database.PayRolls.FirstOrDefault(x => x.code == code && x.idStaff == idStaff);
        }

        public List<PayRoll> getList(int code)
        {
            return database.PayRolls.Where(x => x.code == code).ToList();
        }

        public List<T_BangLuong> getItemTransferPrint(int code, int idStaff)
        {
            var lsNV = database.PayRolls.Where(x => x.code == code && x.idStaff == idStaff).ToList();
            List<T_BangLuong> lsHDT = new List<T_BangLuong>();
            T_BangLuong payRoll;
            foreach (var item in lsNV)
            {
                payRoll = new T_BangLuong();
                payRoll.id = item.id;
                payRoll.idStaff = item.idStaff;
                payRoll.code = item.code;
                payRoll.salary = item.salary;
                payRoll.wordDay = item.wordDay;
                payRoll.dayOff = item.dayOff;
                payRoll.allowance = item.allowance;
                payRoll.withofleave = item.withofleave;
                payRoll.totalDayOfMonth = item.totalDayOfMonth;
                payRoll.overTime = item.overTime;

                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                var position = database.Positions.FirstOrDefault(rs => rs.id == nv.idPosition);
                var contract = database.Contracts.FirstOrDefault(x => x.idStaff == item.idStaff);
                var department = database.Departments.FirstOrDefault(rs => rs.id == nv.idRoom);
                

                payRoll.nameStaff = nv.nameStaff;
                payRoll.totalSalary = contract.salary;
                payRoll.basicSalary = luongCoBan();

                payRoll.nameDepartment = department.nameDepartment;
                payRoll.namePosition = position.namePosition;
                payRoll.bankNumber = nv.bankNumber;
                lsHDT.Add(payRoll);
            }
            return lsHDT;
        }

        public List<T_BangLuong> getListTransfer(int id)
        {
            var lsNV = database.PayRolls.Where(x => x.code == id).ToList();
            List<T_BangLuong> lsHDT = new List<T_BangLuong>();
            T_BangLuong HDT;
            foreach (var item in lsNV)
            {
                HDT = new T_BangLuong();
                HDT.id = item.id;
                HDT.idStaff = item.idStaff;
                HDT.code = item.code;
                HDT.salary = item.salary;
                HDT.wordDay = item.wordDay;
                HDT.dayOff = item.dayOff;
                HDT.allowance = item.allowance;
                HDT.withofleave = item.withofleave;
                HDT.totalDayOfMonth = item.totalDayOfMonth;
                HDT.overTime = item.overTime;

                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                var position = database.Positions.FirstOrDefault(rs => rs.id == nv.idPosition);
                var contract = database.Contracts.FirstOrDefault(x => x.idStaff == item.idStaff);
                var department = database.Departments.FirstOrDefault(rs => rs.id == nv.idRoom);

                HDT.nameStaff = nv.nameStaff;
                HDT.totalSalary = contract.salary;
                HDT.basicSalary = luongCoBan();

                HDT.nameDepartment = department.nameDepartment;
                HDT.namePosition = position.namePosition;
                HDT.bankNumber = nv.bankNumber;
                lsHDT.Add(HDT);
            }
            return lsHDT;
        }


        public PayRoll createPayRoll(PayRoll bs)
        {
            try
            {
                database.PayRolls.Add(bs);
                database.SaveChanges();
                return bs;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string PhuCap(int MaHV)
        {
            String Query = String.Format("EXEC pro_get_allowance @idStaff = {0}", MaHV);
            DataTable data = Common.Instance.InstanceLo.ExecuteQuery(Query);
            DataRow item = data.Rows[0];
            string phuCap = item.ItemArray[0].ToString();
            return (phuCap == "") ? "0" : phuCap;
        }

        public double luongCoBan()
        {
            String Query = String.Format("SELECT basicSalary FROM SystemCTL");
            DataTable data = Common.Instance.InstanceLo.ExecuteQuery(Query);
            DataRow item = data.Rows[0];
            return (double)item.ItemArray[0];
        }


        public void caculator(int code)
        {
            try
            {
                var lstStaff = database.Staffs.Where(x => x.status == true).ToList();
                foreach (var staff in lstStaff)
                {
                    
                    var contract = database.Contracts.FirstOrDefault(x => x.idStaff == staff.id);
                    var boardSalary = database.BoardSalaryDes.FirstOrDefault(x => x.code == code && x.idStaff == staff.id);
                    var totalSalary = contract.salary;
                    var totalWorkDay = boardSalary.totalWordDay;
                    var workDay = boardSalary.wordDay;
                    var dayOff = boardSalary.dayOff;
                    var withoutLeave = boardSalary.withoutLeave;
                    var overTime = boardSalary.giotangca + (boardSalary.NLvaCN * 8);
                    var otNormalDayCount = (double)boardSalary.giotangca / 8;
                    var otOffDayCount = boardSalary.NLvaCN;

                    double basicSalary = luongCoBan();
                    double allowance = double.Parse(PhuCap(staff.id));
                    double salaryOneDay = (double)((totalSalary + allowance) / totalWorkDay);
                    double workDayCount = (double)dayOff + (double)workDay;
                    double salary = (double)(workDayCount * Math.Round(salaryOneDay,2));
                    double otNormalDay = (double)otNormalDayCount * (salaryOneDay * 1.5);
                    double otOffDay = (double)otOffDayCount * (salaryOneDay * 2);
                    double otSalary = otNormalDay + otOffDay;
                    double insurance = 0.105 * basicSalary;
                    double salaryPay = salary + Math.Round(otSalary, 2) - insurance;
      
                    PayRoll payRoll = new PayRoll();
                    payRoll.idStaff = staff.id;
                    payRoll.code = code;
                    payRoll.salary = Math.Round(salaryPay, 2);
                    payRoll.wordDay = workDay;
                    payRoll.dayOff = dayOff;
                    payRoll.allowance = allowance;
                    payRoll.withofleave = withoutLeave;
                    payRoll.totalDayOfMonth = (int?)totalWorkDay;
                    payRoll.overTime = overTime;
                    
                    
                    createPayRoll(payRoll);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public void deletePayroll(int code)
        {
            try
            {
                var lsNV = database.PayRolls.Where(x => x.code == code).ToList();
                foreach (var item in lsNV)
                {
                    database.PayRolls.Remove(item);
                }
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }

        public string textchange(int manv)
        {
            var nv = database.Staffs.FirstOrDefault(rs => rs.id == manv);
            if (nv == null)
            {
                return "";
            }
            else
            {
                return nv.nameStaff;
            }
            
        }
    }
}
