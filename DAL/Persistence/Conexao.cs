using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //ADO .NET SQL SERVER

namespace DAL.Persistence
{
    public class Conexao
    {
        //Atributos
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        protected void AbrirConexao()
        {
            try 
            {
                Con = new SqlConnection("Data Source=JONATHAN;Initial Catalog=crud;Integrated Security=True");
                Con.Open();
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }        
        }

        protected void FecharConexao()
        {
            try 
            {
                Con.Close();
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }        
        }
    }
}
