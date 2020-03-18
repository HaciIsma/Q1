﻿using Q1.Data;
using Q1.Model;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Q1.Service
{
    public class DBService
    {
        static DBService()
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                appDB.Database.EnsureCreated();
            }
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                return appDB.Users.FirstOrDefault(filter);
            }
        }

        public void Add(User user)
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                appDB.Add(user);
                appDB.SaveChanges();
            }
        }

        public bool Search(Expression<Func<User, bool>> filter)
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                if (appDB.Users.FirstOrDefault(filter) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Delete(Expression<Func<User, bool>> filter)
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                appDB.Users.Remove(appDB.Users.FirstOrDefault(filter));
            }
        }
    }
}
