using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // decouples abstraction from implementation
    // abstraction -> abstraction -> implementation
    class Program
    {
        static void Main(string[] args)
        {
            List<Manuscript> documents = new List<Manuscript>();
            var formatter = new StandardFormatter();
            var reverseFormatter = new ReverseFormatter();
            var fancyFormatter = new FancyFormatter();

            var faq = new FAQ(fancyFormatter);

            faq.Title = "Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A designt pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate abstraction from implementation.");
            documents.Add(faq);

            var book = new Book(fancyFormatter)
            {
                Title = "Lots of Patterns",
                Author = "Joan Sonmez",
                Text = "Na nanana"
            };
            documents.Add(book);

            var paper = new TermPaper(fancyFormatter)
            {
                Class = "Design Patterns",
                Student = "John Doe",
                Text = "La alalalala",
                References = "GOF"
            };
            documents.Add(paper);

            foreach (var doc in documents)
            {
                doc.Print();
            }
        }
    }
}