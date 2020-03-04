using Soccer.Common.Helpers;

namespace Soccer.Common.Models
{
    public class TeamResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LogoPath { get; set; }

        public string LogoFullPath => string.IsNullOrEmpty(LogoPath)
            ? Constants.Path.PathNoImage
            : Constants.URL_BASE + LogoPath.Substring(1);
        //public string LogoFullPath => string.IsNullOrEmpty(LogoPath)
        //    ? "https://SoccerWeb0.azurewebsites.net//images/noimage.png"
        //    : $"https://SoccerWeb0.azurewebsites.net{LogoPath.Substring(1)}";
    }
}
