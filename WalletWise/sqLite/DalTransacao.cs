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
using WalletWise.Forms;

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
        public static Transacao GetUltimaReceita()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Transacao WHERE receita_despesa = 'Receita' ORDER BY data DESC LIMIT 1;";
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Transacao
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Descricao = reader.GetString(reader.GetOrdinal("descricao")),
                                Valor = reader.GetDecimal(reader.GetOrdinal("valor")),
                                Data = reader.GetDateTime(reader.GetOrdinal("data")),
                                tipo_compra = reader.GetString(reader.GetOrdinal("tipo_compra")),
                                receita_despesa = reader.GetString(reader.GetOrdinal("receita_despesa"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter a última receita: " + ex.Message);
            }
            return null; // Retorna null se não houver receita
        }

        public static Transacao GetUltimaDespesa()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Transacao WHERE receita_despesa = 'Despesa' ORDER BY data DESC LIMIT 1;";
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Transacao
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Descricao = reader.GetString(reader.GetOrdinal("descricao")),
                                Valor = reader.GetDecimal(reader.GetOrdinal("valor")),
                                Data = reader.GetDateTime(reader.GetOrdinal("data")),
                                tipo_compra = reader.GetString(reader.GetOrdinal("tipo_compra")),
                                receita_despesa = reader.GetString(reader.GetOrdinal("receita_despesa"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter a última despesa: " + ex.Message);
            }
            return null; // Retorna null se não houver despesa
        }

        public static List<DadosGrafico> ObterDadosGrafico()
        {
            var lista = new List<DadosGrafico>();

            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = @"
            SELECT 
                strftime('%Y-%m', data) AS Mes, 
                SUM(CASE WHEN receita_despesa = 'Receita' THEN valor ELSE 0 END) AS Receitas,
                SUM(CASE WHEN receita_despesa = 'Despesa' THEN valor ELSE 0 END) AS Despesas
            FROM Transacao
            GROUP BY strftime('%Y-%m', data)
            ORDER BY Mes";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new DadosGrafico
                        {
                            Mes = reader.GetString(0),
                            Receitas = reader.GetDecimal(1),
                            Despesas = reader.GetDecimal(2)
                        });
                    }
                }
            }

            return lista;
        }
        public static DataTable GetDespesasAgrupadasPorTipo()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = @"
                SELECT tipo_compra, SUM(valor) AS total
                FROM Transacao
                WHERE receita_despesa = 'Despesa'
                GROUP BY tipo_compra;
            ";

                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter os dados das despesas: " + ex.Message);
            }
        }
    }

}

