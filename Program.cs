const string Sair = "tchau";
Console.WriteLine("+====GrootChatbot====+");
Console.WriteLine(@"
⠰⣶⣶⣶⣄⠀⠀⠀⢀⣀⠀⠀⣠⣄⡀⠀⠀⠀⠀⠀⠀⠀
⠀⠻⣿⣿⣿⡀⠀⠀⣿⠿⠷⢾⡏⠉⣿⣄⢀⣿⣷⡆⠀⠀
⢀⣠⣬⡁⢸⣿⣶⣿⣿⡇⠀⣾⡇⠀⣿⡏⠛⢻⣿⢧⣤⠀
⢸⣿⡿⡿⢻⠇⠀⢿⣿⡇⣠⣿⡇⣼⡿⠀⠀⣼⡏⢠⣾⠀
⢸⣿⡀⢀⣿⠀⣴⠈⣿⣿⣿⣿⣿⣿⠃⣾⣤⣿⠀⣼⣿⠀
⢸⣿⣧⢸⣿⣧⣿⣇⣿⣿⣿⣿⣿⣿⣾⣿⣿⣏⣼⣿⣿⠀
⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡄
⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁
⠀⢹⣿⣿⣿⣿⣿⠉⠙⣿⣿⣿⣿⣿⡯⠉⢻⣿⣿⣿⣿⠀
⠀⠸⣿⣿⣿⣧⡀⠀⣠⣿⣿⣿⣿⣄⠀⢀⣼⣿⣿⣿⠇⠀
⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠀⠀
⠀⠀⠘⣿⣿⣿⣿⣿⡿⠿⠿⢿⣿⣿⣿⣿⣿⣿⡟⠁⠀⠀
⠀⠀⠀⠘⣿⣿⣿⣿⣷⣄⣀⣀⣠⣿⣿⣿⣿⠏⠀⠀⠀⠀
⠀⠀⠀⠀⠈⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠈⠛⠿⠿⠟⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀

+====================+
");
string pergunta;
do
{
    Console.Write("Pergunta: ");
    pergunta = Console.ReadLine()!;

    string resposta = RespostaDoGroot(pergunta);

    ExibeResposta(RespostaDoGroot(pergunta));
    Console.ResetColor();

} while (pergunta.Trim().ToLower() != Sair);


void ExibeResposta(string resposta)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"                          Resposta: {resposta}");
}

string RespostaDoGroot(string pergunta)
{
    return pergunta.Trim().ToLower() == Sair ?
        "Eu sou Groot!" :
        "Eu sou Groot.";
}