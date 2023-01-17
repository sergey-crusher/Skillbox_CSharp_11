﻿using Lesson_11.interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Printing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;

namespace Lesson_11.models
{
    /// <summary>
    /// Клиент банка
    /// </summary>
    public class Client : ViewModelBase
    {
        #region Свойства
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname 
        {
            get 
            { 
                return surname; 
            } 
            set
            {
                if (surname != value)
                {
                    surname = value;
                    RaisePropertyChanged("Surname");
                }
            }
        }
        private string surname;
        /// <summary>
        /// Имя
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        private string name;
        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                if (patronymic != value)
                {
                    patronymic = value;
                    RaisePropertyChanged("Patronymic");
                }
            }
        }
        private string patronymic;
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (phone != value)
                { 
                    phone = value;
                    RaisePropertyChanged("Phone");
                }
            }
        }
        private string phone;
        /// <summary>
        /// Паспорт
        /// </summary>
        public string Passport
        {
            get
            {
                return passport;
            }
            set
            {
                if (passport != value)
                {
                    passport = value;
                    RaisePropertyChanged("Passport");
                }
            }
        }
        private string passport;
        /// <summary>
        /// Дата изменения анкеты
        /// </summary>
        public DateTime? ChangeDate
        {
            get
            {
                return changeDate;
            }
            set
            {
                if (changeDate != value)
                {
                    changeDate = value;
                    RaisePropertyChanged("ChangeDate");
                }
            }
        }
        private DateTime? changeDate;
        /// <summary>
        /// Какие данные поменялись
        /// </summary>
        public string? ChangeData
        {
            get
            {
                return changeData;
            }
            set
            {
                if (changeData != value)
                {
                    changeData = value;
                    RaisePropertyChanged("ChangeData");
                }
            }
        }
        private string? changeData;
        /// <summary>
        /// Тип изменений
        /// </summary>
        public string? Action
        {
            get
            {
                return action;
            }
            set
            {
                if (action != value)
                {
                    action = value;
                    RaisePropertyChanged("Action");
                }
            }
        }
        private string? action;
        /// <summary>
        /// Тот кто изменил данные
        /// </summary>
        public string? Changed
        {
            get
            {
                return changed;
            }
            set
            {
                if (changed != value)
                {
                    changed = value;
                    RaisePropertyChanged("Changed");
                }
            }
        }
        private string? changed;
        #endregion

        #region Конструкторы
        public Client(string Surname, string Name, string Patronymic, string Phone, string Passport)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic= Patronymic;
            this.Phone = Phone;
            this.Passport = Passport;
        }

        //public Client(string Surname, string Name, string Patronymic, string Phone, string Passport,
        //    DateTime? ChangeDate, string? ChangeData, string? Action, string? Changed)
        //{
        //    this.Surname = Surname;
        //    this.Name = Name;
        //    this.Patronymic = Patronymic;
        //    this.Phone = Phone;
        //    this.Passport = Passport;
        //    this.ChangeDate = ChangeDate;
        //    this.ChangeData = ChangeData;
        //    this.Action = Action;
        //    this.Changed = Changed;
        //}
        #endregion

        #region Методы
        public static void Get(ref ObservableCollection<Client> clients)
        {
            var load = JsonSerializer.Deserialize<ObservableCollection<Client>>(
                File.ReadAllText("./clients_db.json"));
            clients.Clear();
            //clients.Add(new Client("Алешин", "Сергей", "Андреевич", "79000000000", "0101 666666"));
            //clients.Add(new Client("Калачев", "Александр", "Дмитриевич", "71477807082", "9150 482404"));
            //clients.Add(new Client("Давыдов", "Савелий", "Михайлович", "75506053312", "8984 545180"));
            //clients.Add(new Client("Кузнецова", "Мирослава", "Михайловна", "75115850007", "1064 324723"));
            //clients.Add(new Client("Суханова", "Дарья", "Михайловна", "77656488040", "9433 637737"));
            //clients.Add(new Client("Сафонов", "Роман", "Константинович", "74608233441", "6994 237834"));
            //clients.Add(new Client("Антонова", "Александра", "Михайловна", "73608844401", "5831 663984"));
            //clients.Add(new Client("Колосова", "Арина", "Александровна", "78995675558", "7220 608261"));
            //clients.Add(new Client("Москвин", "Лев", "Маркович", "79226729418", "1665 625174"));
            //clients.Add(new Client("Кузнецов", "Илья", "Михайлович", "75387619776", "7792 994100"));
            //clients.Add(new Client("Прохорова", "Ксения", "Георгиевна", "72200943960", "7427 580776"));
            //clients.Add(new Client("Орлова", "Амелия", "Ивановна", "71477807081", "9231 103685"));
            //clients.Add(new Client("Кузнецов", "Матвей", "Артёмович", "75506053312", "9969 357758"));
            //clients.Add(new Client("Новиков", "Кирилл", "Степанович", "75115850003", "1902 742982"));
            //clients.Add(new Client("Трошин", "Марк", "Павлович", "77656488044", "5595 946000"));
            //clients.Add(new Client("Крылов", "Дмитрий", "Алексеевич", "74608233445", "7207 142509"));
            //clients.Add(new Client("Виноградов", "Дмитрий", "Александрович", "73608844406", "4155 239464"));
            //clients.Add(new Client("Юдина", "Варвара", "Львовна", "78995675557", "5848 956459"));
            //clients.Add(new Client("Филатова", "Сафия", "Никитична", "79226729418", "5782 224720"));
            //clients.Add(new Client("Костина", "Елизавета", "Арсеновна", "75387619779", "3707 474820"));
            //clients.Add(new Client("Макарова", "Ксения", "Михайловна", "72200943960", "8332 955632"));
            foreach (var item in load)
            {
                clients.Add(item);
            }
        }

        /// <summary>
        /// Скрытие паспортный данных
        /// </summary>
        /// <param name="clients">Список клиентов</param>
        /// <returns>Измененённый список клиентов</returns>
        public static ObservableCollection<Client> HidePassport(ObservableCollection<Client> clients)
        {
            ObservableCollection<Client> _clients = new ObservableCollection<Client>();
            foreach (var c in clients) 
            {
                Client temp_cl = new Client(
                    c.Surname, 
                    c.Name, 
                    c.Patronymic, 
                    c.Phone,
                    c.Passport);
                temp_cl.changeDate= c.ChangeDate;
                temp_cl.changeData= c.ChangeData;
                temp_cl.Action= c.Action;
                temp_cl.Changed= c.Changed;
                temp_cl.Passport = "******************";
                _clients.Add(temp_cl);
            }
            //clients.ToList().ForEach(x => x.Phone = "******************");
            return _clients;
        }

        /// <summary>
        /// Обновление данных клиента
        /// </summary>
        /// <param name="clients">Список клиентов</param>
        /// <param name="client">Изменяемый клиент</param>
        /// <param name="field">Изменяемое поле</param>
        /// <param name="value">Значение поля</param>
        /// <param name="_clients">Список клиентов (прошлый)</param>
        /// <param name="worker">Инициализировавший изменения</param>
        /// <returns>Результат обновления true - если успешно</returns>
        public static bool Update(
            ref ObservableCollection<Client> clients, 
            Client client, string field, 
            object value, 
            ObservableCollection<Client> _clients,
            Worker worker)
        {
            foreach (var item in typeof(Client).GetProperties())
            {
                if (item.Name == field)
                {
                    if (field == "Phone" && value == "")
                    {
                        MessageBox.Show("Номер телефона должен быть заполнен!");
                        return false;
                    }
                    var cl = clients.ElementAt(_clients.IndexOf(client));
                    cl.GetType()
                        .GetProperty(field)
                        .SetValue(cl, value);
                    break;
                }
            }
            Change(ref _clients, client, "Редактирование", worker, field);
            return true;
        }

        /// <summary>
        /// Удаление клиента
        /// </summary>
        /// <param name="clients">Список клиента</param>
        /// <param name="client">Удаляемый клиент</param>
        public static void Remove(ref ObservableCollection<Client> clients, Client client)
        {
            clients.Remove(client);
            SaveChange(clients);
        }

        /// <summary>
        /// Добавление клиента
        /// </summary>
        /// <param name="clients">Список клиентов</param>
        /// <param name="client">Добавляемый клиент</param>
        /// <param name="worker">Инициализировавший добавление</param>
        public static void Add(ref ObservableCollection<Client> clients, Client client, Worker worker)
        {
            clients.Add(client);
            Change(ref clients, client, "Добавление", worker, "Запись");
        }

        /// <summary>
        /// Изменение метаданных о записи
        /// </summary>
        /// <param name="clients">Список клиентов</param>
        /// <param name="client">Изменяемый клиент</param>
        /// <param name="action">Тип изменений</param>
        /// <param name="worker">Кто изменяет</param>
        /// <param name="field">Какие данные изменены</param>
        private static void Change(ref ObservableCollection<Client> clients, Client client, string action, Worker worker, string field)
        {
            var changeClient = clients.First(x => x == client);
            changeClient.ChangeDate = DateTime.Now;
            changeClient.ChangeData = field;
            changeClient.Action = action;
            changeClient.Changed = GetTypeWorker(worker);
            SaveChange(clients);
        }

        /// <summary>
        /// Сохрание данных в json файл
        /// </summary>
        /// <param name="clients">Список клиентов</param>
        private static void SaveChange(ObservableCollection<Client> clients)
        {
            string serialize = JsonSerializer.Serialize<ObservableCollection<Client>>(clients);
            File.WriteAllText("./clients_db.json", serialize);
        }

        /// <summary>
        /// Преобразование названия сотрудника из его типа
        /// </summary>
        /// <param name="worker">Сотрудник</param>
        /// <returns>Тип сотрудника</returns>
        private static string GetTypeWorker(Worker worker)
        {
            return worker.GetType().Name == "Consultant" ? "Консультант" : "Менеджер";
        }

        /// <summary>
        /// Сортировка по алфавиту
        /// </summary>
        /// <param name="clients">Список клиентов</param>
        public static void Sort(ref ObservableCollection<Client> clients)
        {
            var _clients = new ObservableCollection<Client>(clients.OrderBy(x => x.patronymic).OrderBy(x => x.name).OrderBy(x => x.surname));
            clients.Clear();
            foreach (var client in _clients)
            {
                clients.Add(client);
            }
        }
        #endregion
    }
}
