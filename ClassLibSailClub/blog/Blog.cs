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
            person.Validate();

            BlogPost tempPost = new BlogPost(date, time, title, body);
            tempPost.Validate();

            if (!tempPost.RoutineValidate())
                return null;
            
            BlogList.Add(tempPost);

            return tempPost;
           
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
