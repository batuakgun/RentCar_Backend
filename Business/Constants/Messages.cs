using Core.Entities.Concrete;
using Entities.DTOs;
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

        public static string UserRegistered = "Başarılı Kayıt";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre Yanlış";
        public static string SuccessfulLogin = "Başarılı";
        public static string UserAlreadyExists ="Kullanıcı zaten var";
        public static string AccessTokenCreated = "Başarıyla Giriş Yaptınız";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string BrandListed = "Markalar Listelendi";
        public static string BrandG { get; internal set; }
        public static List<CarDetailDto> NoCar { get; internal set; }

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string ColorListed = "Renkler listelendi";
        public static string CardExist = "Kredi kartı var";
    }
}
