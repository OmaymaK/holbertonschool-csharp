﻿using System;
/// <summary>
/// class player 
/// </summary>

    class Player
    {
        string name;
        float maxHp;
        float hp;

        public Player(string name = "Player", float maxHp= 100f)
        {
            this.name = name;
            if (maxHp <= 0){
                maxHp = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            }
            this.hp = maxHp;
            this.maxHp = maxHp;
        }

        public void PrintHealth()
        {
            Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
        }
    
    public delegate void CalculateHealth(float amount);

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }

	/// <summary>
	/// method TakeDamage
	/// </summary>
	/// <param name="damage">float</param>
	public void TakeDamage(float damage)
    {
        float newHp = hp;
		if(damage < 0)
        {
			damage = 0f;
			Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
			Console.WriteLine($"{name} takes {damage} damage!");
            newHp = hp - damage;
        }
        ValidateHP(newHp);
    }

	/// <summary>
	/// method HealDamage
	/// </summary>
	/// <param name="heal">float</param>
	public void HealDamage(float heal)
    {

        float newHp = hp;
		if(heal < 0)
        {
			heal = 0f;
			Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
			Console.WriteLine($"{name} heals {heal} HP!");
            newHp = hp + heal;
        }
        ValidateHP(newHp);
    }
    
    }

