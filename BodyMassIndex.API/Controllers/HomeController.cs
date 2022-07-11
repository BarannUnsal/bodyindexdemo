using BodyMassIndex.API.Models;
using BodyMassIndex.Application.Features.CreateIndex;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BodyMassIndex.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BodyMassIndex()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BodyMassIndex(CreateDimensionsCommandRequest request)
        {
            CreateDimensionsCommandResponse response = await _mediator.Send(request);
            CreateDimensionsCommandValidator validator = new CreateDimensionsCommandValidator();
            ValidationResult result = await validator.ValidateAsync(request);
            if (result.IsValid)
            {
                double hResult = request.Heigth / 100;
                double totatl = request.Weigth / (hResult * hResult);
                if(totatl < 18 && totatl >= 0)
                {
                    TempData["Less18"] = Math.Round(totatl, 2);
                }else if(totatl >= 18 && totatl <25)
                {
                    TempData["Less25"] = Math.Round(totatl, 2);
                }
                else if(totatl >= 25 && totatl < 30)
                {
                    TempData["Less30"] = Math.Round(totatl, 2);
                }
                else if(totatl >= 30)
                {
                    TempData["Big30"] = Math.Round(totatl, 2);
                }
                TempData["result"] = Math.Round(totatl, 2);
                return View();
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(response);
        }

        [HttpGet]
        public IActionResult Coaches()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}