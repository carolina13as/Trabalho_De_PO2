public class C_Processo
{
    public string Numero { get; set; }
    public string Descricao { get; set; }
    public string Data { get; set; }
    public string Vara { get; set; }
    public string Tipo { get; set; }
    public string Pessoa { get; set; }
    public C_Processo() { }
    public C_Processo(string numero, string descricao, string data, string vara, string tipo, string pessoa)
    {
        this.Numero = numero;
        this.Descricao = descricao;
        this.Data = data;
        this.Vara = vara;
        this.Tipo = tipo;
        this.Pessoa = pessoa;
    }
}