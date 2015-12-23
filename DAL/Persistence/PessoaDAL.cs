using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class PessoaDAL : Conexao
    {
        public void Gravar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO pessoa (nome, endereco, email) VALUES (@v1, @v2, @v3)", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar o cliente." + ex.Message);
            }
            finally
            {
                FecharConexao();                            
            }
        }

        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("UPDATE pessoa SET nome = @v1, endereco = @v2, email = @v3 WHERE codigo = @v4", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("@v4", p.Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o cliente." + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Exluir(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("DELETE FROM pessoa WHERE codigo = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o cliente." + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Pessoa PesquisarPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM pessoa WHERE codigo = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Dr = Cmd.ExecuteReader();

                Pessoa p = null;

                if (Dr.Read())
                {
                    p = new Pessoa();

                    p.Codigo = Convert.ToInt32(Dr["codigo"]);
                    p.Nome = Convert.ToString(Dr["nome"]);
                    p.Endereco = Convert.ToString(Dr["endereco"]);
                    p.Email = Convert.ToString(Dr["email"]);
                }

                return p;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar o cliente." + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM pessoa",  Con);
                Dr = Cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();

                    p.Codigo = Convert.ToInt32(Dr["codigo"]);
                    p.Nome = Convert.ToString(Dr["nome"]);
                    p.Endereco = Convert.ToString(Dr["endereco"]);
                    p.Email = Convert.ToString(Dr["email"]);  
                    
                    lista.Add(p);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar os clientes" + ex.Message);                
            }           
        }
    }
}
