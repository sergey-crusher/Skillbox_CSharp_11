﻿using Lesson_11.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lesson_11
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public ObservableCollection<Client> clients = new ObservableCollection<Client>();
        private ObservableCollection<Client> _clients = new ObservableCollection<Client>();
        public static Worker worker;
        CreateClient taskWindow;

        public MainPage()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox.SelectedIndex = InitialWindow.ComboBoxIndex;
            worker = new Worker(ref clients);
            GetClients();
            dataGrid.ItemsSource = _clients;
        }

        private void GetClients()
        {
            if (((ComboBoxItem)(comboBox).SelectedItem).Content.ToString() == "Консультант")
            {
                worker = new Consultant(ref clients);
            }
            else
            {
                worker = new Manager(ref clients);
            }
            _clients.Clear();
            foreach (Client client in worker.GetClients())
            {
                _clients.Add(client);
            }
        }

        public void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ComboBoxItem)((ComboBox)sender).SelectedItem).Content != null)
            {
                GetClients();
            }
        }

        private void dataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            bool result = worker.UpdateClient((Client)e.Row.DataContext, e.Column.SortMemberPath, (e.EditingElement as TextBox).Text, _clients);
            if (!result)
            {
                GetClients();
            }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (worker.GetType().Name != "Consultant")
            {
                taskWindow = new CreateClient();
                taskWindow.ShowDialog();
                GetClients();
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав");
            }
        }

        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count > 0)
            {
                Client client = dataGrid.SelectedItems[0] as Client;
                worker.RemoveClient(client);
                GetClients();
            }
            else
            {
                MessageBox.Show("Выберите клиента которого желаете удалить");
            }
        }

        private void buttonSort_Click(object sender, RoutedEventArgs e)
        {
            worker.SortClinets();
            _clients.Clear();
            foreach (Client client in clients)
            {
                _clients.Add(client);
            }
        }
    }
}
