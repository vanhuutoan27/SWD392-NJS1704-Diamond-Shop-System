using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Helpers
{
    public static class Userpermission
    {
        public static string FullAccess => "Full access";
        public static string Import => "Import";
        public static string Create => "Create";
        public static string Modify => "Modify";
        public static string View => "View";
        public static string AccessDenied => "Access denied";

        public static bool HasFullAccessPermission(this string permission)
        {
            return permission == FullAccess;
        }

        public static bool HasImportPermission(this string permission)
        {
            return permission == Import || permission.HasFullAccessPermission();
        }

        public static bool HasCreatePermission(this string permission)
        {
            return permission == Create || permission.HasImportPermission();
        }

        public static bool HasModifyPermission(this string permission)
        {
            return permission == Modify || permission.HasCreatePermission();
        }

        public static bool HasViewPermission(this string permission)
        {
            return permission == View || permission.HasModifyPermission();
        }

    }
}
