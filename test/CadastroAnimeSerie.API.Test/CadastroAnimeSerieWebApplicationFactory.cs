using CadastroAnimeSerie.Dados.Banco;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroAnimeSerie.API.Test;

public class CadastroAnimeSerieWebApplicationFactory: WebApplicationFactory<Program>
{
    public CadastroAnimeSerieContext Context { get; }
    private IServiceScope scope;

    public CadastroAnimeSerieWebApplicationFactory()
    {
        this.scope = Services.CreateScope();
        Context = scope.ServiceProvider.GetRequiredService<CadastroAnimeSerieContext>();
    }
}
