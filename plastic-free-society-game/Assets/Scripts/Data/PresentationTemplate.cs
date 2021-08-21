using System.Collections.Generic;
using UnityEngine.UI;

public class PresentationTemplate
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Image Portrait{ get; set; }

    public List<ChoiceTemplate> choices { get; set; }

}
