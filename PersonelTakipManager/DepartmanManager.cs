using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using PersonelTakipModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipManager
{
    public static class DepartmanManager
    {
        public static async Task<List<Departman>> TumunuGetir()
        {
            SqlConnection conn = VeriTabaniBaglantisi.GetConnection;
            string sorgu = @"SELECT * FROM Departman WHERE Durum != -1";
            IEnumerable<Departman> departman = await conn.QueryAsync<Departman>(sorgu);
            return departman.ToList();
        }

        public  static async Task<Departman?> Getir(Guid Id)
        {
            SqlConnection conn = VeriTabaniBaglantisi.GetConnection;
            DynamicParameters param = new();
            param.Add("@id", Id);
            string sorgu = @"SELECT * FROM Departman WHERE Durum != -1 AND Id=@id";
            Departman? departman = await conn.QueryFirstOrDefaultAsync<Departman>(sorgu,param);
            return departman;

        }

        public static async Task Guncelle(Departman dep)
        {
            SqlConnection conn = VeriTabaniBaglantisi.GetConnection;
            await conn.UpdateAsync(dep);
        }

        public static async Task Ekle(Departman departman)
        {
            SqlConnection conn = VeriTabaniBaglantisi.GetConnection;
            await conn.InsertAsync(departman);
        }

        public static async Task Sil(Guid Id)
        {
            SqlConnection conn = VeriTabaniBaglantisi.GetConnection;
            DynamicParameters param = new();
            param.Add("@id", Id);
            string sorgu = @"UPDATE Departman SET DURUM= -1 WHERE Id=@id";
            await conn.ExecuteAsync(sorgu,param);

        }



    }
}
