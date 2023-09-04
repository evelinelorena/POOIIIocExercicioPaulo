using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIOC
{
    public class Biblioteca
    {
        public List<ItemBiblioteca> Itens { get; set; } = new List<ItemBiblioteca>();

        public void AdicionarItem(ItemBiblioteca itemBiblioteca)
        {
            if (Itens.Any(x => x.Codigo == itemBiblioteca.Codigo))
            {
                Console.WriteLine("Item com mesmo código já existe");
            }
            else
            {
                Itens.Add(itemBiblioteca);
            }

            
        }

        public void EmprestarItem(int codigo)
        {
            ItemBiblioteca item = Itens.FirstOrDefault(x => x.Codigo == codigo);
            if (item != null)
            {
                if (item is IPodeSerEmprestado)
                {
                    ((IPodeSerEmprestado)item).EmprestarItem();
                }
                else
                {
                    Console.WriteLine("Itens desse tipo não podem ser emprestados.");
                }
            }
            else
            {
                Console.WriteLine("Item com este código não encontrado.");
            }
        }
        public void DevolverItem(int codigo)
        {
            ItemBiblioteca item = Itens.FirstOrDefault(x => x.Codigo == codigo);
            if (item != null)
            {
                if (item is IPodeSerEmprestado)
                {
                    ((IPodeSerEmprestado)item).DevolverItem();
                }
                else
                {
                    Console.WriteLine("Itens desse tipo não podem ser emprestados.");
                }
            }
            else
            {
                Console.WriteLine("Item com este código não encontrado.");
            }
        }

    }
}
