using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIOC
{
    public class Revista : ItemBiblioteca, IPodeSerEmprestado
    {
        private bool isDisponivel = true;
        public DateTime DataLimiteDoEmprestimo { get; set; }
        public void DevolverItem()
        {
            if (!isDisponivel)
            {
                isDisponivel = true;
                Console.WriteLine($"A revista {Titulo} foi devolvida com sucesso!");
            }
            else
            {
                Console.WriteLine($"A revista {Titulo} não está emprestada.");
            }

        }

        public void EmprestarItem()
        {
            if (isDisponivel)
            {
                isDisponivel = false;
                DataLimiteDoEmprestimo = DateTime.Now.AddDays(15);
                Console.WriteLine($"Emprestimo realizado com sucesso! Você terá {DataLimiteDoEmprestimo:d} dias para devolução.");
            }
            else
            {
                Console.WriteLine($"Emprestimo não pode ser realizado, a revista {Titulo} não está disponível!");
            }
        }
    }
}
