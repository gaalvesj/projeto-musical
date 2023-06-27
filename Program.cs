string firstMenssager = "Seja bem vindo ao screenSound";
List<string> listBand = new List<string> {"U2", "The beatles", "Iron Maden"};
void Logo ()
{
    // @ signifca verbatim literal
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(firstMenssager);

}
void Menu () {
    Logo();

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a media de uma banda");
    Console.WriteLine("Digite 0 para sair");
    
    Console.WriteLine("\nDigite a sua opção");
    string choice = Console.ReadLine()!;

    int choiceNumber = int.Parse(choice)!;
    // if (choiceNumber == 1) {
    // Console.WriteLine("voce digitou a opção: " + choice);
    // } else if (choiceNumber == 2) {
    // Console.WriteLine("voce digitou a opção: " + choice);
    // }

    switch (choiceNumber) {
        case 1: RegisterBand ();
            break;
        case 2: ShowBand();
            break;
        case 3: Console.WriteLine("voce digitou a opção: " + choiceNumber);
            break;
        case 4: Console.WriteLine("voce digitou a opção: " + choiceNumber);
            break;
        case 0: Console.WriteLine("tchau tchau");
            break;
        default: Console.WriteLine("opção invalida");
            break;
    }

}

void RegisterBand () {
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("digite a banda que voce deseja registar: ");
    string band = Console.ReadLine()!;
    listBand.Add(band);
    Console.WriteLine($"A banda {band} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    Menu();
};

void ShowBand () {
    Console.Clear();
    Console.WriteLine("bandas registradas: ");
    // for (int i = 0; i < listBand.Count; i++){
    //     Console.WriteLine($"Banda: {listBand[i]}");
    // }

    foreach (string band in listBand){
        Console.WriteLine($"Banda: {band}");
    };

    Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
        Menu ();
};
Menu ();
