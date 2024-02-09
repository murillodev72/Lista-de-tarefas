using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpShellCore;

namespace Lista{
class Classe{
public static void Main(String[] args){

Console.WriteLine("bem vindo ao software de lista de tarefas");
List<string> listaDeTarefas = new List<string>();
string opção = "";

while(opção != "s")
{
Console.WriteLine("o que você gostaria de fazer? ");
Console.WriteLine("digite 1 para adicionar uma tarefa na lista");
Console.WriteLine("digite 2 para remover uma tarefa da lista");
Console.WriteLine("digite 3 para ver a lista ");
Console.WriteLine("digite s para sair da lista");

opção = Console.ReadLine();


if(opção == "1")
{
    
Console.WriteLine("por favor informe o nome da tarefa que será adicionada: ");
string tarefa = Console.ReadLine();
listaDeTarefas.Add(tarefa);
Console.WriteLine("tarefa adicionada com sucesso");

}

else if(opção == "2")
{

for(int i = 0; i < listaDeTarefas.Count; i++)

{
    
Console.WriteLine(i + " : " + listaDeTarefas[i]);

}

Console.WriteLine("por favor insira o número da tarefa que você deseja remover da lista:");
int numeroDaTarefa = Convert.ToInt32(Console.ReadLine());
listaDeTarefas.RemoveAt(numeroDaTarefa);

}

else if(opção == "3")
{

Console.WriteLine("as tarefas atuais são: ");

for(int i = 0; i < listaDeTarefas.Count; i++)

{
Console.WriteLine(listaDeTarefas[i]);
}



}

else if(opção == "s")

{
Console.WriteLine("fechando o programa...");
}

else
{
Console.WriteLine("opção inválida, tente novamente");
}


}
}
}
}