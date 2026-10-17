using Godot;
using System;

public partial class Entity {
	private String name;
	int level;
	long xp;
	private int hp;
	private int adp;
	private int armor;
	private int inteligence;
	private boolean dead;
	
	public Entity(String name, int hp, int adp, int armor, int inteligence) {
		this.name = name;
		this.hp = hp;
		this.adp = adp;
		this.armor = armor;
		this.inteligence = inteligence;
		
		// Default sets
		this.dead = false;
		this.level = 0;
		this.xp = 0;
	}

	public void talk() {}

	public void startCombat() {}
	
}
