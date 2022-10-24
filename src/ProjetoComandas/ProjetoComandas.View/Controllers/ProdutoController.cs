using Microsoft.AspNetCore.Mvc;
using ProjetoComandas.Application;

namespace ProjetoComandas.View.Controllers;

public class ProdutoController : Controller
{
    private readonly ILogger<ProdutoController> _logger;

    public ProdutoController(ILogger<ProdutoController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index([FromServices] ProdutoApplication application)
    {
        var produtos = await application.ConsultarProdutos();


        if (produtos.EhErro())
            throw produtos.GetError();

        return View(produtos.GetValue());
    }
}