using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Characters", menuName = "Characters", order = 0)]
public class CharactersSO : ScriptableObject
{
    [SerializeField] private List<Character> _characters;

    public List<Character> Characters => _characters;
}
