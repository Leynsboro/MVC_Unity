using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Controller : IDisposable
{
    private CharacterView _characterView;
    private List<Character> _characters;

    private Character _currentCharacter;

    public Controller(CharacterView characterView, CharactersSO characters)
    {
        _characterView = characterView;
        _characters = characters.Characters;

        _characterView.NextButton.onClick.AddListener(Next);
        _characterView.PrevioustButton.onClick.AddListener(Previous);
        _characterView.SelectButton.onClick.AddListener(SayMyName);

        SetupCharacter();
    }

    public void Dispose()
    {
        _characterView.NextButton.onClick.RemoveListener(Next);
        _characterView.PrevioustButton.onClick.RemoveListener(Previous);
        _characterView.SelectButton.onClick.RemoveListener(SayMyName);
    }

    private void SetupCharacter()
    {
        _currentCharacter = _characters.First();
        ShowCharacter(_currentCharacter);
    }

    private void Next()
    {
        _currentCharacter = GetNextCharacter(_currentCharacter);
        ShowCharacter(_currentCharacter);
    }

    private void Previous()
    {
        _currentCharacter = GetPreviousCharacter(_currentCharacter);
        ShowCharacter(_currentCharacter);
    }

    private void ShowCharacter(Character character)
    {
        _characterView.Show(_currentCharacter);
    }

    private void SayMyName()
    {
        Debug.Log(_currentCharacter.Name);
    }

    private Character GetNextCharacter(Character currentCharacter)
    {
        int currentIndex = _characters.IndexOf(currentCharacter);
        int nextIndex = (currentIndex + 1) % _characters.Count;
        return _characters[nextIndex];
    }

    private Character GetPreviousCharacter(Character currentCharacter)
    {
        int currentIndex = _characters.IndexOf(currentCharacter);
        int previousIndex = (currentIndex - 1 + _characters.Count) % _characters.Count;
        return _characters[previousIndex];
    }
}
