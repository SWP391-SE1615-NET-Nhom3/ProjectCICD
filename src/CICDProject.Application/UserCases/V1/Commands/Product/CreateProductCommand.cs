using CICDProject.Application.Abstractions.Message;


namespace CICDProject.Application.UserCases.V1.Commands.Product
{
    public class CreateProductCommand : ICommand
    {
        public string Name { get; set; }
    }
}
