namespace DoctorWebForum.Controllers
{
    //Model used for passing any necessary parameters to view
    public class RenderActionViewModel
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public object RouteValues { get; set; }
    }
}