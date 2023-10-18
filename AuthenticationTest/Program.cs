
using Firebase.Auth;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            a();
            Console.ReadKey();
        }

        static async void a()
        {
            string apiKey = "";
            FirebaseAuthProvider firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            FirebaseAuthLink link = await firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync("eewrrwe1@g.com", "sdfsfdsf");
            FirebaseAuthLink link1 = await firebaseAuthProvider.SignInWithEmailAndPasswordAsync("eewrrwe1@g.com", "sdfsfdsf");
            Console.WriteLine(link1.User.LocalId);

            IFirebaseConfig config = new FireSharp.Config.FirebaseConfig
            {
                AuthSecret = "",
                BasePath = ""
            };

            IFirebaseClient firebaseClient = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = firebaseClient.Set("1UpdateVersion", "2.30");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Успешно записано");
            }
            else
            {
                Console.WriteLine("Ошибка при записи данных: " + response.StatusCode);
            }

            FirebaseResponse response2 = firebaseClient.Get("1UpdateVersion");
            if (response2.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.ResultAs<string>());
            }
            else
            {
                Console.WriteLine("Ошибка при получении данных: " + response.StatusCode);
            }

            FirebaseResponse response1 = firebaseClient.Delete("1UpdateVersion");
            if (response1.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Успешно удалено!");
            }
            else
            {
                Console.WriteLine("Ошибка при удалении данных: " + response.StatusCode);
            }
        }
    }
}
