using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProgramacaoWeb_CSharp_Fatec.Heranca
{
    public class Veiculo
    {
        
        public int numeroAssentos;
        public int numeroPortas;
        public bool temMotor;

        public string ExibirDados()
        {
            if(temMotor == true)
            {
                return "Tem motor (TRUE), tem " + numeroAssentos + " assentos e " + numeroPortas + " portas";
            }
            else
            {
                return "NÃO tem motor, o  número de assentos é: " + numeroAssentos + " e o Número de portas: " + numeroPortas;
            }
        }
    }
}