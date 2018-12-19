using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]

        public IActionResult Index(decimal leftOperant, decimal rightOperand, string @operator, decimal result)
        {
            Calculator calculator = new Calculator()
            {
                LeftOperand = leftOperant,
                RightOperand = rightOperand,
                Operator = @operator,
                Result = result
            };

            return View(calculator);
        }

        public IActionResult Calculate(Calculator calculator)
        {
            calculator.CalulateResult();

            if (calculator.RightOperand == 0 && calculator.Operator == "/")
            {
                TempData["Error"] = "Canot dived by zero";
            }
            else
            {
                Date.CalculatorHistory.Add(calculator);

            }

            return RedirectToAction("Index", calculator);
        }

        public IActionResult History()
        {
            return View(Date.CalculatorHistory);
        }
    }
}
