namespace Polymorphism.Extensions;

public static class SeasonExtension{
    public static Season Next(this Season currentSeason) {
        var current = (int)currentSeason;
        current = (current+1) % 4;
        return (Season)current;
    }
}