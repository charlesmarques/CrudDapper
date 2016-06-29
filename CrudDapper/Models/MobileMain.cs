using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace CrudDapper.Models
{
    public class MobileMain
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBstring"].ToString());
        public string Add(Mobiledata obj)
        {
            var query = "insert into BancoTeste (MobileName, MobileIMEno, MobileManufactured, Mobileprice)"
                + "values(@MobileName, @MobileIMEno, @MobileManufactured, @Mobileprice)";

            con.Execute(query, new { obj.MobileIMEno, obj.MobileManufactured, obj.MobileName, obj.Mobileprice });

            string result = "Enviado com sucesso!";
            return result;
        }

        public IEnumerable<Mobiledata> GetAll()
        {
            string query = "select * from BancoTeste";
            var result = con.Query<Mobiledata>(query);
            return result;
        }

        public Mobiledata GetMobileList(string MobileID)
        {
            string query = "select MobileID,MobileName,MobileIMEno,MobileManufactured" +
            ",Mobileprice from dbo.BancoTeste where MobileID =" + MobileID;
            var result = con.Query<Mobiledata>(query).Single<Mobiledata>();
            return result;
        }
        public string Updatemobile(Mobiledata objMD)
        {
            string query = "update BancoTeste SET MobileName=@MobileName,MobileIMEno=@MobileIMEno,"
     + "MobileManufactured=@MobileManufactured,Mobileprice =@Mobileprice "
     + "where MobileID =@MobileID";
            con.Execute(query, new
            {
                objMD.MobileIMEno,
                objMD.MobileManufactured,
                objMD.MobileName,
                objMD.Mobileprice,
                objMD.MobileID
            });
            string result = "updated";
            return result;
        }
        public string DeleteMobile(string MobileID)
        {
            string query = "Delete from BancoTeste where BancoTeste.MobileID = @MobileID";
            con.Execute(query, new { MobileID });
            string result = "Deleted";
            return result;
        }

    }
}