using Common;
using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Domain.Entities
{
    public class UserAccount: TrackedEntity
    {
        /// <summary>
        /// Почта аккаунта не используется!!!!Нигде!!!
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Имя.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Отчество.
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address1 { get; set; }
        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address2 { get; set; }
        /// <summary>
        /// Город.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Индекс.
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// Телефон.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Родительский код пользователя, к которому привязана информация.
        /// </summary>
        public Guid ParentId { get; set; }
        /// <summary>
        /// Родительский код пользователя, к которому привязана информация.
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Согласен с уловиями использования
        /// </summary>
        public bool AgreeWithTermsOfUse { get; set; }
        /// <summary>
        /// Id платежного аккаунта в платежной системе
        /// </summary>
        public string PaymentSystemAccountId { get; set; }
        /// <summary>
        /// Тип аккаунта
        /// </summary>
        public AccountType AccountType { get; set; }
    }
}
