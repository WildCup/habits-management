namespace Habits;

public class Habit
{
    public string Trigger { get; set; } = string.Empty;
    public string Anticipation { get; set; } = string.Empty;
    public string Action { get; set; } = string.Empty;
    public string Reword { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public List<Note> Notes { get; set; } = new();
}

public class Note
{
    public DateTime Date { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Emotion> Emotions { get; set; } = new();
    public string SubstituteAction { get; set; } = string.Empty;
    public int Desire { get; set; }
    public bool Sinned { get; set; }
}

public class Emotion
{
    public EmotionType Type { get; set; }
    public int Strength { get; set; }
}

public class SubstituteAction
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Emotion> Emotions { get; set; } = new();
    public int Desire { get; set; }
}

public enum EmotionType
{
    Resistance = 0,
    Shame = 1,
    Guilt = 2,
    Apathy = 3,
    Grief = 4,
    Fear = 5,
    Desire = 6,
    Anger = 7,
    Pride = 8,
}

public enum Consciousness
{
    Bravery = 1,
    Neutrality = 2,
    Willingness = 3,
    Acceptance = 4,
    Wisdom = 5,
    Love = 6,
    Joy = 7,
    Pease = 8,
    Enlightenment = 9,
}