using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIOC
{
    public class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        private bool isDisponivel = true;
        public DateTime DataLimiteDoEmprestimo { get; set; }

        public void DevolverItem()
        {
            if (!isDisponivel)
            {
                isDisponivel = true;
                Console.WriteLine($"O livro {Titulo} foi devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine($"O livro {Titulo} não está emprestado.");
            }

        }

        public void EmprestarItem()
        {
            if (isDisponivel)
            {
                isDisponivel = false;
                DataLimiteDoEmprestimo = DateTime.Now.AddDays(90);
                Console.WriteLine($"Emprestimo realizado com sucesso! Você terá até {DataLimiteDoEmprestimo:d} para devolução.");
            }
            else
            {
                Console.WriteLine($"Emprestimo não pode ser realizado, o livro {Titulo} não está disponível!");
            }
        }
    }
}
