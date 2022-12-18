using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;            ///colocar essas linhas quando for usar SQL
using System.Data.SqlClient;


    public class ClasseConexao
    {
        SqlConnection conexao = new SqlConnection(); //sqlconnection vai fazer a conexao -> é uma classe da Microsoft 

        public SqlConnection conectar(){
            try{
                String strConexao = "Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=Teste; Data Source=" 
                + Environment.MachineName + "\\SQLEXPRESS"; //laranja é os parametros | senha | mesmo com erro, nao apaga o banco 
                //| nome do banco de dados | pega o nome da maquina pelo environment| intancia = SQL...
                conexao.ConnectionString = strConexao; //ConnectionString -> propriedade
                conexao.Open(); //Open() -> metodo -> se tiver alguma coisa errada aqui, 
                //vai pro catch e desconecta o banco de dados no "desconectar();"
                return conexao;
            }
            catch (Exception){
                desconectar();
                return null;
            }
        }

        public void desconectar(){
            try{
                if ((conexao.State == ConnectionState.Open)){ //verifica se a conexao tá aberta
                    conexao.Close(); //se nao fecha, 
                    conexao.Dispose(); //libera os recursos
                    conexao = null; //e coloca null
                }
            }catch (Exception) { }
        }

        public DataTable executarSQL(String comando_sql){ //esse metodo só executa select
            try{
                conectar(); 
                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao);
                //o adaptador é um preparo pra a conexao -> passa dois parametros (select (comando_sql) e conexao)
                DataSet ds = new DataSet(); //datset é a area em branco  -> a tabela fica em cima
                adaptador.Fill(ds); //preenche o ds -> ou seja, vai aparecer a tabela como no SQL | preenche um dataset (1)
                   //aqui só vai converter o dataset em um datatable (2)
                return ds.Tables[0]; //retorna a primeira tabela do SQL pro C# (como só fez um select, só manda aparecer a tabela 0) 
                //| retorna um datatable (1) -> pq retornar o dataset é muito recurso de maquina (2)
                //Table[] -> matriz pras tabelas | sempre coloca 0 pq só vai devolver uma tabela
            }
            catch (Exception){
                return null;
            }finally{
                desconectar();
            }
        }

        public bool manutencaoDB(String comando_sql) //incluir, alterar, excluir
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = comando_sql;
                comando.Connection = conexao;
                comando.ExecuteScalar();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                desconectar();
            }
        }//fim do método manutençãoDB

        public int manutencaoDB_Parametros(SqlCommand comando) //incluir, alterar, excluir com parâmetros
        {
            int retorno = 0;
            try
            {
                comando.Connection = conectar();  //adiciona a conexão ao SQLCommand
                retorno = comando.ExecuteNonQuery(); //devolve o número de linhas afetadas no banco
            }
            catch (Exception) { }
            desconectar();
            return retorno;
        }//fim do método manutençãoDB com parâmetros

    }//fim da classeConexao

