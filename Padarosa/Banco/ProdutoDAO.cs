﻿using LibPadarosa;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padarosa.Banco
{
    internal class ProdutoDAO
    {
        public static bool Cadastrar(Produto p)
        {
            string comando;
            comando = "INSERT INTO produtos (nome, preco, id_categoria, id_respcadastro) VALUES (@nome, @preco, @id_categoria, @id_respcadastro)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            //Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@preco", p.Preco);
            cmd.Parameters.AddWithValue("@id_categoria", p.IdCategoria);
            cmd.Parameters.AddWithValue("@id_respcadastro", p.IdRespCadastro);

            cmd.Prepare();
            if (cmd.ExecuteNonQuery() == 0)
            {
                conexaoBD.Desconectar(con);
                return false;
            }
            else
            {
                conexaoBD.Desconectar(con);
                return true;
            }/*
            try
            {
                
            }
            catch
            {
                return false;
            }*/

        }
        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM view_produtos";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;

        }
        public static bool Modificar(Produto p)
        {
            string comando;
            comando = "UPDATE produtos " + "SET nome = @nome, " + "preco = @preco, " + "id_categoria = @id_categoria " + " WHERE id = @id";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            //Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome",p.Nome);
            cmd.Parameters.AddWithValue("@preco",p.Preco);
            cmd.Parameters.AddWithValue("@id_categoria", p.IdCategoria); 
            cmd.Parameters.AddWithValue("@id", p.Id);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
    }
}
