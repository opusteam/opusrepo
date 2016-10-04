using OPUS.Domain;
using OPUS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace OPUS.Common.Utils
{
    public class Utility
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public List<Menu> GetMenusByUserName(string username)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["OpusContext"].ToString());
            string sql = string.Format("select Menus.*,UserMenuMappings.UserName from Menus inner join UserMenuMappings on Menus.Id=UserMenuMappings.MenuId and UserMenuMappings.UserName='{0}'",username);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            List<Menu> listMenus = new List<Menu>();

            listMenus = new List<Menu>(
                (from dRow in dt.AsEnumerable()
                 select (GetMenuDataTableRow(dRow)))
                );

            return listMenus;
        }

        private Menu GetMenuDataTableRow(DataRow dr)
        {
            Menu ttype = new Menu();
            ttype.Id = Convert.ToInt32(dr["Id"]);
            ttype.Name = dr["Name"].ToString();
            ttype.ControllerName = dr["ControllerName"].ToString();
            ttype.ActionName = dr["ActionName"].ToString();
            ttype.AreaName = dr["AreaName"].ToString();
            return ttype;
        }

        public Feasibility UpdateFeasibility(Feasibility fr, FeasibilityViewModel feasibilityobj,int fId,string username)
        {
            
            fr.FeasiblityType = getValue(feasibilityobj.FeasiblityType.ToString());
            fr.ClientId = feasibilityobj.ClientId;
            fr.Requestdate = DateTime.Now;
            fr.Requestfor = getValue(feasibilityobj.Requestfor.ToString());

            fr.ConnectivityType = getValue(feasibilityobj.ConnectivityType.ToString());

            //ConnectionType is only for Passive Feasibility Request
            fr.ConnectionType = getValue(feasibilityobj.ConnectionType.ToString());
            fr.AddressOfClientLocationA = feasibilityobj.AddressOfClientLocationA;
            fr.LongitudeOfClientLocationA = feasibilityobj.LongitudeOfClientLocationA;
            fr.LatitudeOfClientLocationA = feasibilityobj.LatitudeOfClientLocationA;

            fr.AddressOfClientLocationB = feasibilityobj.AddressOfClientLocationB;
            fr.LongitudeOfClientLocationB = feasibilityobj.LongitudeOfClientLocationB;
            fr.LatitudeOfClientLocationB = feasibilityobj.LatitudeOfClientLocationB;

            fr.IsExistingInterfaceForLocationA = getValue(feasibilityobj.IsExistingInterfaceForLocationA.ToString());
            fr.IsExistingInterfaceForLocationB = getValue(feasibilityobj.IsExistingInterfaceForLocationB.ToString());

            fr.ServiceType = getValue(feasibilityobj.ServiceType.ToString());
            fr.RequiredCapacityQuantity = feasibilityobj.RequiredCapacityQuantity;
            fr.RequiredCapacityUnit = getValue(feasibilityobj.RequiredCapacityUnit.ToString());

            fr.InterfaceType = getValue(feasibilityobj.InterfaceType.ToString());
            fr.InterfaceTypeUnit = getValue(feasibilityobj.InterfaceTypeUnit.ToString());

            fr.InterfaceCategory = getValue(feasibilityobj.InterfaceCategory.ToString());
            //if InterfaceCategory == Ethernet_Layer_2
            fr.SubcategoryOfInterfaceCategory = getValue(feasibilityobj.SubcategoryOfInterfaceCategory.ToString());
            fr.ClientVLANID = feasibilityobj.ClientVLANID;

            fr.LastMileBy = getValue(feasibilityobj.LastMileBy.ToString());
            //If LastMileBy == SCL
            fr.LastMileServiceTypeOfLocationA = getValue(feasibilityobj.LastMileServiceTypeOfLocationA.ToString());
            fr.LastMileImplementationTypeOfLocationA = getValue(feasibilityobj.LastMileImplementationTypeOfLocationA.ToString());
            fr.LastMileServiceTypeOfLocationB = getValue(feasibilityobj.LastMileServiceTypeOfLocationB.ToString());
            fr.LastMileImplementationTypeOfLocationB = getValue(feasibilityobj.LastMileImplementationTypeOfLocationB.ToString());

            fr.KAMRemarks = feasibilityobj.KAMRemarks;
            fr.LastModifiedBy = username;
            fr.ModifiedDate = DateTime.Now;

            return fr;
        }

       

        private string getValue(string val)
        {

            int _val;
            if (int.TryParse(val, out _val))
            {
                _val = 0;
            }
            else { _val = 1; }

            if (_val == 0)
            {
                return null;
            }
            else
            {

                return val;
            }
        }

        public Feasibility GetFeasibilityObject(FeasibilityViewModel feasibilityobj,string username)
        {
            Feasibility fr = new Feasibility();
            fr.FeasiblityType = getValue(feasibilityobj.FeasiblityType.ToString());
            fr.ClientId = feasibilityobj.ClientId;
            fr.Requestdate = DateTime.Now;
            fr.Requestfor = getValue(feasibilityobj.Requestfor.ToString());

            fr.ConnectivityType = getValue(feasibilityobj.ConnectivityType.ToString());

            //ConnectionType is only for Passive Feasibility Request
            fr.ConnectionType = getValue(feasibilityobj.ConnectionType.ToString());
            fr.AddressOfClientLocationA = feasibilityobj.AddressOfClientLocationA;
            fr.LongitudeOfClientLocationA = feasibilityobj.LongitudeOfClientLocationA;
            fr.LatitudeOfClientLocationA = feasibilityobj.LatitudeOfClientLocationA;

            fr.AddressOfClientLocationB = feasibilityobj.AddressOfClientLocationB;
            fr.LongitudeOfClientLocationB = feasibilityobj.LongitudeOfClientLocationB;
            fr.LatitudeOfClientLocationB = feasibilityobj.LatitudeOfClientLocationB;

            fr.IsExistingInterfaceForLocationA = getValue(feasibilityobj.IsExistingInterfaceForLocationB.ToString());
            fr.ServiceType = getValue(feasibilityobj.ServiceType.ToString());
            fr.RequiredCapacityQuantity = feasibilityobj.RequiredCapacityQuantity;
            fr.RequiredCapacityUnit = getValue(feasibilityobj.RequiredCapacityUnit.ToString());

            fr.InterfaceType = getValue(feasibilityobj.InterfaceType.ToString());
            fr.InterfaceTypeUnit = getValue(feasibilityobj.InterfaceTypeUnit.ToString());

            fr.InterfaceCategory = getValue(feasibilityobj.InterfaceCategory.ToString());
            //if InterfaceCategory == Ethernet_Layer_2
            fr.SubcategoryOfInterfaceCategory = getValue(feasibilityobj.SubcategoryOfInterfaceCategory.ToString());
            fr.ClientVLANID = feasibilityobj.ClientVLANID;

            fr.LastMileBy = getValue(feasibilityobj.LastMileBy.ToString());
            //If LastMileBy == SCL
            fr.LastMileServiceTypeOfLocationA = getValue(feasibilityobj.LastMileServiceTypeOfLocationA.ToString());
            fr.LastMileImplementationTypeOfLocationA = getValue(feasibilityobj.LastMileImplementationTypeOfLocationA.ToString());
            fr.LastMileServiceTypeOfLocationB = getValue(feasibilityobj.LastMileServiceTypeOfLocationB.ToString());
            fr.LastMileImplementationTypeOfLocationB = getValue(feasibilityobj.LastMileImplementationTypeOfLocationB.ToString());

            fr.LastModifiedBy = username;
            fr.ModifiedDate = DateTime.Now;

            return fr;
        }



        //++++===============HR-Functionalities++++================================
        public List<Holiday> GetListOfWeeklyHolidays(string _weeklyHoliday, int year, int holidaytype, string description)
        {
            List<DateTime[]> holidays = new List<DateTime[]>();
            DateTime beginDate = new DateTime(year, 01, 01);
            DateTime endDate = new DateTime(year + 1, 01, 01);

            DateTime _holiday = DateTime.Today;

            while (beginDate < endDate)
            {
                beginDate = beginDate.AddDays(1);

                if (beginDate.DayOfWeek.ToString() == _weeklyHoliday)
                {
                    _holiday = beginDate;
                    holidays.Add(new DateTime[] { _holiday });
                }

            }

            List<Holiday> holidaylist = new List<Holiday>();
            Holiday hday = new Holiday();
            foreach (var holiday in holidays)
            {
                hday = new Holiday();
                hday.holidaytype = holidaytype;
                hday.Date = Convert.ToDateTime(holiday[0]);
                hday.Description = description;
                holidaylist.Add(hday);
            }

            return holidaylist;

        }

        public List<Holiday> GovtAndOtherHolidays(VWMGovtAndOtherHoliday _govtandotherholidays)
        {
            DateTime _startDate = _govtandotherholidays.DateFrm;
            DateTime _endDate = _govtandotherholidays.DateTo;

            List<Holiday> holidaylist = new List<Holiday>();
            Holiday hday = new Holiday();
            while (_startDate <= _endDate)
            {
                hday = new Holiday();
                hday.holidaytype = _govtandotherholidays.HolidayType;
                hday.Date = _startDate;
                hday.Description = _govtandotherholidays.Description;
                holidaylist.Add(hday);
                _startDate = _startDate.AddDays(1);
            }

            return holidaylist;
        }
        //++++===============End Of HR-Functionalities++++================================


        //+++++++++++================SLA  Functionalities +++++++++++++++++===============

        public VWMSLAExpiredInfo SLAEndDateAndTime(VMAssignedSLA _slaObj, DateTime _slaResponseDateTime)
        {
            VWMSLAExpiredInfo _slaexpInfo = new VWMSLAExpiredInfo();
            double _allotedHours = _slaObj._SLARule.SLAValueInHours;
            TimeSpan _SLAStartTime = _slaObj.StartDateTime.TimeOfDay;
            DateTime _SLAStartdate = _slaObj.StartDateTime;
            OfficeHour _officeHour = this.GetOfficeWorkingHourByDate(_SLAStartdate);
            double _assignedDayWorkingHoursLeft = ((_SLAStartdate.Date + _officeHour.EndAt) - _SLAStartdate).TotalHours;
            if (_allotedHours <= _assignedDayWorkingHoursLeft)
            {
                TimeSpan EndTime = this.AddHours(_SLAStartTime, _allotedHours);
                TimeSpan TimeLeft = EndTime - DateTime.Now.TimeOfDay;
                TimeSpan TimePast = DateTime.Now.TimeOfDay - _SLAStartTime;
                DateTime enddatetime = _SLAStartdate + EndTime;
                _slaexpInfo.SLAId = _slaObj.SLAId;
                _slaexpInfo.SLAEndDateTime = enddatetime;
                _slaexpInfo.SLAResponseDateTime = _slaResponseDateTime;
                _slaexpInfo.TimeLeftActual = TimeLeft;
                _slaexpInfo.TimePastActual = TimePast;

                TimeSpan _ts = new TimeSpan(0, 0, 0, 0, 0);

                if (TimeLeft < _ts)
                {
                    _slaexpInfo.Status = SLAStatusEnum.FailToMeet.ToString();
                }
                else
                {
                    _slaexpInfo.Status = SLAStatusEnum.Meet.ToString();
                }
                return _slaexpInfo;
            }
            else
            {
                //double _hoursOtherThanAssignedDay = _allotedHours - _assignedDayWorkingHoursLeft;
                //double remainderHoursOtherThanFullDay = _hoursOtherThanAssignedDay % 8;
                //int daysOtherThanAssignedDay = Convert.ToInt32((_hoursOtherThanAssignedDay - remainderHoursOtherThanFullDay) / 8);

                _slaexpInfo = GetProjectedSLAEndInfo(_slaObj, _assignedDayWorkingHoursLeft, _slaResponseDateTime);

            }

            string dayName = _SLAStartdate.DayOfWeek.ToString();
            OfficeWorkingDay _workingday = this.GetOfficeWorkingdayObjByWorkingDayName(dayName);

            return _slaexpInfo;
        }

        private VWMSLAExpiredInfo GetProjectedSLAEndInfo(VMAssignedSLA _slaObj, double _assignedDayWorkingHoursLeft, DateTime _slaResponseDateTime)
        {
            bool isCalculationFinished = false;
            double _HoursPast = 0, _HoursLeft = 0;
            double allotedHours = _slaObj._SLARule.SLAValueInHours;
            double _remainingAllotedHours = 0;
            double _ConsumedHours = 0;
            TimeSpan _SLAStartTime = _slaObj.StartDateTime.TimeOfDay;
            DateTime _SLAStartdate = _slaObj.StartDateTime;
            DateTime NextWorkingDay = _SLAStartdate;

            _remainingAllotedHours = allotedHours - _assignedDayWorkingHoursLeft;

            while (!isCalculationFinished)
            {
                NextWorkingDay = GetNextWorkingDay(NextWorkingDay.AddDays(1));
                if ((_remainingAllotedHours - _ConsumedHours) >= 8 && NextWorkingDay.DayOfWeek.ToString() != WeekDaysEnum.Friday.ToString())
                {
                    _ConsumedHours = _ConsumedHours + 8;

                }
                else if ((_remainingAllotedHours - _ConsumedHours) >= 8 && NextWorkingDay.DayOfWeek.ToString() == WeekDaysEnum.Friday.ToString())
                {
                    _ConsumedHours = _ConsumedHours + 4;
                }
                else if ((_remainingAllotedHours - _ConsumedHours) <= 4 && NextWorkingDay.DayOfWeek.ToString() == WeekDaysEnum.Friday.ToString())
                {
                    _ConsumedHours = _ConsumedHours + 4;
                }
                else
                {
                    _ConsumedHours = _ConsumedHours + (allotedHours - _ConsumedHours);
                }

                if (_ConsumedHours == _remainingAllotedHours || _ConsumedHours> _remainingAllotedHours) isCalculationFinished = true;

                if (NextWorkingDay.Date == DateTime.Now.Date)
                {
                    _HoursPast = _ConsumedHours + _assignedDayWorkingHoursLeft;
                    if (_HoursPast > allotedHours) _HoursPast = allotedHours;
                    _HoursLeft = allotedHours - _HoursPast;
                }else
                {
                    _HoursPast = (DateTime.Now - _SLAStartdate).TotalHours;
                    if (_HoursPast > allotedHours) _HoursPast = allotedHours;
                    _HoursLeft = (NextWorkingDay - DateTime.Now).TotalHours;
                }

            }

            TimeSpan _ts = new TimeSpan(0, 0, 0, 0, 0);

            TimeSpan remainingTime = NextWorkingDay - DateTime.Now;

            VWMSLAExpiredInfo _VWMSLAExpiredInfo = new VWMSLAExpiredInfo();
            _VWMSLAExpiredInfo.SLAId = _slaObj.SLAId;
            _VWMSLAExpiredInfo.SLAStartDateTime = _slaObj.StartDateTime;
            _VWMSLAExpiredInfo.TimePastInHours = _HoursPast;
            _VWMSLAExpiredInfo.TimeLeftInHours = _HoursLeft;
            _VWMSLAExpiredInfo.TimeLeftGross = remainingTime;
            _VWMSLAExpiredInfo.GrossTimeLeftString = remainingTime.Days.ToString() + " days " + remainingTime.Hours.ToString() + " hours " + remainingTime.Minutes.ToString() + " minutes " + remainingTime.Seconds.ToString() + " seconds ";
            _VWMSLAExpiredInfo.SLAEndDateTime = NextWorkingDay;
            _VWMSLAExpiredInfo.SLAResponseDateTime = _slaResponseDateTime;

            if (remainingTime < _ts)
            {
                _VWMSLAExpiredInfo.Status = SLAStatusEnum.FailToMeet.ToString();
            }
            else
            {
                _VWMSLAExpiredInfo.Status = SLAStatusEnum.Meet.ToString();
            }

            return _VWMSLAExpiredInfo;
        }



        private DateTime GetNextWorkingDay(DateTime _workingDay)
        {
            DateTime workingday = _workingDay;
            if (IsWorkingDay(workingday.Date))
            {
                workingday = _workingDay;
            }
            else
            {
                workingday = _workingDay.AddDays(1);
                GetNextWorkingDay(workingday);
            }

            return workingday;
        }

        private bool IsWorkingDay(DateTime _workingDay)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["OpusContext"].ToString());
            string sql = string.Format("select * from Holidays Where Date='{0}'", _workingDay);
            cmd = new SqlCommand(sql, con);
            con.Open();
            try
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0) return false;
                return true;
            }
            catch
            {
                return true;
            }
            finally
            {
                con.Close();
            }



        }

        private TimeSpan AddHours(TimeSpan _CurrentTime, double hoursToAdd)
        {
            TimeSpan endSpan = _CurrentTime + TimeSpan.FromHours(hoursToAdd);
            return endSpan;
        }

        private OfficeHour GetOfficeWorkingHourByDate(DateTime _date)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["OpusContext"].ToString());
            string sql = string.Format("Select * from OfficeHours Where '{0}' >= DateFrom and '{1}' <= DateTo and SLAYear={2}", _date, _date, _date.Year);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            return GetOfficeHourDataTableRow(dt.Rows[0], _date);
        }

        private OfficeHour GetOfficeHourDataTableRow(DataRow dr, DateTime _date)
        {
            OfficeHour _officeHour = new OfficeHour();
            _officeHour.Id = Convert.ToInt32(dr["Id"]);
            _officeHour.OfficeWorkingDayTypeId = Convert.ToInt32(dr["OfficeWorkingDayTypeId"]);
            _officeHour.StartAt = (TimeSpan)dr["StartAt"];
            _officeHour.EndAt = (TimeSpan)dr["EndAt"];
            _officeHour.DateFrom = Convert.ToDateTime(dr["DateFrom"]);
            _officeHour.DateTo = Convert.ToDateTime(dr["DateTo"]);
            _officeHour.SLAYear = Convert.ToInt32(dr["SLAYear"]);
            return _officeHour;
        }

        private OfficeWorkingDay GetOfficeWorkingdayObjByWorkingDayName(string dayName)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["OpusContext"].ToString());
            string sql = string.Format("select * from OfficeWorkingDays Where Name='{0}'", dayName);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            return GetOfficeWorkingDataTableRow(dt.Rows[0]);
        }

        private OfficeWorkingDay GetOfficeWorkingDataTableRow(DataRow dr)
        {
            OfficeWorkingDay _wday = new OfficeWorkingDay();
            _wday.Id = Convert.ToInt32(dr["Id"]);
            _wday.Name = dr["Name"].ToString();
            _wday.WorkingHours = Convert.ToDouble(dr["WorkingHours"]);

            return _wday;
        }


        public List<VWMSLAExpiredInfo> GetDashBoardSLAListByDepartment(string _departmentname)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["OpusContext"].ToString());
            string sql = string.Format(@"select AssignedSLAs.Id,AssignedSLAs.SLARuleId,AssignedSLAs.EventId,AssignedSLAs.StartDateTime,AssignedSLAs.ResponseDatetime,AssignedSLAs.Status,SLARuleSets.SLAKey from 
                                       AssignedSLAs inner join SLARuleSets on AssignedSLAs.SLARuleId=SLARuleSets.Id Where AssignedSLAs.Status='Running' and AssignedSLAs.OwnerDepartment='{0}'", _departmentname);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            List<VWMSLAExpiredInfo> listAssignedSLAS = new List<VWMSLAExpiredInfo>();

            listAssignedSLAS = new List<VWMSLAExpiredInfo>(
                (from dRow in dt.AsEnumerable()
                 select (GetSLAExpireTableRow(dRow)))
                );

            return listAssignedSLAS;
        }

        private VWMSLAExpiredInfo GetSLAExpireTableRow(DataRow dr)
        {
            VMAssignedSLA sla = new VMAssignedSLA();
            sla.SLAId = Convert.ToInt32(dr["Id"]);
            sla.SLARuleId = Convert.ToInt32(dr["SLARuleId"]);
            sla.EventId = Convert.ToInt32(dr["EventId"]);
            sla._SLARule = getSLARuleById(Convert.ToInt32(dr["SLARuleId"]));
            sla.StartDateTime = Convert.ToDateTime(dr["StartDateTime"]);
            sla.ResponseDatetime = GetResponseTime(dr["ResponseDatetime"]);
            sla.Status = dr["Status"].ToString();
            // sla.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            //sla.CreatedBy= dr["CreatedBy"].ToString();
            VWMSLAExpiredInfo _slaExpiredInfo = new Utility().SLAEndDateAndTime(sla, DateTime.Now);
            return _slaExpiredInfo;
        }

        public SLARuleSet getSLARuleById(int sLARuleId)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["OpusContext"].ToString());
            string sql = string.Format("select * from SLARuleSets Where Id={0}", sLARuleId);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            return GetSLARuleDataTableRow(dt.Rows[0]);
        }

        private SLARuleSet GetSLARuleDataTableRow(DataRow dr)
        {
            SLARuleSet _ruleSet = new SLARuleSet();
            _ruleSet.Id = Convert.ToInt32(dr["Id"]);
            _ruleSet.InitiatorDepartment = dr["InitiatorDepartment"].ToString();
            _ruleSet.ResponsibleDepartment = dr["ResponsibleDepartment"].ToString();
            _ruleSet.SLAKey = dr["SLAKey"].ToString();
            _ruleSet.SLAValueInHours = Convert.ToDouble(dr["SLAValueInHours"]);
            _ruleSet.SLAKeyDescription = dr["SLAKeyDescription"].ToString();
            _ruleSet.ProcessName = dr["ProcessName"].ToString();

            return _ruleSet;
        }

        public VMAssignedSLA getSLAByEventIdAndTrype(int eventId, string eventType)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["OpusContext"].ToString());
            string sql = string.Format("select AssignedSLAs.Id,AssignedSLAs.SLARuleId,AssignedSLAs.EventId,AssignedSLAs.StartDateTime,AssignedSLAs.ResponseDatetime,AssignedSLAs.Status,SLARuleSets.SLAKey from AssignedSLAs inner join SLARuleSets on AssignedSLAs.SLARuleId=SLARuleSets.Id Where EventId={0} and SLARuleSets.SLAKey='{1}'", eventId, eventType);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            return GetSLADataTableRow(dt.Rows[0]);
        }

        private VMAssignedSLA GetSLADataTableRow(DataRow dr)
        {
            VMAssignedSLA sla = new VMAssignedSLA();
            sla.SLAId = Convert.ToInt32(dr["Id"]);
            sla.SLARuleId = Convert.ToInt32(dr["SLARuleId"]);
            sla.EventId = Convert.ToInt32(dr["EventId"]);
            sla._SLARule = getSLARuleById(Convert.ToInt32(dr["SLARuleId"]));
            sla.StartDateTime = Convert.ToDateTime(dr["StartDateTime"]);
            sla.ResponseDatetime = GetResponseTime(dr["ResponseDatetime"]);
            sla.Status = dr["Status"].ToString();
            // sla.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            //sla.CreatedBy= dr["CreatedBy"].ToString();

            return sla;
        }

        private DateTime? GetResponseTime(object val)
        {
            if (val == DBNull.Value)
            {
                return null;
            }
            else
            {
                return Convert.ToDateTime(val);
            }
        }

        public AssignedSLA GetSLAObject(int ruleId, int eventId, string _department, string username)
        {
            AssignedSLA _asla = new AssignedSLA();
            _asla.SLARuleId = ruleId;
            _asla.EventId = eventId;
            _asla.StartDateTime = DateTime.Now;
            _asla.OwnerDepartment = _department;
            _asla.CreateDate = DateTime.Now;
            _asla.CreatedBy = username;

            return _asla;
        }

        public void UpdateAssignedSLAStatus(VWMSLAExpiredInfo sLAExpiredInfo)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["OpusContext"].ToString());
            string sql = string.Format("Update AssignedSLAs Set ResponseDatetime='{0}',Status='{1}' Where Id={2}", sLAExpiredInfo.SLAResponseDateTime, sLAExpiredInfo.Status, sLAExpiredInfo.SLAId);
            cmd = new SqlCommand(sql, con);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}
