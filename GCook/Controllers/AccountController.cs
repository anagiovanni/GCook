using Microsoft.AspNetCore.Mvc;
using GCook.ViewModels;
using GCook.Services;

namespace GCook.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    private readonly IUsuarioService _usuarioService;

    public AccountController(
        ILogger<AccountController> logger,
        IUsuarioService usuarioService
    )
    {
        _logger = logger;
        _usuarioService = usuarioService;
    }

}