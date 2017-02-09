using RockPaperScissors.Source.Service;

namespace RockPaperScissors.Source.Domain.Hands

{
    public interface Ihand
    {
        
        bool WinsFrom(Ihand ihand);
        Hand ToEnumValue();
        bool IsDraw(Ihand hand);
    }
}