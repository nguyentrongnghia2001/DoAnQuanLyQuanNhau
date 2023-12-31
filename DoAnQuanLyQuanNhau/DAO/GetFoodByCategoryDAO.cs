﻿using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyQuanNhau.DAO
{
    public class GetFoodByCategoryDAO
    {
        private static GetFoodByCategoryDAO instance;
        public static GetFoodByCategoryDAO Instance
        {
            get { if (instance == null) instance = new GetFoodByCategoryDAO(); return GetFoodByCategoryDAO.instance; }
            private set { GetFoodByCategoryDAO.instance = value; }
        }

        private GetFoodByCategoryDAO() { }

        public List<GetFoodByCategory> GetListFood()
        {
            List<GetFoodByCategory> list = new List<GetFoodByCategory>();

            string query = "SELECT f.id, fc.id as id_category, fc.name AS name_category, f.name, f.price FROM Food AS f JOIN FoodCategory AS fc ON f.id_category = fc.id WHERE f.status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                GetFoodByCategory f = new GetFoodByCategory(item);
                list.Add(f);
            }

            return list;
        }

        public List<GetFoodByCategory> SearchFoodByName(string name)
        {

            List<GetFoodByCategory> list = new List<GetFoodByCategory>();

            string query = string.Format("SELECT f.id, fc.id as id_category, fc.name AS name_category, f.name, f.price FROM Food AS f JOIN FoodCategory AS fc ON f.id_category = fc.id WHERE f.status = 1 AND dbo.fuConvertToUnsign1(f.name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            //string query = string.Format("SELECT * FROM dbo.Food WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                GetFoodByCategory food = new GetFoodByCategory(item);
                list.Add(food);
            }

            return list;
        }
    }
}
