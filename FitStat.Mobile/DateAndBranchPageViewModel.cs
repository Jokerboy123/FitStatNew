﻿using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Contracts.Models;
using Services;
using Services.Abstractions;
using Services.WebAPIConsume;
using System.Globalization;

namespace FitStat.Mobile
{
    public class DateAndBranchPageViewModel
    {
        private string _date;
        private string _branchCode;
        public event PropertyChangedEventHandler? PropertyChanged;
        public string Date
        {
            get => _date;
            set 
            {
                if (_date != value)
                {
                    _date = value;
                    OnPropertyChanged();
                }
            }
        }

        public string BranchCode
        {
            get => _branchCode;
            set
            {
                if(_branchCode != value)
                {
                    _branchCode = value;
                    OnPropertyChanged();
                }
            }
        }
        
        public void OnPropertyChanged([CallerMemberName] string prop = "")  {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }


        public ICommand PostCommand { get; set; }
        private BranchWebAPIService _branchWebAPIService;
        public DateAndBranchPageViewModel()
        {
            PostCommand = new Command(async () => await Post());
            _branchWebAPIService = new BranchWebAPIService(new SettingsInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))));
        }
        

        public async Task Post() {
            var ParsedDate = DateTime.ParseExact(string.IsNullOrEmpty(Date) ? DateTime.Now.Date.ToString("dd.MM.yyyy") : Date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var model = await _branchWebAPIService.GetTrainingForBranchAndDay(ParsedDate, Guid.Parse(string.IsNullOrEmpty(BranchCode) ? Guid.Empty.ToString() : BranchCode));
            
            if (model != null && model.Entity != null)
                await Application.Current.MainPage.DisplayAlert("Проба метода...", string.Join(";\n", model.Entity), "OK");

          
        }
        // Кнопка "Отправить запрос" отвечает очень долго

        // Исправлено по видео от 11.03.2023.

        // Исправлено по видео от 18.03.2023.

        // 02.04.2023.

        // При клике на кнопку Send Date and Branch - молчание
    }
}
