using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Exo.WebApi.Repositories
{
public class ProjetoRepository
{
private readonly ExoContext _context;
public ProjetoRepository(ExoContext context)
{
_context = context;
}
public List<Projeto> Listar()
{
return _context.Projetos.ToList();
}
}
}
using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Exo.WebApi.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class ProjetosController : ControllerBase
{
private readonly ProjetoRepository
_projetoRepository;
public ProjetosController(ProjetoRepository
projetoRepository)
{
_projetoRepository = projetoRepository;
}
[HttpGet]
public IActionResult Listar()
{
return Ok(_projetoRepository.Listar());
}
}
}