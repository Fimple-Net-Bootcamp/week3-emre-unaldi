using VirtualPetCareWebAPI.Core.Utilities.Results.Abstracts;

namespace VirtualPetCareWebAPI.Core.Utilities.Results.Concretes
{
    public class Result : IResult
    {
        private bool _success;
        private string _message;

        public Result(bool success)
        {
            this.Success = success;
        }

        public Result(string message)
        {
            this.Message = message;
        }

        public Result(bool success, string message)
        {
            this.Message = message;
            this.Success = success;
        }

        public bool Success { get => _success; set => _success = value; }
        public string Message { get => _message; set => _message = value; }
    }
}
