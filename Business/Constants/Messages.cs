using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string BrandNameInvalid = "Araba markası geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarUndelivered = "Araba teslim edilmemiş.";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerListed = "Müşteri listelendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerUpdated = " Müşteri güncellendi";
      
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserListed = "Kullanıcı listelendi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserUpdated = " Kullanıcı güncellendi";
     
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalsListed = "Kiralamalar listelendi";
        public static string RentalUpdated = "Kiralana Güncellendi";
        
        public static string ImagesAdded = "Fotoğraf eklendi";
        public static string DocAdded = "Dosya eklendi";
        public static string ImagesDeleted = "Fotoğraf silindi";
        public static string ImagesListed = "Fotoğraflar listelendi";
        public static string ImagesUpdated = "Fotoğraf günellendi";
        public static string MaxError = "Maksimum sayıya ulaşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered { get; internal set; }
        public static User UserNotFound { get; internal set; }
        public static User PasswordError { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
        public static string ProductUpdated { get; internal set; }
        public static string BrandListed { get; internal set; }
        public static string BrandG { get; internal set; }
        public static string BrandAdded { get; internal set; }
        public static string BrandDeleted { get; internal set; }
        public static string BrandUpdated { get; internal set; }
    }
}
