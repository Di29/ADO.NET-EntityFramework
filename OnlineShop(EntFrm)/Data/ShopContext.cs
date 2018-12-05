namespace OnlineShop_EntFrm_.Data
{
    using OnlineShop_EntFrm_.Models;
    using System.Data.Entity;

    public class ShopContext : DbContext
    {
        // Контекст настроен для использования строки подключения "ShopContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "OnlineShop_EntFrm_.Data.ShopContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ShopContext" 
        // в файле конфигурации приложения.
        public ShopContext()
            : base("name=ShopContext")
        {
        }

        public DbSet<Item> Items { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}