using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Common
{
	/// <summary>
	/// класс перечислителей
	/// </summary>
	public class DefaultConstants
	{
        public static readonly Guid UserRoleId = Guid.Parse("A7D09095-CEE9-4916-BCEB-72E3F74DB90D");
        public static readonly Guid SellerRoleId = Guid.Parse("BFAF5CCF-39FF-4074-9B05-07A1FAC72E20");
        public static readonly Guid AdminRoleId = Guid.Parse("8A07430A-403F-4CB0-B18F-0CBDD6FA53F2");
        /// <summary>
        /// Админ ID
        /// </summary>
        public static Guid AdminUserId = new Guid("548720ce-fd78-410d-b373-09fd6f5a407b");
        public static readonly string DefaultSystemLogName = "Система";
        /// <summary>
        /// Время кэширования файлов
        /// </summary>
        public  const int CacheAge = 60 * 60 * 24 * 30;
        /// <summary>
        /// Ответы
        /// </summary>
        public enum Result
		{
			ok = 1,
			error = 0
		}
        /// <summary>
        /// Права роли
        /// </summary>
        public enum RoleRights
        {
            [Description("Права администратора")]
            IsAdmin,
            [Description("Права продавца")]
            IsSeller,
            [Description("Доступ к корзине")]
            AccessToBasket,
            [Description("Права просматривать бренды")]
            AllowBrandsView,
            [Description("Права на просмотр товаров")]
            AllowProductsView,
            [Description("Просмотреть историю заказов")]
            AllowOrdersHistory,
            [Description("Права поддержки")]
            IsSupporter,
            [Description("Права пользователя")]
            IsUser
        }
    }
    
    /// <summary>
    /// Типы аккаунтов
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// Все
        /// </summary>
        [Description("Not set")]
        NotSet,
        /// <summary>
        /// Продавец
        /// </summary>
        [Description("Seller")]
        Seller
    }

    /// <summary>
    /// Типы логирования
    /// </summary>
    public enum LogType
    {
        /// <summary>
        /// Пользователь вошел в систему.
        /// </summary>
        [Description("Пользователь вошел в Систему"), Category("log")]
        Login,
        /// <summary>
        /// Пользователь вышел из системы.
        /// </summary>
        [Description("Пользователь вышел из Системы"), Category("log")]
        Logout,
        /// <summary>
        /// Пользователь зарегистрирован.
        /// </summary>
        [Description("Пользователь зарегистрировался"), Category("template")]
        Registration,
        /// <summary>
        /// Редактирование данных пользователя.
        /// </summary>
        [Description("Пользователь изменен"), Category("log")]
        EditUser,
        /// <summary>
        /// Пользователь удален.
        /// </summary>
        [Description("Пользователь удален"), Category("log")]
        DeleteUser,
        /// <summary>
        /// Пользователь восстановлен.
        /// </summary>
        [Description("Пользователь восстановлен"), Category("log")]
        RestoreUser,
        /// <summary>
        /// Пользователь подтвержден.
        /// </summary>
        [Description("Пользователь подтвержден"), Category("log")]
        UserApproved,
        /// <summary>
        /// Пользователь заблокирован.
        /// </summary>
        [Description("Пользователь заблокирован"), Category("log")]
        UserBlocked,
        /// <summary>
        /// Пользователь подал заявку на продавца (стал продавцом, еще без подтверждения).
        /// </summary>
        [Description("Пользователь подал заявку на продавца"), Category("log")]
        UserBecameSeller,
        /// <summary>
        /// Пользователь перестал быть продавцом.
        /// </summary>
        [Description("Пользователь перестал быть продавцом"), Category("log")]
        UserRemovedSellerStatus,
        /// <summary>
        /// Пользователь стал членом службы поддержки
        /// </summary>
        [Description("Пользователь стал членом службы поддержки"), Category("log")]
        UserBecameSupporter,
        /// <summary>
        /// Пользователь перестал быть членом службы поддержки
        /// </summary>
        [Description("Пользователь перестал быть членом службы поддержки"), Category("log")]
        UserRemovedSupporterStatus,
        [Description("Изменены системные настройки"), Category("log")]
        UpdateSettings,
        [Description("Ошибка при отправке почты")]
        MailSendError,
        [Description("Подтверждение учетной записи направлено"), Category("template")]
        ConfirmResend,
        [Description("Учетная запись подтверждена"), Category("template")]
        UserAccountConfirmed,
        [Description("Неудачная попытка активации пользователя")]
        WrongAttemptConfirmUserAccount,
        [Description("Обновление дочернего аккаунта Пользователя")]
        UpdateUserAccount,
        [Description("Изменены (созданы) сведения о бренде")]
        SellBrandChanged,
        [Description("Удален бренд")]
        SellBrandRemoved,
        [Description("Изменены (созданы) сведения о товаре")]
        ProductChanged,
        [Description("Удален товар")]
        ProductRemoved,
        [Description("Удалена учетная запись пользователя")]
        UserRemoved,
        [Description("Восстановлена учетная запись пользователя")]
        UserRecovery,
        [Description("Активация заблокированной учетной записи пользователя")]
        UserActivate, 
        [Description("Пользователь больше не подтвержден"), Category("log")]
        UserDisapprove,
        [Description("Пользователь подтвержден Администратором Системы"), Category("log")]
        UserApprovedByAdmin,
        [Description("Неудачная попытка сброса пароля")]
        PasswordResetInformationWrongAttempt,
        [Description("При сборке пароля указан некорректный секретный код")]
        PasswordResetInformationWrongSecurityCode,
        [Description("Сброс пароля успешно завершен"), Category("template")]
        PasswordResetInformationSuccess,
        [Description("Отправлена информация о сбросе пароля"), Category("template")]
        PasswordResetInformationSended
    }
    public enum UserStateValue
    {
        [Description("Не установлен")]
        notSet,
        [Description("Клиент зарегистрирован")]
        registered,
        [Description("С клиентом связались")]
        notified,
        [Description("Готов участвовать")]
        ready,
        [Description("Внес предоплату")]
        prepay,
        [Description("Не связываться")]
        doNotCall,
        [Description("Связаться позднее")]
        callLater,
        [Description("Сомневается, требуется проработка")]
        doubt,
        [Description("Оплатил")]
        success
    }
}
