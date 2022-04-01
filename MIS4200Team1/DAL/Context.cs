using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MIS4200Team1.Models;

namespace MIS4200Team1.DAL
{
    public class Context : DbContext
    {
        public Context() : base("name=DefaultConnection")
        {
        }

    }
}