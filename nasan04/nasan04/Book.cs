using System;

namespace nasan04
{
    public class Book
    {
       
       
        private int sidor;
        private string namn;

        public Book(string n, int p)
        {
            n = namn;
            p = sidor;
        }

         public string GetName()
        {
            return namn;
        }

        public int GetPages()
        {
            return sidor;
        }

        private int currentPage = 0;
        public void TurnPage()
        {
            currentPage += 1;
        }
        public int GetCurrentPage()
        {
            return currentPage;
        }
       
    }
}
