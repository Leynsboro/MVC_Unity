using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private CharacterView _characterView;
    [SerializeField] private CharactersSO _characters;

    private Controller _controller;
    
    private void Awake()
    {
        _controller = new Controller(_characterView, _characters);
    }
}
