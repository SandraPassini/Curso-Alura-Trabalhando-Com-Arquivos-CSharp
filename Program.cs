class Program
{
    //dentro do () são chamados de argurmentos
    static void Main(string[] args)
    {
        //Para minimizar erro de onde localizar o arquivo, estamos incluindo o arquivo txt dentro da mesma pasta de executavel da aplicacao.
        var enderecoDoArquivo = "Contas.txt";
        //Stream significa fluxo. Então, Fluxo de Dados/Arquivo
        //No primeiro argumento recebe o endereço do arquivo e no segundo o que queremos fazer, no caso abrir
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        #region Explicando o Metodo FileStream Read
        //FileStream tem um metodo chamado Read. Abaixo segue a estrutura:
        // public override int Read(byte[] array, int offset, int count)
        //O método Read recebe três argumentos. O primeiro é o byte[] array, onde serão armazenados os bytes lidos pelo método — ou seja, retomando a ideia de fluxo, de trabalhar de parte em parte no código.Esse conceito ficará mais claro, à medida que entendermos como fornecemos esse array.

        //O segundo argumento é o int offset, que delimita o índice em que o método começará a preencher o array. Por exemplo: para preencher a partir da primeira posição(índice 0), informaremos o número 0 no offset. Caso indiquemos o número 10, começaremos a preencher o array a partir do índice 10 e as dez primeiras posições(índices 0 a 9) ficarão reservadas.

        //O terceiro argumento é o int count, que informa quantas posições preencher. Por exemplo, se indicarmos o offset como 0 e o count como 10, preencheremos do índice 0 a 9.Vale lembrar que iniciamos a contagem dos índices no 0, por isso, a posição 10 corresponde ao índice 9.

        //Em resumo: é preciso fornecer o array, o índice em que começaremos a preenchê - lo e quantas posições serão usadas.
        #endregion

        var buffer = new byte[1024]; //1KB

        fluxoDoArquivo.Read(buffer, 0, 1024);

        EscreverBuffer(buffer);
        Console.ReadLine();
    }

    // Código anterior omitido

    static void EscreverBuffer(byte[] buffer)
    {
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
    }
}