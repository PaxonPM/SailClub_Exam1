using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibSailClub
{
    public class Blog
    {
        List<BlogPost> BlogList { get; set; } = new List<BlogPost>();



        public void CreateBlogPost(Admin admin, string date, string time, string title, string body)
        {
            if(admin.IsAdmin)
            {
                BlogPost tempPost = new BlogPost(date, time, title, body);
                BlogList.Add(tempPost);
               
            }
            else
            {
                throw new AccessViolationException($"ACCESS DENIED!\nThe member {admin.Name} is not an admin");
            }
        }

       
    }
}
