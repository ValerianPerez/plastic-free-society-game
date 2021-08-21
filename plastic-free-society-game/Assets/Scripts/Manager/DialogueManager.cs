using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VIDE_Data; //Import this to use VIDE Dialogue's VD class

public class DialogueManager : MonoBehaviour
{
    #region properties
    private PresentationTemplate template;
    #endregion

    #region Attributes
    public DialogueController DialogueController;
    #endregion

    #region Unity Built-In

    private void Start()
    {
        this.template = new PresentationTemplate();

        this.DialogueController.SetVisible(false);
    }
    #endregion


    #region Methods

    public void StartDialogue(VIDE_Assign assign)
    {
        VD.OnNodeChange += this.updateUI;
        VD.OnEnd += this.endDialogue;
        VD.BeginDialogue(assign);

        this.DialogueController.SetVisible(true);
    }

    public void MakeChoice(int number)
    {
        VD.nodeData.commentIndex = number; //Setting this when on a player node will decide which node we go next
        VD.Next();
    }
    #endregion

    #region functions
    private void updateUI(VD.NodeData data)
    {
        if (!data.isPlayer)
        {
            this.template.Description = data.comments[data.commentIndex];
            this.template.Portrait = data.sprites[data.commentIndex];
            VD.Next();
        } else {
            for (int i = 0; i < data.comments.Length; i++)
            {
                this.template.AddChoices(data.comments[i], (string)data.extraVars["Desc"+i]);
            }
            this.DialogueController.SetWindow(this.template);
            this.template.Reset();
        }
    }

    private void endDialogue(VD.NodeData data)
    {
        this.DialogueController.SetVisible(false);
        VD.EndDialogue();
        VD.OnNodeChange -= this.updateUI;
        VD.OnEnd -= this.endDialogue;
    }
    #endregion
}
