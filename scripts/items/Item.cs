using Godot;
using System;

public abstract class Item {
	private String name;
	private int amount;
	
	public Item(String name, int amount) {
		this.name = name;
		this.aamount = amount;
	}
	
}
