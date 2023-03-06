/**************************
* Автор: Богулянов Семен  *
* Группа: ПИ-221          *
* Дата: 27.02.23          *
* Название: ООП на C#     *
***************************/

using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace lab2
{

    internal class SuperDocument
    {
        public string DocumentName, DocumentAuthor, DocumentKeyWords, DocumentSubject, DocumentFilePath;

        public virtual void DocumentInfo()
        {
            Console.WriteLine($"Имя {DocumentName} Автор {DocumentAuthor}" +
            $" Ключевые слова {DocumentKeyWords} Тематика {DocumentSubject}" +
            $" Путь к файлу {DocumentFilePath}");
        }
    }
    class MSWord : SuperDocument
    {
        string DocumentWordPageCount, DocumentWordFonts;

        public MSWord(string DocumentName, string DocumentAuthor, string DocumentKeyWords, string DocumentFilePath,
          string DocumentSubject)
        {
            this.DocumentName = DocumentName;
            this.DocumentAuthor = DocumentAuthor;
            this.DocumentKeyWords = DocumentKeyWords;
            this.DocumentFilePath = DocumentFilePath;
            this.DocumentSubject = DocumentSubject;

            Console.WriteLine("Введите количество страниц: ");
            DocumentWordPageCount = Console.ReadLine();
            Console.WriteLine("Введите шрифты: ");
            DocumentWordFonts = Console.ReadLine();
        }

        public override void DocumentInfo()
        {
            Console.WriteLine($"\nИмя: {DocumentName}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWords}\n" +
              $"Путь к файлу: {DocumentFilePath}\n Тема: {DocumentSubject}\n" +
              $"Количество страниц: {DocumentWordPageCount}\n" +
              $"Шрифты: {DocumentWordFonts}");
        }
    }

    class PDF : SuperDocument
    {
        string DocumentPDFDateEdit, DocumentPDFPageCount;

        public PDF(string DocumentName, string DocumentAuthor, string DocumentKeyWords, string DocumentFilePath,
          string DocumentSubject)
        {
            this.DocumentName = DocumentName;
            this.DocumentAuthor = DocumentAuthor;
            this.DocumentKeyWords = DocumentKeyWords;
            this.DocumentFilePath = DocumentFilePath;
            this.DocumentSubject = DocumentSubject;

            Console.WriteLine("Введите количество строк: ");
            DocumentPDFPageCount = Console.ReadLine();
            Console.WriteLine("Введите классы: ");
            DocumentPDFDateEdit = Console.ReadLine();
        }

        public override void DocumentInfo()
        {
            Console.WriteLine($"\nИмя: {DocumentName}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWords}\n" +
              $"Путь к файлу: {DocumentFilePath}\nТема документа: {DocumentSubject}\n" +
              $"Дата редактирования: {DocumentPDFDateEdit}\n" +
              $"Количество страниц: {DocumentPDFPageCount}\n");
        }
    }

    class MSExcel : SuperDocument
    {
        int DocumentExcelRowCount, DocumentExcelColumnCount;

        public MSExcel(string DocumentName, string DocumentAuthor, string DocumentKeyWords, string DocumentFilePath,
          string DocumentSubject)
        {
            this.DocumentName = DocumentName;
            this.DocumentAuthor = DocumentAuthor;
            this.DocumentKeyWords = DocumentKeyWords;
            this.DocumentFilePath = DocumentFilePath;
            this.DocumentSubject = DocumentSubject;

            Console.WriteLine("Введите количество столбцов: ");
            DocumentExcelColumnCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество строк: ");
            DocumentExcelRowCount = int.Parse(Console.ReadLine());
        }

        public override void DocumentInfo()
        {
            Console.WriteLine($"\nИмя: {DocumentName}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWords}\n" +
              $"Путь к файлу: {DocumentFilePath}\nТема документа: {DocumentSubject}\n" +
              $"Количество строк: {DocumentExcelRowCount}\n" +
              $"Количество столбцов: {DocumentExcelColumnCount}\n");
        }
    }
    class TXT : SuperDocument
    {
        int DocumentTXTStringCount, DocumentTXTSignCount;

        public TXT(string DocumentName, string DocumentAuthor, string DocumentKeyWords, string DocumentFilePath,
          string DocumentSubject)
        {
            this.DocumentName = DocumentName;
            this.DocumentAuthor = DocumentAuthor;
            this.DocumentKeyWords = DocumentKeyWords;
            this.DocumentFilePath = DocumentFilePath;
            this.DocumentSubject = DocumentSubject;

            Console.WriteLine("Введите количество символов: ");
            DocumentTXTSignCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество строк: ");
            DocumentTXTStringCount = int.Parse(Console.ReadLine());
        }

        public override void DocumentInfo()
        {
            Console.WriteLine($"\nИмя: {DocumentName}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWords}\n" +
              $"Путь к файлу: {DocumentFilePath}\nТема документа: {DocumentSubject}\n" +
              $"Количество строк: {DocumentTXTStringCount}\n" +
              $"Количество символов: {DocumentTXTSignCount}\n");
        }
    }
    class HTML : SuperDocument
    {
        string DocumentHTMLClasses;
        int DocumentHTMLStringCount;

        public HTML(string DocumentName, string DocumentAuthor, string DocumentKeyWords, string DocumentFilePath,
          string DocumentSubject)
        {
            this.DocumentName = DocumentName;
            this.DocumentAuthor = DocumentAuthor;
            this.DocumentKeyWords = DocumentKeyWords;
            this.DocumentFilePath = DocumentFilePath;
            this.DocumentSubject = DocumentSubject;

            Console.WriteLine("Введите количество строк: ");
            DocumentHTMLStringCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите используемые классы: ");
            DocumentHTMLClasses = Console.ReadLine();
        }

        public override void DocumentInfo()
        {
            Console.WriteLine($"\nИмя: {DocumentName}\nАвтор: {DocumentAuthor}\nКлючевые слова: {DocumentKeyWords}\n" +
              $"Путь к файлу: {DocumentFilePath}\nТема документа: {DocumentSubject}\n" +
              $"Классы: {DocumentHTMLClasses}\n" +
              $"Количество строк: {DocumentHTMLStringCount}\n");
        }
    }

    class Singletone
    {
        private static Singletone instance;
        public static Singletone Instance
        {
            get {
                instance = new Singletone();
                return instance;
            }
        }
       
        public void Menu()
        {
            bool Exit = true;
            while (Exit)
            {

            Console.WriteLine("Что бы посмотреть информацию о документа HTML, нажмите 1, MSExcel нажмите 2," +
                "MSWord нажмите 3, PDF нажмите 4, TXT нажмите 5, что бы выйти, нажмите 6.");
            string choice= Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        HTML HTMLDoc = new HTML("Первый Документ", "Стасян", "Он, Она", "sfhd235dfhgj", "Какая-то тема");
                        HTMLDoc.DocumentInfo();
                        break;
                    case "2":
                        MSExcel MSExcelDoc = new MSExcel("Первый Документ", "Стасян", "Он, Она", "sfhd235dfhgj", "Какая-то тема");
                        MSExcelDoc.DocumentInfo();
                        break;
                    case "3":
                        MSWord MSWordDoc = new MSWord("Первый Документ", "Стасян", "Он, Она", "sfhd235dfhgj", "Какая-то тема");
                        MSWordDoc.DocumentInfo();
                        break;
                    case "4":
                        PDF PDFDoc = new PDF("Первый Документ", "Стасян", "Он, Она", "sfhd235dfhgj", "Какая-то тема");
                        PDFDoc.DocumentInfo();
                        break;
                    case "5":
                        TXT TXTDoc = new TXT("Первый Документ", "Стасян", "Он, Она", "sfhd235dfhgj", "Какая-то тема");
                        TXTDoc.DocumentInfo();
                        break;
                    case "6":
                        Exit = false;
                        break;
                    default: 
                        Console.WriteLine("Такого варианта ответа нет, нажмите на 1-5");
                        break;
                }

            }

 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singletone.Instance.Menu();
        }
    }
}