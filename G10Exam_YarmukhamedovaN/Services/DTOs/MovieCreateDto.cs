using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G10Exam_YarmukhamedovaN.Services.DTOs
{
    public class MovieCreateDto : MovieDto
    {
        public string Title { get; set; }

        public string Director { get; set; }

        public int DurationMinutes { get; set; }

        public double Raiting { get; set; }

        public long BoxOfficeEarnings { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
