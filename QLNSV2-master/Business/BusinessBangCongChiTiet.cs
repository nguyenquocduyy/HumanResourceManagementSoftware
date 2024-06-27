using Business.Transfer;
using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessBangCongChiTiet
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public BoardSalaryDe getItem(int code , int idStaff)
        {
            return database.BoardSalaryDes.FirstOrDefault(x=> x.code == code && x.idStaff == idStaff);
        }

        private int GetDayNumber(int thang, int nam)
        {
            int dayNumber = 0;
            switch (thang)
            {
                case 2:
                    dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumber = 30;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumber = 31;
                    break;
            }

            return dayNumber;
        }

        public void phatSinhboardSalaryDe( int thang, int nam)
        {
            var lstNV = database.Staffs.Where(x => x.status == true).ToList();
            if (lstNV.Count == 0) return;
            foreach (var item in lstNV)
            {
                List<string> D = new List<string>();

                for (int j = 1; j <= GetDayNumber(thang, nam); j++)
                {
                    DateTime newDate = new DateTime(nam, thang, j);

                    switch (newDate.DayOfWeek.ToString())
                    {
                        case "Sunday":
                            D.Add("CN");
                            break;
                        //case "Saturday":
                        //    D.Add("T7");
                        //    break;
                        default:
                            D.Add("8");
                            break;
                    }
                }

                switch (D.Count)
                {
                    case 28:
                        D.Add("");
                        D.Add("");
                        D.Add("");
                        break;
                    case 29:
                        D.Add("");
                        D.Add("");
                        break;
                    case 30:
                        D.Add("");
                        break;
                }

                BoardSalaryDe boardSalaryDe = new BoardSalaryDe();
                boardSalaryDe.code = nam * 100 + thang;
                boardSalaryDe.idStaff = item.id;
                boardSalaryDe.nameStaff = item.nameStaff;
                //boardSalaryDe.codeCompany = item.MACTY;
                boardSalaryDe.D1 = D[0];
                boardSalaryDe.D2 = D[1];
                boardSalaryDe.D3 = D[2];
                boardSalaryDe.D4 = D[3];
                boardSalaryDe.D5 = D[4];
                boardSalaryDe.D6 = D[5];
                boardSalaryDe.D7 = D[6];
                boardSalaryDe.D8 = D[7];
                boardSalaryDe.D9 = D[8];
                boardSalaryDe.D10 = D[9];
                boardSalaryDe.D11 = D[10];
                boardSalaryDe.D12 = D[11];
                boardSalaryDe.D13 = D[12];
                boardSalaryDe.D14 = D[13];
                boardSalaryDe.D15 = D[14];
                boardSalaryDe.D16 = D[15];
                boardSalaryDe.D17 = D[16];
                boardSalaryDe.D18 = D[17];
                boardSalaryDe.D19 = D[18];
                boardSalaryDe.D20 = D[19];
                boardSalaryDe.D21 = D[20];
                boardSalaryDe.D22 = D[21];
                boardSalaryDe.D23 = D[22];
                boardSalaryDe.D24 = D[23];
                boardSalaryDe.D25 = D[24];
                boardSalaryDe.D26 = D[25];
                boardSalaryDe.D27 = D[26];
                boardSalaryDe.D28 = D[27];
                boardSalaryDe.D29 = D[28];
                boardSalaryDe.D30 = D[29];
                boardSalaryDe.D31 = D[30];

                boardSalaryDe.month = thang;
                boardSalaryDe.year = nam;
                boardSalaryDe.wordDay = Common.common.GetWordDay(thang, nam);
                boardSalaryDe.totalWordDay = Common.common.GetWordDay(thang, nam);
                boardSalaryDe.dayOff = 0;
                boardSalaryDe.withoutLeave = 0;
                boardSalaryDe.giotangca = 0;
                boardSalaryDe.NLvaCN = 0;
                database.BoardSalaryDes.Add(boardSalaryDe);
                database.SaveChanges();
            }

        }
        public BoardSalaryDe updateSalaryDe(BoardSalaryDe boardSalaryDe)
        {
           
                BoardSalaryDe boardSalaryDeUpdate = database.BoardSalaryDes.FirstOrDefault(x => x.code == boardSalaryDe.code && x.idStaff == boardSalaryDe.idStaff);
                
                boardSalaryDe.D1 = boardSalaryDe.D1;
                boardSalaryDe.D2 = boardSalaryDe.D2;
                boardSalaryDe.D3 = boardSalaryDe.D3;
                boardSalaryDe.D4 = boardSalaryDe.D4;
                boardSalaryDe.D5 = boardSalaryDe.D5;
                boardSalaryDe.D6 = boardSalaryDe.D6;
                boardSalaryDe.D7 = boardSalaryDe.D7;
                boardSalaryDe.D8 = boardSalaryDe.D8;
                boardSalaryDe.D9 = boardSalaryDe.D9;
                boardSalaryDe.D10 = boardSalaryDe.D10;
                boardSalaryDe.D11 = boardSalaryDe.D11;
                boardSalaryDe.D12 = boardSalaryDe.D12;
                boardSalaryDe.D13 = boardSalaryDe.D13;
                boardSalaryDe.D14 = boardSalaryDe.D14;
                boardSalaryDe.D15 = boardSalaryDe.D15;
                boardSalaryDe.D16 = boardSalaryDe.D16;
                boardSalaryDe.D17 = boardSalaryDe.D17;
                boardSalaryDe.D18 = boardSalaryDe.D18;
                boardSalaryDe.D19 = boardSalaryDe.D19;
                boardSalaryDe.D20 = boardSalaryDe.D20;
                boardSalaryDe.D21 = boardSalaryDe.D21;
                boardSalaryDe.D22 = boardSalaryDe.D22;
                boardSalaryDe.D23 = boardSalaryDe.D23;
                boardSalaryDe.D24 = boardSalaryDe.D24;
                boardSalaryDe.D25 = boardSalaryDe.D25;
                boardSalaryDe.D26 = boardSalaryDe.D26;
                boardSalaryDe.D27 = boardSalaryDe.D27;
                boardSalaryDe.D28 = boardSalaryDe.D28;
                boardSalaryDe.D29 = boardSalaryDe.D29;
                boardSalaryDe.D30 = boardSalaryDe.D30;
                boardSalaryDe.D31 = boardSalaryDe.D31;
                boardSalaryDe.dayOff = boardSalaryDe.dayOff;
                boardSalaryDe.withoutLeave = boardSalaryDe.withoutLeave;
                boardSalaryDe.totalWordDay = boardSalaryDe.totalWordDay;
                
                database.SaveChanges();
                return boardSalaryDe;
            

        }
        public List<BoardSalaryDe> getList(int code)
        {
            return database.BoardSalaryDes.Where(x => x.code == code).ToList();
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

        
    }
}
