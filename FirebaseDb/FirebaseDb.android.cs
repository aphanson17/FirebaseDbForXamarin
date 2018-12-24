using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase;
using Firebase.Auth;

namespace Plugin.FirebaseDb
{
    /// <summary>
    /// Interface for FirebaseDb
    /// </summary>
    public class FirebaseDbImplementation : IFirebaseDb
    {
        public async Task<string> LoginWithEmailAndPasswordAsync(string email, string password)
        {
            var user = await FirebaseAuth.Instance.
                SignInWithEmailAndPasswordAsync(email, password);

            var token = await user.User.GetIdTokenAsync(false);

            return token.Token;
        }
    }
}
