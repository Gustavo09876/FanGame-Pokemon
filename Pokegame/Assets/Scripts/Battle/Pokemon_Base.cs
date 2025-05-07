using System;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;
using UnityEngine.TextCore.Text;

[CreateAssetMenu(fileName = "New Pokemon", menuName = "Pokemon/Create New Pokemon")]
public class Pokemon_Base : ScriptableObject
{
    [Title("Pokemon Base")]
    [SerializeField] string name;
    [SerializeField] PokemonType pokemonType1;
    [SerializeField] PokemonType pokemonType2;
    [SerializeField] AnimationClip animationF;
    [SerializeField] AnimationClip animationB;

    [Title("Pokemon Base Stats")]
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAtk;
    [SerializeField] int spDef;
    [SerializeField] int speed;
}

public enum PokemonType
{
    normal, fight, flying, poison, ground, rock, bug, ghost, steel, none, fire, water, grass, eletric, psychic, ice, dragon, shadow, fairy  
}
