using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biblia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Book> books;
        public MainWindow()
        {
            InitializeComponent();
            
            List<User> users = new List<User>()
            {
                new User(0, "Андрей Санстрайк"),
                new User(1, "Герман Огнелюбный"),
                new User(2, "Василий Шаманов"),
                new User(3, "Хускар Аганимович"),
                new User(4, "Вячеслав Зиморин"),
                new User(5, "Владислав Дроффкин"),
                new User(6, "Виктор Вайперок"),
                new User(7, "Саша Белый"),
                new User(8, "Даниил Уставший"),
                new User(9, "Максим Оптоволокон"),
                new User(10, "Ангелина Рошанова"),
                new User(11,"Руслан Чиллигаторов"),
            };
            UserListView.ItemsSource = users;

            books = new List<Book>()
            {
                new Book(0, "Идиот"),
                new Book(1, "Сборник стихов Гумилёва"),
                new Book(2, "Архипелаг ГУЛАГ"),
                new Book(3, "Война и Мир"),
                new Book(4, "Сборник стихов Вячеслава Машнова"),
                new Book(5, "Трудно быть богом"),
                new Book(6, "Мастер и Маргарита"),
                new Book(7, "Котлован"),
                new Book(8, "Как удерживать лейны?!"),
                new Book(9, "Ради неё"),
                new Book(10, "Лучшие билды на инвокера 7.34d"),
            };

            BookListView.ItemsSource = books;

           

            UserComboBox.ItemsSource = users;
            UserComboBox.SelectedIndex = 0;

            BookComboBox.ItemsSource = books;
            BookComboBox.SelectedIndex = 0;
        }

        private void UserListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = UserListView.SelectedItem as User;
            TextUserId.Text = Convert.ToString(item.UserId);
            TextUserName.Text = item.UserName;
        }


        private void BookListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = BookListView.SelectedItem as Book;
            TextBookId.Text = Convert.ToString(item.BookId);
            TextTitle.Text = item.Title;
        }

        private void UsersBookView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UserComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserComboBox.SelectedItem is User user)
            {
                SelectedUser.Text = (string)(user.UserName);
                UserBookList.ItemsSource = (UserComboBox.SelectedItem as User).UserBook;
            }
        }

        private void BookComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BookComboBox.SelectedItem is Book book)
            {
                SelectedBook.Text = book.Title;

            }
        }


        private void GiveBook(object sender, RoutedEventArgs e)
        {
            if((UserComboBox.SelectedItem as User) != null && (BookComboBox.SelectedItem as Book)!= null) (UserComboBox.SelectedItem as User).UserBook.Add(BookComboBox.SelectedItem as Book);
            UserBookList.Items.Refresh();

        }


    }
}
