using MySportsClub.Models;

namespace MySportsClub.Services {
    // todo lesson 6-06a: IMailService interface 
    public interface IMailService {
        Task SendMailAsync(MailRequest mailRequest);
    }
}
