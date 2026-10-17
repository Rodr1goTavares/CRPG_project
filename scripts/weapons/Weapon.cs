using Godot;
using System;

public partial class Weapon : Item {
	
	private WeaponType type;
	private int damage;
	
	public Weapon(WeaponType type, int damage, String name) {
		this.type = type;
		this.damage = damage;
		super.name = name;
	}
	
}
