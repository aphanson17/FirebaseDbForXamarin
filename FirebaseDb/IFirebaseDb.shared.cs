using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.FirebaseDb
{
    public interface IFirebaseDb
    {
        Task<string> LoginWithEmailAndPasswordAsync(string email, string password);
    }
}
