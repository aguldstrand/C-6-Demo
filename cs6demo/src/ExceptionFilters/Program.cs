using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionFilters
{
    public class Program
    {
        public void Main(string[] args)
        {
            Cs5LogException();
            
            // Cs6LogException();
        }

        private void Cs5LogException()
        {
            try
            {
                var page = new Page(0, null);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("logging exception");
                throw;
            }
        }








        private void Cs6LogException()
        {
            try
            {
                var page = new Page(0, null);
            }
            catch (ArgumentException ex) when (LoggingFilter(ex))
            { }
        }

        bool LoggingFilter(ArgumentException ex)
        {
            Console.WriteLine("logging exception");

            return false;
        }
    }

    class Page
    {
        public int Id { get; }
        public string Title { get; }

        public Page(int id, string title)
        {
            if(id == 0)
            {
                throw new ArgumentException("0 value not allowed.", nameof(id));
            }

            if (title == null)
            {
                throw new ArgumentException("Null value not allowed.", nameof(title));
            }

            this.Title = title;
        }
    }
}
