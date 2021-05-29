using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementAPI.Model;

namespace UserManagementAPI.UserData
{
    public class UserService : IUserData
    {
        Random randomUser = new Random();
        public List<Users> usersData = new List<Users>();
        Users user = new Users();            


        public List<Users> GetUser()
        {
            return usersData;
        }

        public Users AddUser(Users user)
        {

            usersData.Add(user);
            return user;
        }

        public List<Users> GetRandomUser()
        {
            user.ID = Convert.ToString(new Random().Next(1111111, 9999999));
            user.Name = getRandomName();
            user.URL = getRandomURL();

            usersData.Add(user);
            return usersData;
        }

        public string getRandomName()
        {
            string[] nameOptions = { "John Doe", "Aaron Adkins", "Adam Cumins", 
                "Abigail Mei", "Kate Johnson", "Lily Aguilar ", "Alex Decosta", "Josh Abbott ", 
                "Emily Colins ", "Rachel Green", "Monica Mathew", "Taylor Sanchez" , "Davis Ray", "Thomas Albas"};
            int randomNumber = randomUser.Next(0, 13);
            string randomUserName = nameOptions[randomNumber];
            return randomUserName;
        }
        public string getRandomURL()
        {
            //https://picsum.photos/200
            string websiteURL = "https://picsum.photos/";
            int randomURLNumber = randomUser.Next(100,900);

            string randomURL = websiteURL + randomURLNumber;
            return randomURL;


        }
        


    }
}
