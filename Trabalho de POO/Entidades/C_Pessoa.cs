using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
public class C_Pessoa
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public string Endereco { get; set; }
    public string RG { get; set; }
    public C_Pessoa() { }
    public C_Pessoa(string nome,string cPF, string telefone, string email,string endereco, string rG)
    {
        this. Nome = nome;
        this. CPF = cPF;
        this. Telefone = telefone;
        this. Email = email;
        this. Endereco= endereco;
        this. RG = rG;
    }
    public bool JsonSerializarLista(List<C_Pessoa> lista, string path)
    {
        var strJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
        return SaveFileCadastro(strJson, path);
    }
    public static List<C_Pessoa> JsonDesserializarLista(string path)
    {
        var strJson = OpenFileCadastro(path);
        if (strJson.Substring(0, 5) != "Falha")
            return JsonConvert.DeserializeObject<List<C_Pessoa>>(strJson);

        else
        {
            var lista = new List<C_Pessoa>();
            var cadastro = new C_Pessoa();
            cadastro.Nome = strJson;
            lista.Add(cadastro);
            cadastro.Nome = strJson;
            return lista;
        }
    }
    private bool SaveFileCadastro(string strJson, string path)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(strJson);
            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    private static string OpenFileCadastro(string path)
    {
        try
        {
            var strJson = "";

            using (StreamReader sr = new StreamReader(path))
            {
                strJson = sr.ReadToEnd();
            }

            return strJson;
        }
        catch (Exception ex)
        {
            return "Falha: " + ex.Message;
        }
    }
}