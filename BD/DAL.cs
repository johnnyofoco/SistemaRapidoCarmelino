using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace SistemaRapidoCarmelino.BD
{
    class DAL
    {
        //Dados da conexão
        static string serverName = "localhost";  //localhost
        static string port = "5432";             //porta default
        static string userName = "CucaPost";     //nome do administrador
        static string password = "1234";     //senha do administrador
        static string databaseName = "dpcuca"; //nome do banco de dados
        
        string connString = null;

        public DAL()
        {
            connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                          serverName, port, userName, password, databaseName);
        }

        //Pega todos os registros e exibe no dataGridView
        /*
        public DataTable GetTodosRegistros()
        {

            DataTable dt = new DataTable();


            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select f.cod_empresa as \"Empresa\", e.cnpj as \"CNPJ\", " +
                                            "f.cod_funcionario as \"Matricula\", f.nomefuncionario as \"Nome\", " +
                                            "f.cpfcic as \"CPF\", f.piscadastrado as \"PIS\", " +
                                            "to_char(f.dataadmissao, 'dd/mm/yyyy') as \"Admissão\", " +
                                            "f.caged as \"Tipo de Admissao\", " +
                                            "to_char(f.dataopcao, 'dd/mm/yyyy') as \"Data da Opção\", " +
                                            "f.demrais as \"DemRAIS\", f.demcaged as \"DemCAGED\", " +
                                            "f.demfgts as \"DemFGTS\", " +
                                            "to_char(f.datademissao, 'dd/mm/yyyy') as \"Demissão\" " +
                                            "from dpcuca.funcion f " +
                                            "left join dpcuca.empresas e on (e.id_empresa = f.cod_empresa)" +
                                            " order by f.datademissao";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                        // MessageBox.Show("Valor da variavel Adpt: " + Adpt.Fill(dt));
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
        */


        //Pega um registro utilizando filtros
        public DataTable GetRegistroComFiltro(string nome, string cpf, string pis)
        {

            DataTable dt = new DataTable();
            string cmdSeleciona = null;

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL
                    pgsqlConnection.Open();


                    //Se todos os campos tiverem preenchidos executa essa query
                    if ( nome != "" && cpf != "" && pis != "")
                    {
                        cmdSeleciona = String.Format("select f.cod_empresa as \"Empresa\", e.cnpj as \"CNPJ\", " +
                                                "f.cod_funcionario as \"Matricula\", f.nomefuncionario as \"Nome\", " +
                                                "f.cpfcic as \"CPF\", f.piscadastrado as \"PIS\", " +
                                                "to_char(f.dataadmissao, 'dd/mm/yyyy') as \"Admissão\", " +
                                                "f.caged as \"Tipo de Admissao\", " +
                                                "to_char(f.dataopcao, 'dd/mm/yyyy') as \"Data da Opção\", " +
                                                "f.demrais as \"DemRAIS\", f.demcaged as \"DemCAGED\", " +
                                                "f.demfgts as \"DemFGTS\", " +
                                                "to_char(f.datademissao, 'dd/mm/yyyy') as \"Demissão\" " +
                                                "from dpcuca.funcion f " +
                                                "left join dpcuca.empresas e on (e.id_empresa = f.cod_empresa)" +
                                                " where f.nomefuncionario like '%{0}%' or f.cpfcic = '{1}' or f.piscadastrado = '{2}'" +
                                                " order by f.datademissao", nome, cpf, pis);

                            //MessageBox.Show("Valor da variavel cmdSeleciona: " + cmdSeleciona);
                        }
                    //Se apenas o campo nome estiver preenchido executa essa query
                    if (nome != "" && cpf == "" && pis == "")
                    {
                        cmdSeleciona = String.Format("select f.cod_empresa as \"Empresa\", e.cnpj as \"CNPJ\", " +
                                                "f.cod_funcionario as \"Matricula\", f.nomefuncionario as \"Nome\", " +
                                                "f.cpfcic as \"CPF\", f.piscadastrado as \"PIS\", " +
                                                "to_char(f.dataadmissao, 'dd/mm/yyyy') as \"Admissão\", " +
                                                "f.caged as \"Tipo de Admissao\", " +
                                                "to_char(f.dataopcao, 'dd/mm/yyyy') as \"Data da Opção\", " +
                                                "f.demrais as \"DemRAIS\", f.demcaged as \"DemCAGED\", " +
                                                "f.demfgts as \"DemFGTS\", " +
                                                "to_char(f.datademissao, 'dd/mm/yyyy') as \"Demissão\" " +
                                                "from dpcuca.funcion f " +
                                                "left join dpcuca.empresas e on (e.id_empresa = f.cod_empresa)" +
                                                " where f.nomefuncionario like '%{0}%' " +
                                                " order by f.datademissao", nome);
                    }
                    //Se apenas o campo cpf estiver preenchido executa essa query
                    if (nome == "" && cpf != "" && pis == "")
                    {
                        cmdSeleciona = String.Format("select f.cod_empresa as \"Empresa\", e.cnpj as \"CNPJ\", " +
                                                "f.cod_funcionario as \"Matricula\", f.nomefuncionario as \"Nome\", " +
                                                "f.cpfcic as \"CPF\", f.piscadastrado as \"PIS\", " +
                                                "to_char(f.dataadmissao, 'dd/mm/yyyy') as \"Admissão\", " +
                                                "f.caged as \"Tipo de Admissao\", " +
                                                "to_char(f.dataopcao, 'dd/mm/yyyy') as \"Data da Opção\", " +
                                                "f.demrais as \"DemRAIS\", f.demcaged as \"DemCAGED\", " +
                                                "f.demfgts as \"DemFGTS\", " +
                                                "to_char(f.datademissao, 'dd/mm/yyyy') as \"Demissão\" " +
                                                "from dpcuca.funcion f " +
                                                "left join dpcuca.empresas e on (e.id_empresa = f.cod_empresa)" +
                                                " where f.cpfcic = '{0}' " +
                                                " order by f.datademissao", cpf);
                    }
                    //Se apenas o campo pis estiver preenchido executa essa query
                    if (nome == "" && cpf == "" && pis != "")
                    {
                        cmdSeleciona = String.Format("select f.cod_empresa as \"Empresa\", e.cnpj as \"CNPJ\", " +
                                                "f.cod_funcionario as \"Matricula\", f.nomefuncionario as \"Nome\", " +
                                                "f.cpfcic as \"CPF\", f.piscadastrado as \"PIS\", " +
                                                "to_char(f.dataadmissao, 'dd/mm/yyyy') as \"Admissão\", " +
                                                "f.caged as \"Tipo de Admissao\", " +
                                                "to_char(f.dataopcao, 'dd/mm/yyyy') as \"Data da Opção\", " +
                                                "f.demrais as \"DemRAIS\", f.demcaged as \"DemCAGED\", " +
                                                "f.demfgts as \"DemFGTS\", " +
                                                "to_char(f.datademissao, 'dd/mm/yyyy') as \"Demissão\" " +
                                                "from dpcuca.funcion f " +
                                                "left join dpcuca.empresas e on (e.id_empresa = f.cod_empresa)" +
                                                " where f.piscadastrado = '{0}'" +
                                                " order by f.datademissao", pis);
                    }

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                
            }
            return dt;
        }

    }

}
