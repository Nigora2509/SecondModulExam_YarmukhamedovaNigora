using G10Exam_YarmukhamedovaN.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G10Exam_YarmukhamedovaN.Services;

public interface IMovieService
{
    List<MovieDto> GetAllMoviesByDirector(string director);
    MovieDto GetTopRatedMovie();
    List<MovieDto> GetMoviesReleasedAfterYear(int year);
    MovieDto GetHighestGrossingMovie();

    List<MovieDto> SearchMoviesByTitle(string keyword);

    List<MovieDto> GetMoviesWithinDurationRange(int minMinutes , int maxMinutes);

    long GetTotalBoxOfficeEarningsByDirector(string director);

    List<MovieDto> GetMoviesSortedByRaiting();

    List<MovieDto> GetRecentMovies(int years);
     
}
