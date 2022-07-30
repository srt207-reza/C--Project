using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MySoftWare
{
    internal interface ISaleItem
    {
        DataTable SelectRowItem(int UserId);
        DataTable SelectAllItem();
        bool InsertNewData(string name,string family,string username,string password,string phonenumber,string gmail,string region,string sourceid);
        bool CheckUsers(string name, string password);
        DataTable SelectAllProduct();
    }
}
