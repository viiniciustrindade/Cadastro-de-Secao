using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeSecao
{
    public class SecaoDao
    {
        private SqlConnection Connection { get; }
        public SecaoDao(SqlConnection connection)
        {
            Connection = connection;
        }
        public void Salvar(SecaoModel secao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibSecao(descSecao) VALUES (@descricao)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@descricao", secao.descSecao));

                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit(); 
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public void Alterar(SecaoModel secao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibSecao SET descSecao = @descricao WHERE codSecao = @codSecao");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codSecao", secao.codSecao);
                    command.Parameters.Add(new SqlParameter("@descricao", secao.descSecao));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();                    
                }
                catch(Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public void Excluir(SecaoModel secao, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtBibSecao WHERE codSecao = @secao");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@secao", secao.codSecao));
                command.ExecuteNonQuery();
            }
        }
        public List<SecaoModel> GetEditoras()
        {
            List<SecaoModel> secoes = new List<SecaoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT SEC.codSecao, SEC.descSecao FROM mvtBibSecao SEC");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        secoes.Add(PopulateDr(dr));
                    }
                }
            }
            return secoes;
        }
        private SecaoModel PopulateDr(SqlDataReader dr)
        {
            string codSecao = "";
            string descSecao = "";
            if (DBNull.Value != dr["codSecao"])
            {
                codSecao = dr["codSecao"] + "";
            }
            if (DBNull.Value != dr["descSecao"])
            {
                descSecao = dr["descSecao"] + "";
            }
            return new SecaoModel()
            {
                codSecao = codSecao,
                descSecao = descSecao,
            };
        }
    }
}
