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

    ///<summary> Player Delegate </summary>
    public delegate void CalculateHealth(float amount);

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
        damage = (damage < 0) ? 0 : damage;
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    ///<summary> HealDamage method </summary>
    public void HealDamage(float heal)
    {
        heal = (heal < 0) ? 0 : heal;
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}
