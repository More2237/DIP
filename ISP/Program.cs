// ISP
using System;
using ISP.Interfaces;
using ISP.Classes;
public class Program
{
    public static void Main(string[] args)
    {
       UserService userService = new UserService();

        User user = new User { UserId = 1, Name = "Mr Bean", Password = "12344" };
        userService.CreateUser(user);

        user.Name = "John Wick";
        userService.UpdateUser(user);

        var retrievedUser = userService.GetUser(user.UserId);
        Console.WriteLine($"User ID: {retrievedUser.UserId}, Name: {retrievedUser.Name}, Password: {retrievedUser.Password}");

        userService.DeleteUser(user);
    }
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
