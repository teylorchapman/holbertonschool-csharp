using System;

///<summary>
/// Public Class
///</summary>
public class Player
{
    ///<summary> Player Properties </summary>
    private string name;
    private float maxHp;
    private float hp;
    
    ///<summary> Status </summary>
    private string status;

    ///<summary> Player Delegate </summary>
    public delegate void CalculateHealth(float amount);

    ///<summary> HPCheck Handler </summary>
    public EventHandler<CurrentHPArgs> HPCheck;

    ///<summary> Constructor </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.hp = this.maxHp;
    }

    ///<summary> Printing player health method </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary> TakeDamage method </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        else
        {
            ValidateHP(hp -= damage);
        }
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    ///<summary> HealDamage method </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        else
        {
            ValidateHP(hp += heal);
        }
        Console.WriteLine($"{name} heals {heal} HP!");
    }

    ///<summary> ValidateHP method </summary>
    public void ValidateHP(float newHp)
    {
        hp = Math.Clamp(newHp, 0 , maxHp);
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    ///<summary> ApplyModifier method </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue * 0.5f;
        }
        else if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        else
        {
            return baseValue;
        }
    }
    
    ///<summary> CheckStatus Method </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        float state = e.currentHp/maxHp;
        if (state == 1)
            status = $"{name} is in perfect health!";
        else if (state >=0.5f)
            status = $"{name} is doing well!";
        else if (state >=0.25f)
            status = $"{name} isn't doing too great...";
        else if (state >0f)
            status = $"{name} needs help!";
        else
            status = $"{name} is knocked out!";

        Console.WriteLine(status);
    }
}

///<summary>
/// Enums
///</summary>
public enum Modifier
{
    ///<summary> Weakling </summary>
    Weak,
    ///<summary> Based </summary>
    Base,
    ///<summary> Stronk </summary>
    Strong
}

///<summary>
/// CalculateModifier delegate
///</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <sumary> class to handler the events </sumary>
public class CurrentHPArgs : EventArgs
{
    ///<summary> currentHp property </summary>
    public float currentHp { get; }
    
    /// <sumary> Constructor </sumary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
