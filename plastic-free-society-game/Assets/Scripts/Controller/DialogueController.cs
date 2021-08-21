using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    #region Attributes
    [SerializeField]
    private Image CharacterPortrait;

    [SerializeField]
    private Text Descritpion;

    [SerializeField]
    private List<ButtonChoiceController> choices;
    #endregion

    public void MakeChoice(int number)
    {
        
    }

    public void SetWindow(PresentationTemplate presentation)
    {
        this.CharacterPortrait = presentation.Portrait;
        this.Descritpion.text = presentation.Description;

        for (int i = 0; i < choices.Count; i++)
        {
            choices[i].Title.text = presentation.choices[i].Title;
            choices[i].Description.text = presentation.choices[i].Description;
        }
    }
}
