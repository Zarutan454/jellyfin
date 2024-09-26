using System;

namespace Jellyfin.Api.Models
{
    /// <summary>
    /// Represents information about an external video link.
    /// </summary>
    public class ExternalLinkInfo
    {
        /// <summary>
        /// Gets or sets the unique identifier for the link.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name or title of the video.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the URL of the external video.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the content type of the video (e.g., "movie", "episode").
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets any additional metadata for the video.
        /// </summary>
        public string Metadata { get; set; }
    }
}