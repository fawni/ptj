using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.LiveTv;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Providers;

namespace PTP
{
    /// <summary>
    /// External id for a PTP movie.
    /// </summary>
    public class ExternalID : IExternalId
    {
        /// <inheritdoc />
        public string ProviderName => Plugin.Instance!.Configuration.LinkName;

        /// <inheritdoc />
        public string Key => MetadataProvider.Imdb.ToString();

        /// <inheritdoc />
        public ExternalIdMediaType? Type => ExternalIdMediaType.Movie;

        /// <inheritdoc />
        public string UrlFormatString => "https://passthepopcorn.me/torrents.php?imdb={0}";

        /// <inheritdoc />
        public bool Supports(IHasProviderIds item)
        {
            if (item is LiveTvProgram tvProgram && tvProgram.IsMovie)
            {
                return true;
            }

            return item is Movie;
        }
    }
}
