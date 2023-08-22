using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
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

    public bool JsonSerializarLista(List<C_Processo> lista, string path)
    {
        var strJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
        return SaveFileCadastro(strJson, path);
    }
    public static List<C_Processo> JsonDesserializarLista(string path)
    {
        var strJson = OpenFileCadastro(path);
        if (strJson.Substring(0, 5) != "Falha")
            return JsonConvert.DeserializeObject<List<C_Processo>>(strJson);

        else
        {
            var lista = new List<C_Processo>();
            var cadastro = new C_Processo();
            cadastro.Numero = strJson;
            lista.Add(cadastro);
            cadastro.Numero = strJson;
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