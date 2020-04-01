using Soccer.Common.Enums;

namespace Soccer.Common.Models
{
    public class UserResponse
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string RFC { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PicturePath { get; set; }

        //public string PictureFullPath => string.IsNullOrEmpty(PicturePath)
        //    ? "https://SoccerWeb0.azurewebsites.net//images/noimage.png"
        //    : LoginType == LoginType.Soccer ? $"https://SoccerWeb0.azurewebsites.net{PicturePath.Substring(1)}" : PicturePath;

        public string PictureFullPath => string.IsNullOrEmpty(PicturePath)
            ? "http://10.1.114.74:84//images/noimage.png"
            : LoginType == LoginType.Soccer ? $"http://10.1.114.74:84{PicturePath.Substring(1)}" : PicturePath;

        public LoginType LoginType { get; set; }
        public UserType UserType { get; set; }

        public TeamResponse Team { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWithDocument => $"{FirstName} {LastName} - {RFC}";

    }
}