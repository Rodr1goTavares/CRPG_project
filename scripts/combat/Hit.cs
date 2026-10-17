using Godot;
using System;

public partial class Hit {
	private int damage;
	private List<Efect> effects;
	private boolean critical;
	
	public Hit(int damage, boolean critical) {
		this.effects = new ArrayList<Effect>();
		this.damage = damage;
		this.critical = critical;
	}
	
	public void addEffect(Effect effect) {
		this.effects.Add(effect)
	}
	
	public int getTotalDamage() {
		return this.damage + 25/100 * this.damage;
	}
	
}
