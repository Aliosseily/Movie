using AutoMapper;
using AutoMapper.Execution;
using CleanMovie.Domain;
using CleanMovie.Infrastructure.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure.MappingConfig
{
	public class MappingDbToModelProfile: Profile
	{
		public MappingDbToModelProfile() 
		{
			// This line sets the naming convention for the source members (properties or fields) to PascalCase.
			// It means that AutoMapper will expect the source members to be named in PascalCase format(e.g., FirstName) when mapping.
			SourceMemberNamingConvention = new PascalCaseNamingConvention();
			// This line sets the naming convention for the destination members (properties or fields) to PascalCase.
			// It means that AutoMapper will generate the destination members in PascalCase format(e.g., FirstName) when mapping.
			DestinationMemberNamingConvention = new PascalCaseNamingConvention();
			// This line enables the mapping of null collections from source to destination.
			// By default, AutoMapper ignores null collections during mapping.Setting this property to true allows null collections to be mapped.
			AllowNullCollections = true;

			MapMovie();
			MapRental();
		}

		private void MapMovie()
		{
			//ReverseMap configures the mapping from Movie to TMovie and vice versa, allowing you to map both ways.
			CreateMap<TMovie, Movie>().ReverseMap();

			// CreateMap<TMovie, Movie>(); // TMovie to Movie
			//CreateMap<Movie, TMovie>(); // Movie to TMovie
		}

		private void MapRental()
		{
			CreateMap<TRental, Rental>();
		}


	}
}
