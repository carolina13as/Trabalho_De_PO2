public class C_Pessoa
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public string Endereco { get; set; }
    public string RG { get; set; }


    public C_Pessoa(string nome,string cPF, string telefone, string email,string endereco, string rG)
    {
        this .Nome = nome;
        this .CPF = cPF;
        this .Telefone = telefone;
        this .Email = email;
        this . Endereco= endereco;
        this .RG = rG;
    }
}