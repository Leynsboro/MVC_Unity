using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterView : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private Button _nextButton;
    [SerializeField] private Button _previousButton;
    [SerializeField] private Button _selectButton;

    public Button NextButton => _nextButton;
    public Button PrevioustButton => _previousButton;
    public Button SelectButton => _selectButton;

    public void Show(Character character)
    {
        _image.sprite = character.Image;
        _name.text = character.Name;
    }
}
