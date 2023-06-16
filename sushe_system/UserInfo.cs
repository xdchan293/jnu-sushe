using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sushe_system
{
    public static class UserInfo
    {
        public static string user_type { get; set; }
        public static string user_id { get; set; }
        public static string user_name { get; set; }
        public static string user_phone { get; set; }
        public static string manage_dorm { get; set; }

        public static string user_sex { get; set; }

        //登录之后把用户信息设定到这个静态类里边；
        public static void SetSuguanInfo(DataRow row)
        {
            user_type = row["user_type"].ToString();

            user_id = row["user_id"].ToString();

            user_name = row["user_name"].ToString();

            user_phone = row["user_phone"].ToString();

            manage_dorm = row["manage_dorm"].ToString();

            user_sex = row["user_sex"].ToString();
        }

        public static void SetShequInfo(DataRow row)
        {
            user_type = row["user_type"].ToString();

            user_id = row["user_id"].ToString();

            user_name = row["user_name"].ToString();

            user_phone = row["user_phone"].ToString();

            
        }
    }

   
}
