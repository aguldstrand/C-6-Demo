using System;

namespace NameOfExpressions
{
    public class Program
    {
        public void Main(string[] args)
        {
            new Page(null);
        }

        class Page
        {
            public string Title { get; }

            public Page(string title)
            {
                if (title == null)
                {
                    throw new ArgumentException("Null value not allowed.", nameof(title));
                }

                this.Title = title;
            }
        }
    }
}
