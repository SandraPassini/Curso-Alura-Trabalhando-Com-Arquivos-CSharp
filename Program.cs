class Program
{
    //dentro do () são chamados de argurmentos
    static void Main(string[] args)
    {
        //Para minimizar erro de onde localizar o arquivo, estamos incluindo o arquivo txt dentro da mesma pasta de executavel da aplicacao.
        var enderecoDoArquivo = "Contas.txt";
        //Stream significa fluxo
        //No primeiro argumento recebe o endereço do arquivo e no segundo o que queremos fazer, no caso abrir
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        //FileStream tem um metodo chamado Read
        //No primeiro argumento é BUFFer onde informamos quantas
        // public override int Read(byte[] array, int offset, int count)

        Buffer buffer = fluxoDoArquivo.
        fluxoDoArquivo.Read();
        fluxoDoArquivo.Position = 0;
        Console.ReadLine();
    }
}