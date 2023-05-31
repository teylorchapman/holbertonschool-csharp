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
    public void TakeDown(float damage)
    {
        if (damage < 0f)
        {
            damage = 0f;
            Console.WriteLine($"{name} takes {damage} damage!");
        }
    }

    ///<summary> HealDamage method </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            heal = 0f;
            Console.WriteLine($"{name} heals {heal} HP!")
        }
    }
}
