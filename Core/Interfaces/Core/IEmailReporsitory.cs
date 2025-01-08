using Core.Dtos.Core;

namespace Core.Interfaces.Core
{
    public interface IEmailReporsitory
    {
        Task SendEmail(EmailDto emaildata);
    }
}
