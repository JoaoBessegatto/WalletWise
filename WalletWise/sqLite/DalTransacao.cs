using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Data.Entity;
using System.Data.Common;

namespace WalletWise
{
    public class DalTransacao
    {
        public static string path = Directory.GetCurrentDirectory() + "\\banco.SqLite";
        public static SQLiteConnection sqlconn;

        public static SQLiteConnection DbConnection()
        {
            sqlconn = new SQLiteConnection("Data Source=" + path);
            sqlconn.Open();
            return sqlconn;
        }
        public static void CriarBancoSQLite()
        {
            try
            {
                if (File.Exists(path) == false)
                {
                    SQLiteConnection.CreateFile(path);
                }
            }
            catch
            {
                throw;
            }
        }
        public static void CriarTabela()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Transacao (" +
                        "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                        "descricao TEXT NOT NULL, " +
                        "valor DECIMAL(10, 2) NOT NULL, " +
                        "data DATETIME NOT NULL, " +
                        "tipo_compra TEXT NOT NULL, " +
                        "receita_despesa TEXT CHECK(receita_despesa IN ('Receita', 'Despesa')) NOT NULL" +
                        ");";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataTable GetTransacoes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Transacao";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Add(Transacao transacao)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Transacao(descricao, valor, data, tipo_compra, receita_despesa) " +
                                      "VALUES (@descricao, @valor, @data, @tipo_compra, @receita_despesa)";
                    
                    cmd.Parameters.AddWithValue("@descricao", transacao.Descricao);
                    cmd.Parameters.AddWithValue("@valor", transacao.Valor);
                    cmd.Parameters.AddWithValue("@data", transacao.Data); // Adicionando o parâmetro data
                    cmd.Parameters.AddWithValue("@tipo_compra", transacao.tipo_compra);
                    cmd.Parameters.AddWithValue("@receita_despesa", transacao.receita_despesa);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar a transação: " + ex.Message, ex);
            }
        }
        public static List<Transacao> GetAll()
        {
            var transacoes = new List<Transacao>();

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Transacao";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transacoes.Add(new Transacao
                            {
                                ID = reader.GetInt32(0),
                                Descricao = reader.GetString(1),
                                Valor = reader.GetDecimal(2),
                                Data = reader.GetDateTime(3),
                                tipo_compra = reader.GetString(4),
                                receita_despesa = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar as transações: " + ex.Message);
            }

            return transacoes;
        }
        public static Transacao GetUltimaTransacao()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Transacao ORDER BY ID DESC LIMIT 1";

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Transacao
                            {
                                ID = reader.GetInt32(0),
                                Descricao = reader.GetString(1),
                                Valor = reader.GetDecimal(2),
                                Data = reader.GetDateTime(3),
                                tipo_compra = reader.GetString(4),
                                receita_despesa = reader.GetString(5)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter a última transação: " + ex.Message);
            }

            return null; 
        }
    }
}

