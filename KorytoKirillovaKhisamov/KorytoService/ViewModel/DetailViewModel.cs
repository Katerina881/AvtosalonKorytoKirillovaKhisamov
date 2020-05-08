﻿using System.ComponentModel;

namespace KorytoService.ViewModel
{
    public class DetailViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название детали")]
        public string DetailName { get; set; }

        [DisplayName("Количество детали")]
        public int TotalAmount { get; set; }
    }
}
