﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameTrackerLibrary.Models;

namespace VideoGameTrackerLibrary.Queries.Genres
{
    public class GetGenreByIdQuery : IRequest<GenresModel>
    {
        public int GenreId { get; set; }

        public GetGenreByIdQuery(int genreId)
        {
            GenreId = genreId;
        }
    }
}
