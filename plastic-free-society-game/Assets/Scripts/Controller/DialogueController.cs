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

    [SerializeField]
    private DialogueManager dialogueManager;

    #endregion

    #region Unity Built-In
    private void Start()
    {
        this.dialogueManager.DialogueController = this;
    }
    #endregion

    #region Methods

    public void MakeChoice(int number)
    {
        this.dialogueManager.MakeChoice(number);
    }

    public void SetWindow(PresentationTemplate presentation)
    {
        this.CharacterPortrait.sprite = presentation.Portrait;
        this.Descritpion.text = presentation.Description;

        for (int i = 0; i < choices.Count; i++)
        {
            bool isDisplayble = i < presentation.choices.Count;
            choices[i].gameObject.SetActive(isDisplayble);

            if (isDisplayble)
            {
                choices[i].Title.text = presentation.choices[i].Title;
                choices[i].Description.text = presentation.choices[i].Description;
            }
        }
    }

    public void SetVisible(bool isVisible)
    {
        this.transform.gameObject.SetActive(isVisible);
    }
    #endregion

}
