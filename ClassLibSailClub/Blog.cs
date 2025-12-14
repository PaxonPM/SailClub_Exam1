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



        public BlogPost CreateBlogPost(Person person, string date, string time, string title, string body)
        {
            if(person.IsAdmin)
            {
                BlogPost tempPost = new BlogPost(date, time, title, body);
                BlogList.Add(tempPost);
                
                return tempPost;
               
            }
            else
            {
                throw new AccessViolationException($"ACCESS DENIED!\nThe member {person.Name} is not an admin");
            }
        }

        public BlogPost DeleteBlogPost(string title)
        {
            foreach (BlogPost post in BlogList)
            {
                if (post.Title == title)
                {
                    BlogList.Remove(post);
                    return post;
                }
            }
            return null;
        }


    }
}
