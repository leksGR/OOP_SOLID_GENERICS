using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_1
{
    public class Pair<T, U>
    {
        public T Id { get; set; }
        public U Password { get; set; }
        public Pair(T id, U password)
        {
            Id = id;
            Password = password;
        }
        public T GetId()
        {
            return Id;
        }
        public U GetPassword()
        {
            return Password;
        }
        public void ChangeId(T NewId)
        {
            Id = NewId;
            Console.WriteLine("Id успешно изменен");
        }
        public void ChangePassword(U NewPassword)
        {
            Password = NewPassword;
            Console.WriteLine("Пароль успешно изменен");
        }
    }
}
