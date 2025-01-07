using G10Exam_YarmukhamedovaN.DataAccess.Entities;
using G10Exam_YarmukhamedovaN.Repositories;
using G10Exam_YarmukhamedovaN.Services.DTOs;
namespace G10Exam_YarmukhamedovaN.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;
    // private readonly object _moviesRepository;

    public MovieService()
    {
        _movieRepository = new MovieRepository();
    }

    private Movie ConverToEntity(MovieCreateDto movieCreateDto)
    {
        return new Movie
        {
            Id = Guid.NewGuid(),
            Title = movieCreateDto.Title,
            Director = movieCreateDto.Director,
            DurationMinutes = movieCreateDto.DurationMinutes,
            Raiting = movieCreateDto.Raiting,
            BoxOfficeEarnings = movieCreateDto.BoxOfficeEarnings,
            ReleaseDate = movieCreateDto.ReleaseDate,

        };
    }
    //  private List<MovieDto> _movies;

    public List<MovieDto> GetAllMoviesByDirector(string director)
    {
        var movies = _movieRepository.ReadAllMovies();

        var moviesByDirectorList = new List<MovieDto>();
        foreach (var _movies in movies)
        {
            if (_movies.Director == director)
            {

                moviesByDirectorList.Add(ConvertToEnity(_movies));
            }

        }
        return moviesByDirectorList;
    }

    private MovieDto ConvertToEnity(Movie movies)
    {
        throw new NotImplementedException();
    }

   public MovieDto GetHighestGrossingMovie()
    {
        throw new NotImplementedException();
    }

   public List<MovieDto> GetMoviesReleasedAfterYear(int year)
    {
        throw new NotImplementedException();
    }

   public List<MovieDto> GetMoviesSortedByRaiting()
    {
        throw new NotImplementedException();
    }

    List<MovieDto> IMovieService.GetMoviesWithinDurationRange(int minMinutes, int maxMinutes)
    {
        throw new NotImplementedException();
    }

    List<MovieDto> IMovieService.GetRecentMovies(int years)
    {
        throw new NotImplementedException();
    }

    MovieDto IMovieService.GetTopRatedMovie()
    {
        throw new NotImplementedException();
    }

    long IMovieService.GetTotalBoxOfficeEarningsByDirector(string director)
    {
        throw new NotImplementedException();
    }

    List<MovieDto> IMovieService.SearchMoviesByTitle(string keyword)
    {
        throw new NotImplementedException();
    }
}






    