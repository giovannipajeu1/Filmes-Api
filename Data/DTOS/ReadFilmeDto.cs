namespace FilmesApi.Data.DTOS;

    public class ReadFilmeDto
    {

        public string Tittle { get; set; }
        public string Gender { get; set; }
        public int Duration { get; set; }
        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    }