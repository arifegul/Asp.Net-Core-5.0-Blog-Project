using BlogProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    Username="Arife"
                },
                new UserComment
                {
                    Id=2,
                    Username="Beyza"
                },
                new UserComment
                {
                    Id=3,
                    Username="Ayşe"
                }
            };
            return View(commentValues);
        }

    }
}
