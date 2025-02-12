// ISP
public interface IUserCreationService
{
    void CreateUser(User user);
    void DeleteUser(User user);
}

public interface IUserUpdateService
{
    void UpdateUser(User user);
}

public interface IUserQueryService
{
    User GetUser(int userId);
}

public class User
{
}

public interface IUserNotificationService
{
    void SendEmail(User user, string message);
}
// XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
// public interface IUserService
// {
//     void CreateUser(User user);
//     void DeleteUser(User user);
//     void UpdateUser(User user);
//     User GetUser(int userId);
//     void SendEmail(User user, string message);
// }