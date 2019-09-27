using System;

namespace McBonalds
{
     class Cliente
    {
        //Propriedades
        public string Nome;     //Nome do cliente
        public string Endereço; //Endereço do cliente 
        public string Telefone; //Número do cliente
        public string Senha;    //Senha de acesso do cliente ao sistema
        public string Email;    //Email do cleinte e nome de usuário do sistema
        public DateTime DataNascimento; //Data de nascimento do clinete

        //Contrutores
        public Cliente(string Nome, string Telefone, string Email){
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }
    }
}