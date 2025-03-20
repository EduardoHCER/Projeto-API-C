using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//FUNCIONALIDAES - EndPoints
//Request-Requisicao - URL("testarurl") e Metodo HTTP("MapGet") 
/*
Metodos HTTP
    Get = Pegar informação.
    Post = Enviar informacao.     
*/

app.MapGet("/testarurl", () => "Primeira aplicação");

//{ } = Bloco de codigo.
//" " = Texto rapido.
app.MapGet("/parametro/{param1}", ([FromRoute] string param1) => 
{
    string result = param1 + " " + DateTime.Now;
    return result;
});


app.Run();

