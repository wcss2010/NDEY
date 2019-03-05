using System;
using System.Collections.Generic;
using System.Text;
using NDEY.BLL.Dao;
using NDEY.BLL.Entity;

namespace NDEY.BLL.Service
{
    public class UnitInforService
    {
        private UnitInforDao _unitInforDao = new UnitInforDao();

        public IList<UnitInfor> GetUnitInforList()
        {
            return _unitInforDao.GetUnitInforList();
        }

        public IList<UnitInfor> GetUnitInforList(string[] idList)
        {
            return _unitInforDao.GetUnitInforList(idList);
        }

        public bool UpdateUnitInfors(IList<UnitInfor> list)
        {
            foreach (UnitInfor current in list)
            {
                if (string.IsNullOrEmpty(current.ID))
                {
                    current.ID = Guid.NewGuid().ToString();
                    this._unitInforDao.Add(current);
                }
                else
                {
                    this._unitInforDao.Update(current);
                }
            }
            return true;
        }

        public bool DeleteUnitInfors(IList<string> list)
        {
            foreach (string current in list)
            {
                this._unitInforDao.DeleteUnitInfor(current);
            }
            return true;
        }
    }
}