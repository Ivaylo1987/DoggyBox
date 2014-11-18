namespace DoggyBox.Web.ViewModels.Courses
{
    using DoggyBox.Infrastructure.AutoMapper;
    using DoggyBox.Model;
    using System;
    using System.Collections.Generic;

    public class PracticeViewModel : IMapFrom<Practice>
    {
        public DateTime Date { get; set; }

        public virtual ICollection<TrainerViewModel> Trainers { get; set; }

        public virtual ICollection<DogViewModel> Dogs { get; set; }
    }
}