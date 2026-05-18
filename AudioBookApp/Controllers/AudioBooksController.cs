using Microsoft.AspNetCore.Mvc;
using AudioBookApp.Data;
using AudioBookApp.Models;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;

namespace AudioBookApp.Controllers
{
    public class AudioBooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AudioBooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // INDEX
        public IActionResult Index()
        {
            return View(_context.AudioBooks.ToList());
        }

        // CREATE PAGE
        public IActionResult Create()
        {
            return View();
        }

        // SAVE BOOK
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            AudioBook audioBook,
            IFormFile pdfFile)
        {
            if (pdfFile != null)
            {
                string folder = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot/pdfs");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string filePath = Path.Combine(
                    folder,
                    pdfFile.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await pdfFile.CopyToAsync(stream);
                }

                audioBook.PdfFilePath = pdfFile.FileName;
            }

            _context.AudioBooks.Add(audioBook);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // READ PDF METHOD
        public IActionResult ReadPdf(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return Content("PDF file not found.");
            }

            string path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot/pdfs",
                fileName);

            string text = "";

            using (PdfReader reader = new PdfReader(path))
            using (PdfDocument pdf = new PdfDocument(reader))
            {
                for (int i = 1; i <= pdf.GetNumberOfPages(); i++)
                {
                    text += PdfTextExtractor.GetTextFromPage(
                        pdf.GetPage(i));
                }
            }

            ViewBag.PdfText = text;

            return View();
        }
    }
}