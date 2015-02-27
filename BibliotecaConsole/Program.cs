using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClassLibrary.Entity;

namespace BibliotecaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //CATEGORIA
            Categoria objCategoria = new Categoria();

            Console.WriteLine("Nome da Categoria: ");
            objCategoria.Nome = Console.ReadLine();

            Console.WriteLine("Categoria:" + objCategoria.Nome);
            



            //USUÁRIO
            Usuario objUsuario = new Usuario();

            Console.WriteLine("Digite o nome do Usuario: ");
            objUsuario.Nome = Console.ReadLine();

            Console.WriteLine("Usuario:" + objUsuario.Nome);



            Console.WriteLine("Digite o e-mail do Usuario: ");
            objUsuario.Email = Console.ReadLine();

            Console.WriteLine("Usuario:" + objUsuario.Email);



            Console.WriteLine("Digite a senha do Usuario: ");
            objUsuario.Senha = Console.ReadLine();

            Console.WriteLine("Usuario:" + objUsuario.Senha);

            



            //LIVRO
            Livro objLivro = new Livro();

            Console.WriteLine("Digite o titulo do Livro: ");
            objLivro.Titulo = Console.ReadLine();

            Console.WriteLine("Livro:" + objLivro.Titulo);



            Console.WriteLine("Digite a editora do Livro: ");
            objLivro.Editora = Console.ReadLine();

            Console.WriteLine("Livro:" + objLivro.Editora);
            
            //FALTA  idcategoria, idusuario




            //AUTOR
            Autor objAutor = new Autor();

            Console.WriteLine("Digite o nome do Autor: ");
            objAutor.Nome = Console.ReadLine();

            Console.WriteLine("Autor:" + objAutor.Nome);

            //SÓ TEM NOME

        }
    }
}
