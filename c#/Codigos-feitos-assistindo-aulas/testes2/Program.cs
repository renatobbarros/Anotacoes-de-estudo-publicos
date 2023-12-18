using testes2.Models;

Pessoa p1 = new Pessoa();
p1.nome = "Joao";

Pessoa p2 = new Pessoa();
p2.nome = "Carlos";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();