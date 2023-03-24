using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoWeb_CSharp_Fatec.Classes
{
    public class Cliente
    {
        
        private int Id;
        public string Nome;
        public string Telefone;

       

        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

       
        public Endereco getEndereco()
        {
            return Endereco;
        }

        public int getId()
        {
            return Id;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public string ExibeDadosClientes()
        {
            return "\nID: " + Id + "\n Nome: " + Nome + "\n Telefone: " + Telefone + "\n Endereço: ";
        }

        
        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}