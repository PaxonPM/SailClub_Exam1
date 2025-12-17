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



        public BlogPost CreateBlogPost(Person person, BlogPost post)
        {
            person.Validate();

            
            post.Validate();

            if (!person.IsAdmin)
                throw new ArgumentException("Only admins can create blog posts.");

            if (!post.RoutineValidate())
                return null;

            BlogList.Add(post);

            return post;
           
        }

        public BlogPost ReadBlogPost(string title)
        {
            foreach (BlogPost post in BlogList)
            {
                if (post.Title == title)
                {
                    return post;
                }
            }

            return null;
        }

        public BlogPost DeleteBlogPost(Person person, string title)
        {
            person.Validate();

            if (!person.IsAdmin)
                throw new ArgumentException("Only admins can delete blog posts.");

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
