using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaveroBank.Models
{
    // Sentenciando a classe ContaCorrente;
    public class ContaCorrente
    {
        // Declarando as propriedades;
        private decimal depositoConta = 0;
        private decimal saqueConta = 0;
        private decimal calculaValor = 0;
        private decimal novoValorDepositado = 0;

        public ContaCorrente(decimal depositoConta, decimal saqueConta, decimal calculaValor, decimal novoValorDepositado)
        {
            this.depositoConta = depositoConta;
            this.saqueConta = saqueConta;
            this.calculaValor = calculaValor;
            this.novoValorDepositado = novoValorDepositado;
        }

        // Adicionando o método DepositarValor, para o depósito de valores no programa;
        public void DepositarValor()
        {
            Console.WriteLine("Digite a quantidade de valor que você deseja depositar:");
            depositoConta = Convert.ToDecimal(Console.ReadLine());

        // Fazendo com que o programa faça a soma de novos valores adicionados junto aos valores que já foi adicionado anteriormente;
            novoValorDepositado = (calculaValor += depositoConta);

        // Validando para que o programa não aceite valores 0 ou menores para depositos;
            if(depositoConta <= 0)
            {
                Console.WriteLine("Valor não permitido para Depósito!................");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine($"O valor de: {depositoConta} reais foi depositado em sua conta com sucesso!................");
            }
        }

        // Adicionando o método SacarValor, para realizar saques no sistema;
        public void SacarValor() 
        {
            Console.WriteLine("Digite um valor para saque: ");
            saqueConta = Convert.ToDecimal(Console.ReadLine());

        // Validando para que o usuário não consiga sacar um valor que não tenha disponível em sua conta, valida também para o usuário não sacar uma valor menor ou igual a 0;
            if (calculaValor < saqueConta || saqueConta <= 0) 
            {
                Console.Write("Você não pode sacar um valor maior que o valor que possuí em sua conta, ou um valor menor ou igual a 0................!");
                Console.ReadLine();
            }
            
        // Validando o valor da conta toda vez que retira, ou seja, cada vez que o usuário fazer um saque vai diminuindo o valor na conta.
            else
            {
                calculaValor = (depositoConta -= saqueConta);
                Console.WriteLine($"Saque no valor de {saqueConta} reais realizado!................");
            }

        }
        
        // Adicionando o método ExtratoValor, para que o usuário consiga consultar o seu extrato bancário no sistema.
        public void ExtratoValor()
        {   
            Console.WriteLine($"O valor total do extrato da sua conta é de: {calculaValor} reais................");

        }
    }
}