abstract class Character
{
    private string _characterType;


    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {_characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable()) return 10;
        else return 6;
    }
}

class Wizard : Character
{
    protected bool _vulnerable = false;

    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (_vulnerable) return 12;
        else return 3;
    }

    public void PrepareSpell()
    {
        _vulnerable = true;
    }

    public override bool Vulnerable()
    {
        return !_vulnerable;
    }
}