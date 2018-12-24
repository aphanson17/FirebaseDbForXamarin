using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.FirebaseDb
{
    /// <summary>
    /// Interface for FirebaseDb
    /// </summary>
    public class FirebaseDbImplementation : IFirebaseDb
    {
        public Task<string> LoginWithEmailAndPasswordAsync(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
