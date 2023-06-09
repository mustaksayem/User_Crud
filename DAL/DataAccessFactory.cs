﻿using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User,string,User> UserData()
        {
            return new UserRepo();
        }

        public static IRepo<Movie, int, bool> MovieData()
        {
            return new MovieRepo();
        }
        public static IRepo<Admin, string, Admin> AdminData()
        {
            return new AdminRepo();
        }

        public static IRepo<HallStaff, string, HallStaff> HallStaffData()
        {
            return new AdminRepo1();
        }

        public static IAuth<bool> AuthData()
        {
            return new AdminRepo();
        }
        public static IRepo<AdminToken, string, AdminToken> AdminTokenData()
        {
            return new AdminTokenRepo();
        }

        public static IRepo<Hall, string, Hall> HallData()
        {
            return new HallRepo();
        }

        public static IRepo<Circular, string, Circular> CircularData()
        {
            return new CircularRepo();
        }
        public static IBlockUser<User, string> BlockUsertData()
        {
            return new BlockUser();
        }

        public static IActiveUser<User, string> ActiveUsertData()
        {
            return new ActiveUser();
        }

        public static IRepo<Notice, int, Notice> NoticeDataAccess()
        {
            return new NoticeRepo();
        }

    }
}
