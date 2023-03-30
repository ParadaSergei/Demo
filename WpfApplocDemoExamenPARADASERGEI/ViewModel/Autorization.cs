using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApplocDemoExamenPARADASERGEI.DbEntity;
using WpfApplocDemoExamenPARADASERGEI.View;

namespace WpfApplocDemoExamenPARADASERGEI.ViewModel
{
    public class Autorization:BaseViewModel
    {
        private User _user;
        private string _login;
        private string _password;

        public string Login
        {   
            get => _login;
          
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            } 
        }
        public string Password
        {
            get => _password;

            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public async Task<bool> Authorization(string login, string password)
        {
            try
            {
                var result = await DbStorage.Db.User.FirstOrDefaultAsync(user => user.Login == login && user.Password == password);
                _user = result;
                if (result != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Исключения!", MessageBoxButton.OK, MessageBoxImage.Stop);
                return false;
            }
        }
        public async void AuthorInApp()
        {

            if (await Authorization(Login, Password))
            {
                foreach (var item in App.Current.Windows)
                {
                    if (item is WindowTableProduct)
                    {
                        (item as Window)?.Hide();
                    }
                }
                return;
            }
            MessageBox.Show("Неверный логин или пароль", "Авторизация!", MessageBoxButton.OK, MessageBoxImage.Error);
        }


    }
}
