using PustokProject.CoreModels;

namespace PustokProject.ViewModels.Books.Non_Admin;

public class VM_Home
{
    public IEnumerable<Slider> Sliders { get; set; }
    public IEnumerable<Book> Books { get; set; }
    
}