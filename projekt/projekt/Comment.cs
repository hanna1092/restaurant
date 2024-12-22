using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Comment
    {
        public List<string> comments = new List<string>();
        public Comment() 
        {
            comments.Add("Zamowienie bylo przesolone");
            comments.Add("Bardzo Ci smakowalo");
            comments.Add("Bylo zjadliwe");
            comments.Add("Zamowienie bylo niedogotowane");
            comments.Add("Było za słodkie");
            comments.Add("W daniu brakowało glębi smaku");
        }
        public string GetComment()
        {
            Random random = new Random();
            return comments[random.Next(comments.Count)];
        }
    }
}
