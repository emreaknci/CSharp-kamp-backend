﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductListed="Ürünler listelendi";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProdcutCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductUpdated="Ürün güncellendi";
        public static string ProductNameAlreadyExists="Aynı isimde ürün zaten var";
        public static string CategoryLimitExceded="Kategori limiti aşıldı";
    }
}
