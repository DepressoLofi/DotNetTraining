using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMMDotNetCore.ConsoleApp.Dtos;

namespace DMMDotNetCore.ConsoleApp.EFcoreExamples
{
    internal class EFCoreExample
    {
        private readonly AppDbContext db = new AppDbContext();
        public void Run()
        {
            Read();
            //Edit(6);
            //Edit(100);
            //Create("title christmas", "Christmas author", "content");
        }

        private void Read()
        {

            var list = db.BLogs.ToList();

            foreach (BlogDto blog in list)
            {
                Console.WriteLine(blog.BlogId);
                Console.WriteLine(blog.BlogTitle);
                Console.WriteLine(blog.BlogAuthor);
                Console.WriteLine(blog.BlogContent);
                Console.WriteLine("############");
            }
        }


        private void Edit(int id)
        {
            var blog = db.BLogs.FirstOrDefault(x => x.BlogId == id);

            if (blog is null)
            {
                Console.WriteLine("No data foud.");
                return;
            }
            Console.WriteLine(blog.BlogId);
            Console.WriteLine(blog.BlogTitle);
            Console.WriteLine(blog.BlogAuthor);
            Console.WriteLine(blog.BlogContent);
            Console.WriteLine("############");
        }

        private void Create(string title, string author, string content)
        {
            var item = new BlogDto
            {
                BlogTitle = title,
                BlogAuthor = author,
                BlogContent = content
            };

            db.BLogs.Add(item);
            int result = db.SaveChanges();
            string message = result > 0 ? "Saving Successful" : "Saving Failed.";

            Console.WriteLine(message);
        }

        private void Update(int id, string title, string author, string content)
        {

            var item = db.BLogs.FirstOrDefault(x => x.BlogId == id);

            if (item is null)
            {
                Console.WriteLine("No data foud.");
                return;
            }

            item.BlogTitle = title;
            item.BlogAuthor = author;
            item.BlogContent = content;

            db.SaveChanges();
        }

        private void Delete(int id)
        {
            var item = db.BLogs.FirstOrDefault(x => x.BlogId == id);

            if (item is null)
            {
                Console.WriteLine("No data foud.");
                return;
            }

            db.BLogs.Remove(item);
            int result = db.SaveChanges();
            string message = result > 0 ? "Saving sucess" : "saving failed";
            Console.WriteLine(message);

        }
    }
}
