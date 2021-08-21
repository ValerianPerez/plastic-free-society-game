using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonChoiceController : MonoBehaviour
{
    #region Attributes
    public UnityEvent OnClick;

    public Text Title;

    public Text Description;
    #endregion

    #region Methods

    public void ActiveChoice()
    {
        this.OnClick.Invoke();
    }

    public void SetDescription(string text)
    {
        this.Description.text = text;
    }

    public void SetTitle(string text)
    {
        this.Title.text = text;
    }
    #endregion
}
