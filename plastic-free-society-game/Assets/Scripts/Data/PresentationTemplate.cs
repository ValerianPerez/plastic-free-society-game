using System.Collections.Generic;
using UnityEngine;

public class PresentationTemplate
{
    public string Description { get; set; }
    public Sprite Portrait{ get; set; }

    public List<ChoiceTemplate> choices { get; set; }

    public PresentationTemplate()
    {
        this.choices = new List<ChoiceTemplate>();
    }

    public void Reset()
    {
        this.Description = string.Empty;
        this.Portrait = null;

        this.choices.Clear();
    }

    public void AddChoices(string title, string description)
    {
        ChoiceTemplate choice = new ChoiceTemplate();
        choice.Title = title;
        choice.Description = description;

        this.choices.Add(choice);
    }
}
