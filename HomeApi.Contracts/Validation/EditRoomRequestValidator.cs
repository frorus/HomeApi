using FluentValidation;
using HomeApi.Contracts.Models.Rooms;
using System.Linq;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-валидатор запросов обновления комнат
    /// </summary>
    public class EditRoomRequestValidator : AbstractValidator<EditRoomRequest>
    {
        public EditRoomRequestValidator()
        {
            RuleFor(x => x.NewName).NotEmpty().Must(BeSupported)
                .WithMessage($"Please choose one of the following locations: {string.Join(", ", Values.ValidRooms)}");
            RuleFor(x => x.NewArea).NotEmpty().GreaterThan(0) 
                .WithMessage($"Please enter a positive number");
            RuleFor(x => x.NewGasConnected).Equals(true || false);
            RuleFor(x => x.NewVoltage).NotEmpty().InclusiveBetween(120, 220);
        }

        /// <summary>
        ///  Метод кастомной валидации для свойства location
        /// </summary>
        private bool BeSupported(string location)
        {
            return Values.ValidRooms.Any(e => e == location);
        }
    }
}
