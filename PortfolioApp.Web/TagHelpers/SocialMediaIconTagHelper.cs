using AutoMapper;
using Microsoft.AspNetCore.Razor.TagHelpers;
using PortfolioApp.Business.Interfaces;

namespace PortfolioApp.Web.TagHelpers
{
    [HtmlTargetElement("getIcons")]
    public class SocialMediaIconTagHelper : TagHelper
    {
        private readonly IUserService _userService;
        private readonly ISocialMediaIconService _socialMediaIconService;
        private readonly IMapper _mapper;

        public SocialMediaIconTagHelper(IUserService userService, ISocialMediaIconService socialMediaIconService, IMapper mapper)
        {
            _userService = userService;
            _socialMediaIconService = socialMediaIconService;
            _mapper = mapper;
        }

        [HtmlAttributeName("user-id")]
        public int UserId { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var socialMediaIcons = _socialMediaIconService.GetByUserId(UserId);
            string data = "<div class='unit - 50'><ul class='social list-flat right'>";

            foreach (var item in socialMediaIcons)
            {
                data += $@">
						<li><a href='{item.Link}'><i class='{item.Icon}'></i></a></li>";
            }

            data += "</ul></div>";
            output.Content.SetHtmlContent(data);
        }
    }
}
