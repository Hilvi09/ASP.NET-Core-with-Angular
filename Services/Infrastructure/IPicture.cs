using ASP.NET_Core_with_Angular.Models;

namespace ASP.NET_Core_with_Angular.Services.Infrastructure
{
    public interface IPicture
    {
        Picture GetPicture(int id);
        void insert(Picture picture);
        void update(Picture picture);
        void detele(int id);

        int Count();
        void Save();
    }
}
